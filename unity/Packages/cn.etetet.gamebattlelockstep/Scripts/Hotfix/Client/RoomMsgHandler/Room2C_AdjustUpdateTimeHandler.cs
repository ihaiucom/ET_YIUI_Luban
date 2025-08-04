namespace ET.Client
{
    [MessageHandler(SceneType.LockStep)]
    public class Room2C_AdjustUpdateTimeHandler: MessageHandler<Scene, Room2C_AdjustUpdateTime>
    {
        protected override async ETTask Run(Scene root, Room2C_AdjustUpdateTime message)
        {
            Room room = root.GetComponent<Room>();
            // 计算出新的帧间隔, 和服务器的时间差越大，帧间隔越大，帧率越低
            int newInterval = (1000 + (message.DiffTime - LSConstValue.UpdateInterval)) * LSConstValue.UpdateInterval / 1000;

            if (newInterval < 40)
            {
                newInterval = 40;
            }

            if (newInterval > 66)
            {
                newInterval = 66;
            }
            // 重新设置帧间隔, newInterval越小，帧率越高
            room.FixedTimeCounter.ChangeInterval(newInterval, room.PredictionFrame);
            await ETTask.CompletedTask;
        }
    }
}