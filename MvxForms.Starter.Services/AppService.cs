using System;

namespace MvxForms.Starter.Services
{
    public class AppService : IAppService
    {
        public string WhatTimeIsIt()
        {
            return DateTime.Now.ToString("H:mm:ss");
        }
    }
}
