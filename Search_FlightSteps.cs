using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace InfaseME.features.support
{
    [Binding]
    public class Search_FlightSteps
    {
        [Given(@"open ""(.*)"" url")]
        public static void openurl(string URL)
        {
            Driver.visit(URL);
        }

        [Given(@"I select ""(.*)""")]
        public void GivenISelect(string TripType)
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath($"//strong[text()='{TripType}']"));
            el.Click();
        }

        [When(@"I select (From|To) ""(.*)"" airpot")]
        public void GivenISelectAirpot(string destination, string airport)
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath($"//STRONG[text()='{destination}']/../../..//INPUT"));
            el.Clear();
            el.SendKeys(airport);
        }

        [Given(@"I choose (Depart date|Return date) ""(.*)""")]
        public void GivenIChooseDate(string dateType, string date)
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath($"//INPUT[@title='{dateType}']"));
            el.Clear();
            el.SendKeys(date);
        }

        [Given(@"I select (.*) from ""(.*)"" dropdown menu")]
        public void GivenISelectFromDropdownMenu(int option, string dropdown)
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath($"//label[@title='{dropdown}']/../../..//SELECT"));
            el.Click();
        }

        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string button)
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath($"(//input[@value='{button}'])"));
            el.Click();
        }

        [When(@"I book cheapes flight")]
        public void WhenIBookCheapesFlight()
        {
            IWebElement el = Driver.Instance.FindElement(By.XPath("(//table/tbody/tr/td/button[contains(text(),'Book')])[1]"));
            el.Click();
        }


        [Given(@"I order flights by ""(.*)""")]
        public void ThenIOrderFlightsBy(string OrderBy)
        {
            //Dictionary<string,string> ordering = new Dictionary<string,string>(){
            //    { "ascending","current sortAes"},
            //    { "descending","current sortDes"}
            //};
            IWebElement el = Driver.Instance.FindElement(By.XPath($"//a[text()='{OrderBy}']"));
            el.Click();
        }

        [Then(@"I should see ""(.*)""")]
        public void ThenIShouldSee(string text)
        {
            string val = Driver.Instance.FindElement(By.XPath($"//*[contains(text(),'{text}')]")).Text;
            Assert.AreEqual(val, text);
        }

        [Then(@"""(.*)"" should be visible")]
        public void ThenShouldBeVisible(string field)
        {
            Assert.IsTrue(IsElementVisible(field));
        }

        private bool IsElementVisible(string text)
        {
            try
            {
                string val = Driver.Instance.FindElement(By.XPath($"//*[contains(text(),'{text}')]")).Text;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
