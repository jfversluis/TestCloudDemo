using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace TestCloudDemo.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init ();

            Forms.ViewInitialized += (object sender, ViewInitializedEventArgs e) => {
                if (!string.IsNullOrWhiteSpace (e.View.AutomationId)) {
                    e.NativeView.AccessibilityIdentifier = e.View.AutomationId;
                }
            };

            // Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start ();
#endif

            LoadApplication (new App ());

            return base.FinishedLaunching (app, options);
        }
    }
}
