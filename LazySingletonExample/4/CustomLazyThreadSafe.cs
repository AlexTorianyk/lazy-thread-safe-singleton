namespace LazySingletonExample._4
{
    public sealed class CustomLazyThreadSafe
    {
        private CustomLazyThreadSafe()
        {
        }

        public static CustomLazyThreadSafe Instance => Nested.Instance;

        private class Nested
        {
            internal static readonly CustomLazyThreadSafe Instance = new CustomLazyThreadSafe();
        }
    }
}
