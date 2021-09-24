namespace LazySingletonExample._2
{
    public class SimpleThreadSafetySingleton
    {
        private static SimpleThreadSafetySingleton _instance = null;
        private static readonly object _lock = new object();

        SimpleThreadSafetySingleton()
        {
        }

        public static SimpleThreadSafetySingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafetySingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
