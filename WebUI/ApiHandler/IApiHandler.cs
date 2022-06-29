﻿using DTO;

namespace WebUI.ApiHandler
{
    public interface IApiHandler
    {
        T GetApi<T>(string url);
        T PostApi<T>(dynamic dynamicModel, string Url);
    }
}
