using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // the delegate acts like a contract between the publisher and the subscriber.
        // the conventions is that the first parameter is the source of the event.
        // *
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // define an event based on the delegate.
        // *
        public event VideoEncodedEventHandler VideoEncoded;

        // what if we want to have more events?? We can do this.
        // now we can get rid of the above delegate and event.
        // *
        //public event EventHandler<VideoEventArgs> VideoEncoded;

        // We can use it with no arguments as well.
        //public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // The conventions is that event publisher methods should be protected, virtual and void.
        // The name of the method should start with "On" + the name of the event.
        protected virtual void OnVideoEncoded(Video video)
        {
            // check if there are subscribers
            if (VideoEncoded != null)
            {
                // raise the event
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
            }
        }
    }
}