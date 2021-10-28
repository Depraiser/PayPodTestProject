using NUnit.Framework;
using PayPodOrderForm1.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PayPodOrderForm1.StepDefinition
{
    [Binding]
    public class PayPodInstallationFormSteps
    {
        PayPodPage payPodPage;

        public PayPodInstallationFormSteps()
        {
            payPodPage = new PayPodPage();
        }


        [Given(@"I Navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            payPodPage.NavigateToWebsite(url);
        }



        [Given(@"Click on select make")]
        public void GivenClickOnSelectMake()
        {
            payPodPage.ClickOnSelectMake();
        }



        [Given(@"User select Model")]
        public void GivenUserSelectModel()
        {
            payPodPage.ClickOnSelectModel();
        }



        [Given(@"I Click on New Button")]
        public void GivenIClickOnNewButton()
        {
            payPodPage.ClickNewButton();
        }


        
        [When(@"User select Universal Charger")]
        public void WhenUserSelectUniversalCharger()
        {
            Thread.Sleep(5000);
            payPodPage.ClickUniversalCharger();
        }


        [When(@"Click on KiloWatt")]
        public void WhenClickOnKiloWatt()
        {
            Thread.Sleep(5000);
            payPodPage.ClickOn22W();
        }



        [When(@"I select Extended warranty")]
        public void WhenISelectExtendedWarranty()
        {
            Thread.Sleep(3000);
            payPodPage.ClickExtendedWanrranty();
        }
        

        [When(@"I click on Next Button")]
        public void WhenIClickOnNextButton()
        {
            Thread.Sleep(3000);
            payPodPage.ClickNextButton();
        }


        [When(@"Enter my first Name ""(.*)""")]
        public void WhenEnterMyFirstName(string FirstName)
        {
            payPodPage.EnterFirstName(FirstName);
        }


        [When(@"I Enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string LastName)
        {
            payPodPage.EnterLastName(LastName);
        }


        [When(@"Enter Phone Number ""(.*)""")]
        public void WhenEnterPhoneNumber(string Number)
        {
            payPodPage.EnterPhoneNumber(Number);
        }


        [When(@"User Enter Email ""(.*)""")]
        public void WhenUserEnterEmail(string Email)
        {
            payPodPage.EnterEmail1(Email);
        }



        [When(@"Click on don't contact me by Phone")]
        public void WhenClickOnDonTContactMeByPhone()
        {
            Thread.Sleep(3000);
            payPodPage.ClickByPhone();
        }
        

        [When(@"Don't contact me by Email")]
        public void WhenDonTContactMeByEmail()
        {
            Thread.Sleep(3000);
            payPodPage.ClickByEmail2();
        }
        

        [When(@"User click I'd prefer not to receive updates")]
        public void WhenUserClickIDPreferNotToReceiveUpdates()
        {
            Thread.Sleep(3000);
            payPodPage.ClickByEmail2();
        }
        

        [When(@"I click on Submit button")]
        public void WhenIClickOnSubmitButton()
        {
            Thread.Sleep(3000);
            payPodPage.ClickSubmit1();
        }
        

        [Then(@"I should be able to Submit my details for installation")]
        public void ThenIShouldBeAbleToSubmitMyDetailsForInstallation()
        {
            Thread.Sleep(5000);
            Assert.That(payPodPage.IsReSubmitDisplayed);
        }

    }
}
