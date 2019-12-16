using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;

namespace POCFestivoix.Droid
{
    public class NotificationHelper
    {
        /// <summary>
        /// CHANNEL_ID
        /// </summary>
        private const string CHANNEL_ID = "1000";

        /// <summary>
        /// context
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// manager
        /// </summary>
        private readonly NotificationManager manager;

        /// <summary>
        /// Constructor
        /// </summary>
        public NotificationHelper()
        {
            this.context = Application.Context;
            this.manager = NotificationManager.FromContext(this.context);
        }

        /// <summary>
        /// CreateNotification
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public void CreateNotification(string title, string message)
        {
            NotificationCompat.Builder builder = new NotificationCompat.Builder(this.context, CHANNEL_ID);

            builder.SetSmallIcon(Resource.Drawable.notification_template_icon_low_bg)
                 .SetContentTitle(title)
                 .SetContentText(message)
                 .SetPriority(NotificationCompat.PriorityDefault);

            Notification notif = builder.Build();

            this.manager.Notify(0, notif);
        }
    }
}