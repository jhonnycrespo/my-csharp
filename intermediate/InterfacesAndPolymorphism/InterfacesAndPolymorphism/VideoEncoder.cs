using System.Collections.Generic;

namespace InterfacesAndPolymorphism
{
    internal class VideoEncoder
    {
        private readonly IList<INotificationChannel> notificationChannels;

        public VideoEncoder()
        {
            notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var notificationChannel in notificationChannels)
            {
                notificationChannel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            notificationChannels.Add(channel);
        }
    }
}
