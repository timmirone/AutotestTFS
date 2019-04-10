using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutotestTFS.PageObjects
{
    class TFSPage
    {
        private IWebDriver driver;
        public TFSPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Вернуться на домашнюю страницу']")]
        public IWebElement GoToHomePage;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Панели мониторинга']")]
        public IWebElement Dashboards;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Обзор']")]
        public IWebElement ViewDashboard;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Код']")]
        public IWebElement Code;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Файлы']")]
        public IWebElement Files;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Фиксации']")]
        public IWebElement Commits;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Работа']")]
        public IWebElement Work;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Запросы']")]
        public IWebElement Queries;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Сборка и выпуск']")]
        public IWebElement BuildAndReleases;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Тест']")]
        public IWebElement TestManagement;

        [FindsBy(How = How.XPath, Using = "//table[@aria-label='Навигация верхнего уровня']//a/span[text()='Вики-сайт']")]
        public IWebElement Wiki;

        public void WaitForLoadPage(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            int timeoutSec = 15;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
            Thread.Sleep(100);
        }
        
        public void WaitForLoadApplication()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(wd => !(driver.FindElement(By.CssSelector("div.control-busy-overlay")).Displayed));
            Thread.Sleep(100);
        }
    }
}
