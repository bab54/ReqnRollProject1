using Microsoft.Playwright;
using NUnit.Framework;
using ReqnrollProject1.Pages;
using System.Threading.Tasks;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class HomePageStepDefinitions(Hooks hooks, TesteryHomePage testeryHomePage)
    {
        private readonly IPage _page = hooks.Page;
        private readonly TesteryHomePage _testeryHomePage = testeryHomePage;

        [Given("I navigate to testery.com")]
        public async Task GivenNavigateToAsync()
        {
            await _testeryHomePage.GoTo();
        }
        [When("I click on cookie button")]
        public async Task WhenIClickOnCookieButton()
        {
            await _testeryHomePage.ClickCookieButton();
        }



        [When("I click on contact link")]
        public async Task WhenIClickonContactLinkAsync()
        {
            await _testeryHomePage.ContactLink.ClickAsync();
           
        }

[Then("I see the testery links")]
        //public async Task ThenISeeTheLinksAsync()
        //{
        //    bool linkIsThere = await _testeryHomePage.PlatformLink.IsVisibleAsync();
        //    bool linkTwoIsThere = await _testeryHomePage.ContactLink.IsVisibleAsync();
        //    bool getStartedButton = await _testeryHomePage.GetStartedButton.IsVisibleAsync();
        //    Assert.IsTrue(linkIsThere, "Expected the link to be present, but it was not.");
        //    Assert.IsTrue(linkTwoIsThere, "Expected second link to be present but it was not.");
        //    Assert.IsTrue(getStartedButton, "Expected 'Get Started' button to be visible but it was not.");
        //    //linkIsThere.Should.BeTrue();
        //    //linkTwoIsThere.Should().BeTrue();
        //    //getStartedButton.Should().BeTrue();
        //}

        [Then("I see the contact page")]
        public async Task ThenISeeTheContactPageAsync()
        {
            string url = _page.Url;
           // url.Should().Be("https://testery.com/contact");
            Assert.That(url, Is.EqualTo("https://testery.com/contact"), "URL mismatch for contact page.");
        }
    }
}