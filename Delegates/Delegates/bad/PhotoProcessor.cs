namespace Delegates.bad
{
    // This code is not extensible. What if someone wants to add a new filter
    // that we haven't define. Then he was to create a new filter, recompile and
    // redeploy the code. Using delegates we can make this code extensible, so that
    // anybody can add their own filters. Interfaces can solve this problem too.
    // Here wi'll see how to use delegates to achieve this.

    public class PhotoProcessor
    {
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();

            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
