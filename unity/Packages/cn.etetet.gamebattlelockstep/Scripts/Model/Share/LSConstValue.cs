namespace ET
{
    public static class LSConstValue
    {
        public const int MatchCount = 1;
        public const int UpdateInterval = 50;
        public const int FrameCountPerSecond = 1000 / UpdateInterval; // 20
        public const int SaveLSWorldFrameCount = 60 * FrameCountPerSecond; // 1200
        
        public const string ExcelPackagePath = "./Packages/cn.etetet.excel";
    }
}