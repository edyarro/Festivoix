using Android.App;
using Android.Content;
using Android.Support.V4.App;

namespace POCFestivoix.Droid
{
    public class NotificationHelper
    {
        /// <summary>
        /// context
        /// </summary>
        private Context context;

        /// <summary>
        /// manager
        /// </summary>
        private NotificationManager manager;

        /// <summary>
        /// builder
        /// </summary>
        private NotificationCompat.Builder builder;

        /// <summary>
        /// Constructor
        /// </summary>
        public NotificationHelper()
        {
            this.context = Application.Context;
        }

        /// <summary>
        /// CreateNotification
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public void CreateNotification(string title, string message)
        {
        }
    }
}