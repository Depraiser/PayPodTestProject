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

        IWebElement NewButton => driver.FindElement(By.XPath("//*[@class='radio radio--inline'][2]]"));

        IWebElement UniversalCharger => driver.FindElement(By.XPath("//*[text()='Universal Charger']"));

        IWebElement KiloWatt => driver.FindElement(By.XPath("//h4[text()='22kW']"));

        IWebElement Extendedwarranty => driver.FindElement(By.XPath("//*[@id='optionalExtras']/div/div/div/div[3]/div/label/h4"));

        IWebElement NextButton => driver.FindElement(By.XPath("//*[@id='next-button']"));

        IWebElement FirstName => driver.FindElement(By.CssSelector("#firstName"));

        IWebElement LastName => driver.FindElement(By.CssSelector("#lastName"));

        IWebElement PhoneNumber => driver.FindElement(By.XPath("//*[@id='phoneNumber']"));

        IWebElement Email1 => driver.FindElement(By.CssSelector("#email"));

        IWebElement ByPhone => driver.FindElement(By.CssSelector("#contactConsentPhone"));

        IWebElement ByEmail2 => driver.FindElement(By.CssSelector("#contactConsentEmail"));

        IWebElement Email3 => driver.FindElement(By.XPath("//*[@id='marketingConsent']"));

        IWebElement Submit1 => driver.FindElement(By.CssSelector("#customerDetail > div > div.max-width-text.m-centre > div > div:nth-child(6) > div > button"));

        IWebElement ReSubmit => driver.FindElement(By.XPath("//*[@id='customerDetail']/div/div[2]/div/div[6]/div/button"));



        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }



        public void ClickOnSelectMake()
        {
            Thread.Sleep(3000);
            SelectElement select = new SelectElement(SelectMake);
            select.SelectByText("Land Rover");
        }


        public void ClickOnSelectModel()
        {
            SelectElement select = new SelectElement(SelectModel);
            select.SelectByText("Range Rover Sport P400e");
        }


        public void ClickNewButton()
        {
           // Thread.Sleep(5000);
            //NewButton.Click();
        }

        
        public void ClickUniversalCharger()
        {
            UniversalCharger.Click();
        }



        public void ClickOn22W()
        {
            KiloWatt.Click();
        }


        public void ClickExtendedWanrranty()
        {
            Extendedwarranty.Click();
        }


        public void ClickNextButton()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            js.ExecuteScript("window.scrollBy(0,350)", "");
            
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


        public void EnterEmail1(string Name)
        {
           Email1.SendKeys(Name);
        }



        public void ClickByPhone()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,350)", "");
            
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


        public bool IsReSubmitDisplayed()
        {
            return ReSubmit.Displayed;
        }

    }
}
