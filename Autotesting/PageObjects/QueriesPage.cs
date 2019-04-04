using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestTFS.PageObjects
{
    class QueriesPage : TFSPage
    {
        public QueriesPage(IWebDriver driver)
            :base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'leftPane')]//span[text()='Создание']")]
        public IWebElement Creation;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'leftPane')]//span[text()='Task']")]
        public IWebElement CreationTask;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//input[@aria-label='Поле заголовка']")]
        public IWebElement FieldTitle;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//div[@aria-label='Назначено полю']")]
        public IWebElement AssertTo;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//input[@aria-label='Поиск среди пользователей']")]
        public IWebElement AssertToSearch;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//span[text()='Сохранить']")]
        public IWebElement Save;
    }
}
