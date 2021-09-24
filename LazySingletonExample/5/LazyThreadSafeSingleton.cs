using System;

namespace LazySingletonExample._5
{
    public sealed class LazyThreadSafeSingleton
    {
        private static readonly Lazy<LazyThreadSafeSingleton> _lazy =
            new Lazy<LazyThreadSafeSingleton>(() => new LazyThreadSafeSingleton());

        public static LazyThreadSafeSingleton Instance => _lazy.Value;

        private LazyThreadSafeSingleton()
        {
        }
    }
}
