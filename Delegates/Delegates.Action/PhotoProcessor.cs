using System;

namespace Delegates.Action
{
    public class PhotoProcessor
    {
        // instead of creating a custom delegate, we can use one of the existing
        // delegates that comes in the .NET framework.
        // In .Net we have two delegates that are generic: Action and Func
        // Action is a delegate that returns void and comes in two forms: one generic and one non-generic
        // The generic form can receive up to 16 parameters.
        // Funct is a generic delegate that returns a value. Can receive up to 6 parameters.
        // Func<in T, out TResult> : TResult is the return value of the delegate.
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
