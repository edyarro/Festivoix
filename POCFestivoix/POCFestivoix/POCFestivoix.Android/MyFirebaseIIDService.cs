
using System;
using Android.App;
using Firebase.Iid;

namespace POCFestivoix.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        /// <summary>
        /// TAG
        /// </summary>
        private const string TAG = "MyFirebaseIIDService";

        /// <summary>
        /// OnTokenRefresh
        /// </summary>
        public override void OnTokenRefresh()
        {
            string refreshedToken = FirebaseInstanceId.Instance.Token;

            this.SendRegistrationToServer(refreshedToken);
        }

        /// <summary>
        /// SendRegistrationToServer
        /// </summary>
        /// <param name="refreshedToken"></param>
        private void SendRegistrationToServer(string refreshedToken)
        {
        }
    }
}