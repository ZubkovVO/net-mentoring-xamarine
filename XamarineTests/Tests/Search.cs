using NUnit.Framework;
using Xamarin.UITest;

namespace XamarineTests.Tests
{
    [TestFixture(Platform.Android)]
    class Search
    {
        IApp app;
        Platform platform;
        public string _path = @"D:\Logs\test.apk";

        public Search(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform, _path);
        }

        [Test]
        public void SearchMobilePhone()
        {
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("menu_search"));
            app.EnterText("Samsung");
            app.ScrollDown();
            app.ClearText();
            app.EnterText("Nexus");
            app.DismissKeyboard();
            app.ScrollDown();
            app.ScrollDown();
            app.ScrollDown();
        }
    }
}
