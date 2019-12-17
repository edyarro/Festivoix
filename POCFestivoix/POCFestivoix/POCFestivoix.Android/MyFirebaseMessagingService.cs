using Android.App;
using Android.Content;
using Firebase.Messaging;

namespace POCFestivoix.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        /// <summary>
        /// MyFirebaseMessagingService
        /// </summary>
        public MyFirebaseMessagingService()
        {
        }

        /// <summary>
        /// OnMessageReceived
        /// </summary>
        /// <param name="p0"></param>
        public override void OnMessageReceived(RemoteMessage p0)
        {
            base.OnMessageReceived(p0);

            new NotificationHelper().CreateNotification(p0.GetNotification().Title, p0.GetNotification().Body);
        }
    }
}