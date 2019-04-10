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

        [FindsBy(How = How.XPath, Using = "//a/div[contains(text(),'Назначено мне')]")]
        public IWebElement AssignToMe;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'leftPane')]//span[text()='Создание']")]
        public IWebElement Creation;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'leftPane')]//span[text()='Task']")]
        public IWebElement CreationTask;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'leftPane')]//span[text()='Bug']")]
        public IWebElement CreationBug;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//div[@aria-label='Таблица результатов запросов']//span[@aria-label='Обновить']")]
        public IWebElement UpdateList;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//input[@aria-label='Поле заголовка' and @aria-invalid='true']")]
        public IWebElement FieldTitle;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//span[@aria-label='Выбранное удостоверение ']//ancestor::div[@aria-label='Назначено полю']")]
        public IWebElement AssertTo;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//input[@aria-label='Поиск среди пользователей' and @aria-expanded='true']")]
        public IWebElement AssertToSearch;

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'rightPane')]//span[@aria-label='State']//ancestor::div[@class='work-item-header-control-container']//div[@class='wrap']//input)[last()]")]
        public IWebElement FieldState;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//li[@aria-disabled='false']//span[text()='Сохранить']")]
        public IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'rightPane')]//ul[@class='menu-bar']//li[@aria-posinset='5' and @aria-label='Действия']")]
        public IWebElement MenuActions;

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'rightPane')]//span[text()='Удалить'])[last()]")]
        public IWebElement Delete;

        [FindsBy(How = How.XPath, Using = "//div[@role='dialog']//span[text()='Удалить']")]
        public IWebElement AlertDialogDelete;
    }
}
