using System;

namespace EventsAndDelegates
{
    // https://www.youtube.com/watch?v=jQgwEsJISy0
    // Pros
    // Building Loosely Coupled Applications: Easy to extend

    // this class is reponsible for sending an email once the video is encoded.
    public class MailService
    {
        // we need a method that satisfies the delegate on VideoEncoder
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "free bird.mp3"};
            // publisher
            var videoEncoder = new VideoEncoder();
            // subscriber
            var mailService = new MailService();
            var messageService = new MessageService();

            // we need to subscribe to the event.
            // register a handler for the event.
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
