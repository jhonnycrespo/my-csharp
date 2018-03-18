namespace InterfacesAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();

            videoEncoder.RegisterNotificationChannel(new MailNotificationChannel());
            videoEncoder.RegisterNotificationChannel(new SmsNotificationChannel());

            videoEncoder.Encode(new Video());
        }
    }
}
