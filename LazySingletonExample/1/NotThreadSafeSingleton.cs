﻿namespace LazySingletonExample._1
{
    public sealed class NotThreadSafeSingleton
    {
        private static NotThreadSafeSingleton _instance = null;

        private NotThreadSafeSingleton()
        {
        }

        public static NotThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotThreadSafeSingleton();
                }
                return _instance;
            }
        }
    }
}
