using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ObjCRuntime;
using Plugin.FirebasePushNotification;
using UIKit;

namespace POCFestivoix.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            FirebasePushNotificationManager.Initialize(options);

            return base.FinishedLaunching(app, options);
        }

        public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
        {
            FirebasePushNotificationManager.DidRegisterRemoteNotifications(deviceToken);
        }

        /// <summary>
        /// FailedToRegisterForRemoteNotifications
        /// </summary>
        /// <param name="application"></param>
        /// <param name="error"></param>
        public override void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
        {
            base.FailedToRegisterForRemoteNotifications(application, error);
            FirebasePushNotificationManager.RemoteNotificationRegistrationFailed(error);
        }

        /// <summary>
        /// DidFailToContinueUserActivitiy
        /// </summary>
        /// <param name="application"></param>
        /// <param name="userActivityType"></param>
        /// <param name="error"></param>
        public override void DidFailToContinueUserActivitiy(UIApplication application, string userActivityType, NSError error)
        {
            base.DidFailToContinueUserActivitiy(application, userActivityType, error);
        }

        public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
        {
            FirebasePushNotificationManager.DidReceiveMessage(userInfo);
        }

        public override void OnActivated(UIApplication uiApplication)
        {
           // FirebasePushNotificationManager.Connect();
            base.OnActivated(uiApplication);
        }

        public override void DidEnterBackground(UIApplication uiApplication)
        {
          //  FirebasePushNotificationManager.DisConnect();
        }
    }
}
