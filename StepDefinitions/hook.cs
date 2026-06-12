using Microsoft.Playwright;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        public IPage Page { get; private set; } = null!;

        [BeforeScenario]
        public async Task SetupTestAsync()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
            IBrowserContext context = await browser.NewContextAsync();

            Page = await context.NewPageAsync();
        }
    }
}

//using Microsoft.Playwright;
//using System.Text.RegularExpressions;

//namespace ReqnrollProject1.StepDefinitions
//{
//    [Binding]
//    public class Hooks(ScenarioContext scenarioContext)
//    {
//        public IPage Page { get; private set; } = null!;
//        private readonly ScenarioContext _scenarioContext = scenarioContext;

//        [BeforeScenario]
//        public async Task SetupTestAsync()
//        {
//            IPlaywright playwright = await Playwright.CreateAsync();
//            IBrowser browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
//            IBrowserContext context = await browser.NewContextAsync();

//            Page = await context.NewPageAsync();
//        }

//        [AfterScenario]
//        public async Task TakeScreenshotAsync()
//        {
//            string name = Regex.Replace(_scenarioContext.ScenarioInfo.Title, @"\s+", "");
//            await Page.ScreenshotAsync(new() { Path = $"./screenshots/{name}.png" });
//        }
//    }
//}