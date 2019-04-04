using AutotestTFS.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestTFS.PageObjects
{
    class ProjectHomePage: TFSPage
    {
        public ProjectHomePage(IWebDriver driver)
            :base(driver)
        {
            
        }

    }
}
