using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PayPodOrderForm1.Utillities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PayPodOrderForm1.PageObject
{
    class PayPodPage
    {
        public PayPodPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;



        IWebElement SelectMake => driver.FindElement(By.CssSelector("#vehicleBrand"));

        IWebElement SelectModel => driver.FindElement(By.CssSelector("#vehicleId"));

        IWebElement NewButton => driver.FindElement(By.XPath("//*[@id='carMakeAndModel']/div/div/div[1]/div[3]/label[2]"));

        IWebElement UniversalCharger => driver.FindElement(By.XPath("#podVariant > div > div > div > div:nth-child(1) > div"));

        IWebElement Click22W => driver.FindElement(By.CssSelector("#podModel > div > div > div:nth-child(3) > div"));

        IWebElement Extendedwarranty => driver.FindElement(By.CssSelector("#optionalExtras > div > div > div > div:nth-child(3) > div > label > h4"));

        IWebElement NextButton => driver.FindElement(By.CssSelector("#next-button"));

        IWebElement FirstName => driver.FindElement(By.CssSelector("#firstName"));

        IWebElement LastName => driver.FindElement(By.CssSelector("#lastName"));

        IWebElement PhoneNumber => driver.FindElement(By.XPath("//*[@id='phoneNumber']"));

        IWebElement Email1 => driver.FindElement(By.CssSelector("#email"));

        IWebElement ByPhone => driver.FindElement(By.CssSelector("#contactConsentPhone"));

        IWebElement ByEmail2 => driver.FindElement(By.CssSelector("#contactConsentEmail"));

        IWebElement Email3 => driver.FindElement(By.XPath("//*[@id='marketingConsent']"));

        IWebElement Submit1 => driver.FindElement(By.CssSelector("#customerDetail > div > div.max-width-text.m-centre > div > div:nth-child(6) > div > button"));





        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }



        public void ClickOnSelectMake()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectMake);
            select.SelectByText("Land Rover");
        }


        public void ClickOnSelectModel()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectModel);
            select.SelectByText("Range Rover Sport P400e");
        }


        public void ClickNewButton()
        {
            Thread.Sleep(5000);
            NewButton.Click();
        }

        
        public void ClickUniversalCharger()
        {
            Thread.Sleep(5000);
            UniversalCharger.Click();
        }



        public void ClickClick22W()
        {
            Click22W.Click();
        }


        public void ClickExtendedWanrranty()
        {
            Extendedwarranty.Click();
        }


        public void ClickNextButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            NextButton.Click();
            NextButton.Click();
        }

        public void EnterFirstName(string Name)
        {
            FirstName.SendKeys(Name);
        }


        public void EnterLastName(string Name)
        {
            LastName.SendKeys(Name);
        }


        public void EnterPhoneNumber(string Number)
        {
            PhoneNumber.SendKeys(Number);
        }


        public void EnterEmail1(string Email1)
        {
           //Email1.SendKeys(Email1);
        }



        public void ClickByPhone()
        {
            ByPhone.Click();
        }


        public void ClickByEmail2()
        {
            ByEmail2.Click();
        }


        public void ClickEmail3()
        {
            Email3.Click();
        }


        public void ClickSubmit1()
        {
           Submit1.Click();
        }


    }
}
