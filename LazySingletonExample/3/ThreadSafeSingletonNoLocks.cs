namespace LazySingletonExample._3
{
    public sealed class ThreadSafeSingletonNoLocks
    {
        public static ThreadSafeSingletonNoLocks Instance { get; } = new ThreadSafeSingletonNoLocks();

        private ThreadSafeSingletonNoLocks()
        {
        }
    }
}
