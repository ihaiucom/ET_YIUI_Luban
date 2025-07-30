namespace ET.Client
{
    public static class TestStaticClassReload
    {
        public const int TestVal = 1;
        public static void Test()
        {
            Log.Info($"TestStaticClassReload.Test ~~~~~~3 , TestVal={TestVal}");
        }
    }
}
