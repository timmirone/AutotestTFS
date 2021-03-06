﻿using AutotestTFS.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace AutotestTFS
{
    [TestFixture]
    public class TestClass
    {
       /*
        [Test]
        public void LoginFF()
        {
          
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\geckodriver-v0.24.0-win64", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Mozilla Firefox\firefox.exe";

            IWebDriver driver = new FirefoxDriver(service);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://{login}:{password}@{hostname}");
            driver.Close();
            driver.Close();
            driver.Quit();
        }
        */
        [Test]
        public void AllTabs()
        {
            
            IWebDriver driver = new ChromeDriver();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://{login}:{password}@{hostname}");
            TFSPage CurrentPage = new ProjectHomePage(driver);
            //CurrentPage.GoToHomePage.Click();
            //driver.FindElement(By.XPath("//span[text()='Все']/ancestor::div[@class='hub-group']//a[contains(@aria-label,'ingosstrakh')]")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Dashboards)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Code)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Work)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.BuildAndReleases)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.TestManagement)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Wiki)).Click();
            CurrentPage.WaitForLoadPage(driver);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void AllSubTabs()
        {

            IWebDriver driver = new ChromeDriver();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions MouseHover = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://{login}:{password}@{hostname}");
            TFSPage CurrentPage = new ProjectHomePage(driver);
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Dashboards));
            MouseHover.MoveToElement(CurrentPage.Dashboards).Perform();
            CurrentPage.ViewDashboard.Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Code));
            MouseHover = new Actions(driver);
            MouseHover.MoveToElement(CurrentPage.Code).Perform();
            CurrentPage.Files.Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Code));
            MouseHover = new Actions(driver);
            MouseHover.MoveToElement(CurrentPage.Code).Perform();
            CurrentPage.Commits.Click();
            CurrentPage.WaitForLoadPage(driver);
            /*wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Backlogs)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Build)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.TestManagement)).Click();
            CurrentPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(CurrentPage.Wiki)).Click();
            CurrentPage.WaitForLoadPage(driver);*/
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void CreateTask()
        {

            IWebDriver driver = new ChromeDriver();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions MouseHover = new Actions(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://{login}:{password}@{hostname}");
            ProjectHomePage StartPage = new ProjectHomePage(driver);
            StartPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(StartPage.Work));
            MouseHover.MoveToElement(StartPage.Work).Perform();
            StartPage.Queries.Click();
            StartPage.WaitForLoadPage(driver);
            QueriesPage qPage = new QueriesPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.Creation)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.CreationTask)).Click();
            driver.Navigate().GoToUrl("https://{login}:{password}@{hostname}");
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.Creation)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.CreationTask)).Click();
            qPage.WaitForLoadPage(driver);
            Assert.AreEqual(driver.FindElement(By.ClassName("info-text")).Text, "Поле \"Title\" не может быть пустым.");
            qPage.FieldTitle.SendKeys("testTask");
            qPage.AssertTo.Click();
            qPage.AssertToSearch.SendKeys("userName");
            qPage.AssertToSearch.SendKeys(Keys.Tab);
            qPage.Save.Click();
            qPage.WaitForLoadApplication();
            qPage.FieldState.Clear();
            qPage.FieldState.Click();
            qPage.FieldState.SendKeys("Active");
            qPage.Save.Click();
            qPage.WaitForLoadApplication();
            qPage.FieldState.Clear();
            qPage.FieldState.Click();
            qPage.FieldState.SendKeys("Closed");
            qPage.Save.Click();
            qPage.WaitForLoadApplication();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.Creation)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.CreationBug)).Click();
            qPage.WaitForLoadPage(driver);
            Assert.AreEqual(driver.FindElement(By.ClassName("info-text")).Text, "Поле \"Title\" не может быть пустым.");
            qPage.FieldTitle.SendKeys("testBug");
            qPage.AssertTo.Click();
            qPage.AssertToSearch.SendKeys("userName");
            qPage.AssertToSearch.SendKeys(Keys.Tab);
            qPage.Save.Click();
            qPage.WaitForLoadApplication();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.AssignToMe)).Click();
            qPage.WaitForLoadApplication();
            //wait.Until(ExpectedConditions.ElementToBeClickable(qPage.FieldTitle));
            Actions DoubleClickAction = new Actions(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.UpdateList)).Click();
            qPage.WaitForLoadApplication();
            DoubleClickAction.DoubleClick(driver.FindElement(By.LinkText("testBug"))).Perform();
            qPage.WaitForLoadPage(driver);
            qPage.WaitForLoadApplication();
            qPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.FieldState));
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.MenuActions)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.Delete)).Click();
            qPage.WaitForLoadPage(driver);
            qPage.WaitForLoadApplication();
            qPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.AlertDialogDelete)).Click();
            qPage.WaitForLoadPage(driver);
            qPage.WaitForLoadApplication();
            qPage.WaitForLoadPage(driver);
            //wait.Until(ExpectedConditions.ElementToBeClickable(qPage.FieldState)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.MenuActions)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.Delete)).Click();
            qPage.WaitForLoadPage(driver);
            qPage.WaitForLoadApplication();
            qPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.AlertDialogDelete)).Click();
            qPage.WaitForLoadPage(driver);
            qPage.WaitForLoadApplication();
            qPage.WaitForLoadPage(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(qPage.AssignToMe));
            driver.Close();
            driver.Quit();
        }
    }
}
