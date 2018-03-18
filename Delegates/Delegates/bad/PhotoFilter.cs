// A delegate is a reference or pointer to a function

using System;

namespace Delegates.bad
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("resize photo");
        }
    }
}
