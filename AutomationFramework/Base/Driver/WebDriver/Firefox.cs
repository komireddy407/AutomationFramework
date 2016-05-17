﻿using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace AutomationFrameWork.Driver.Core
{
    class Firefox : Drivers
    {
        private static readonly Firefox _instance = new Firefox();
        static Firefox ()
        {
        }
        private Firefox ()
        {

        }

        public static Firefox Instance
        {
            get
            {
                return _instance;
            }
        }
        protected override void StartDriver ()
        {
            Drivers.DriverStorage = new FirefoxDriver(Firefox.Instance.DesiredCapabilities);
        }
        /// <summary>
        /// Not implement this method for firefox
        /// </summary>
        protected override object DriverOption
        {
            get
            {
                return null;
            }
        }


        private DesiredCapabilities DesiredCapabilities
        {
            get
            {
                return Drivers.DesiredCapabilitiesCore;
            }
        }
    }
}