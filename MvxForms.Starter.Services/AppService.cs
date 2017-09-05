using System;

namespace MvxForms.Starter.Services
{
    /// <summary>
    /// Test app service
    /// </summary>
    public class AppService : IAppService
    {
        /// <summary>
        /// What time is it ?
        /// </summary>
        /// <returns></returns>
        public string WhatTimeIsIt()
        {
            return DateTime.Now.ToString("H:mm:ss");
        }
    }
}
