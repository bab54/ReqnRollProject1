using Microsoft.Playwright;
using ReqnrollProject1.StepDefinitions;
using static System.Net.Mime.MediaTypeNames;

namespace ReqnrollProject1.Pages
{
    public class TesteryHomePage(Hooks hooks)
    {
        private readonly IPage _page = hooks.Page;

        public ILocator PlatformLink => _page.Locator("a.nav-link[href='/platform']");
        public ILocator ContactLink => _page.Locator("a.nav-link[href='/contact']");
        public ILocator GetStartedButton => _page.GetByRole(AriaRole.Button, new() { Name = "Get Started" }).First;

        //public ILocator CookieButton => _page.GetByRole('button', { name: 'Accept' });
    public ILocator CookieButton => _page.Locator("//*[@id=\"termly-code-snippet-support\"]/div/div/div/div/div[2]/button[2]");

public async Task GoTo()
        {
            await _page.GotoAsync("https://www.testery.com");
        }

       public async Task ClickContactButton()
        {
            await ContactLink.ClickAsync();
        }



        public async Task ClickCookieButton()
        {
            await CookieButton.ClickAsync();
        }

    }
}