using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.Forms;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestCloudDemo.UITests
{
    [TestFixture (Platform.Android)]
    [TestFixture (Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests (Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest ()
        {
            app = AppInitializer.StartApp (platform);
        }

        [Test]
        public void AppLaunches ()
        {
            app.Screenshot ("First screen.");
        }

        [Test]
        public void Press_Good_Button_And_Pass_Hooray ()
        {
            // Arrange
            // Nothing to arrange for this test

            // Act
            app.Tap (e => e.Marked ("SucceedButton"));
            app.Screenshot ("Green button tapped");

            // Assert
            Assert.AreEqual ("Hooray!", app.Query (e => e.Marked ("ResultLabel")).First ().Text);
        }

        [Test]
        public void Press_Bad_Button_And_Fail_Boo ()
        {
            // Arrange
            // Nothing to arrange for this test

            // Act
            app.Tap (e => e.Marked ("FailButton"));
            app.Screenshot ("Red button tapped");

            Assert.AreEqual ("Whoops, that is embarrassing...", app.Query (e => e.Marked ("ResultLabel")).First ().Text);
        }

    }
}
