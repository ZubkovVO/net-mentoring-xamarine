using NUnit.Framework;
using Xamarin.UITest;

namespace XamarineTests
{
    [TestFixture(Platform.Android)]
    public class ControlsAndNavigation
    {
        IApp app;
        Platform platform;
        public string _path = @"D:\Logs\test.apk";

        public ControlsAndNavigation(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform, _path);
        }

        [Test]
        public void GetToTheMainMenu()
        {
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("backView"));
            app.SwipeRightToLeft();
            app.Tap(c => c.Id("nextView"));
            app.SwipeRightToLeft();
            app.Tap(c => c.Id("nextView"));
            app.ScrollDown();
            app.ScrollUp();
        }

    }
}
