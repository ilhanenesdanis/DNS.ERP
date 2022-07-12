using Core.Entity;
using Core.IRepository;
using Core.IUnitOfWork;
using Manager.IService;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Caching.CacheService
{
    public class BrandCache : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDistributedCache _cache;
        public BrandCache(IBrandRepository brandRepository, IUnitOfWork unitOfWork, IDistributedCache cache)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        public void Add(Brand entity)
        {
            _brandRepository.Add(entity);
            _unitOfWork.SaveChanges();
            CacheAllBrand();
        }

        public void AddRange(List<Brand> entities)
        {
            _brandRepository.AddRange(entities);
            _unitOfWork.SaveChanges();
            CacheAllBrand();
        }

        public bool Any(Expression<Func<Brand, bool>> expression)
        {
            return _brandRepository.Any(expression);
        }

        public void Delete(Brand entity)
        {
            _brandRepository.Delete(entity);
            _unitOfWork.SaveChanges();
            CacheAllBrand();
        }

        public List<Brand> GetAll()
        {
            return GetAllCacheBrand();
        }

        public List<Brand> GetBy(Expression<Func<Brand, bool>> expression)
        {
            return GetAllCacheBrand().Where(expression.Compile()).ToList();
        }

        public Brand GetById(int id)
        {
            return GetAllCacheBrand().FirstOrDefault(x => x.Id == id);
        }

        public void Update(Brand entity)
        {
            _brandRepository.Update(entity);
            _unitOfWork.SaveChanges();
            CacheAllBrand();
        }

        public void UpdateRange(List<Brand> entities)
        {
            _brandRepository.UpdateRange(entities);
            _unitOfWork.SaveChanges();
            CacheAllBrand();
        }
        public void CacheAllBrand()
        {
            string jsonList = JsonConvert.SerializeObject(_brandRepository.GetAll());
            _cache.SetString("Brand", jsonList);
        }
        public List<Brand> GetAllCacheBrand()
        {
            try
            {
                var data = _cache.GetString("Brand");
                List<Brand> brands = JsonConvert.DeserializeObject<List<Brand>>(data);
                return brands;
            }
            catch
            {
                CacheAllBrand();
                return _brandRepository.GetAll().ToList();
            }
           
        }
    }
}
