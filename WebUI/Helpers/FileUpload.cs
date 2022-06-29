namespace WebUI.Helpers
{
    public class FileUpload : IFileUpload
    {
        private string[] FileExtensions = { ".png", ".jpg", ".jpeg" };
        private readonly IWebHostEnvironment _webHost;

        public FileUpload(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }
        /// <summary>
        /// Resim Adını Alarak image klasörü içinde bulur resmi siler
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string DeleteImage(string Name)
        {
            var Message = "Resim Silindi";
            if (string.IsNullOrEmpty(Name))
            {
                return "Resim Bulunamadı";
            }
            string ımageToBeDeleted = Path.Combine(_webHost.WebRootPath, "images\\*", Name);
            if ((File.Exists(ımageToBeDeleted)))
            {
                File.Delete(ımageToBeDeleted);
            }
            return Message;
           
        }

        public List<string> FileListUpload(List<IFormFile> files)
        {
            var imageUrlList = new List<string>();
            List<string> Failed = new List<string> { "Failed" };
            foreach (var file in files)
            {
                string UrlPath = "";
                string FileName = "";
                try
                {
                    ImageSave(file,ref UrlPath,ref FileName); 
                }
                catch (Exception)
                {

                    return Failed;
                }
            }
            return imageUrlList;
        }

        public string UpdateFile(IFormFile file, string Name)
        {
            string urlPath = "";
            string fileName = "";
            try
            {
                ImageSave(file, ref urlPath, ref fileName);

            }
            catch (Exception)
            {

                return "Failed";
            }

            string _imageToBeDeleted = Path.Combine(_webHost.WebRootPath, "images\\", Name);
            if ((File.Exists(_imageToBeDeleted)))
            {
                File.Delete(_imageToBeDeleted);
            }

            return $"{urlPath}";
        }

        string IFileUpload.FileUpload(IFormFile file)
        {
            string urlPath = "";
            string fileName = "";
            try
            {
                ImageSave(file, ref urlPath, ref fileName);
            }
            catch (Exception)
            {

                return "Failed";
            }

            return $"{urlPath}";
        }
        private void ImageSave(IFormFile file,ref string UrlPath,ref string FileName)
        {
            var guid = Guid.NewGuid();
            var subGuid = guid.ToString().Substring(0, 13);
            var fileExt = Path.GetExtension(file.FileName).ToLowerInvariant();
            if(file!=null&& FileExtensions.Contains(fileExt))
            {
                FileName = file.FileName;
                var path = Path.Combine(_webHost.WebRootPath, "images\\", $"{subGuid}-{FileName}");
                UrlPath = $"{subGuid}-{FileName}";
                using var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
            }
        }
    }
}
