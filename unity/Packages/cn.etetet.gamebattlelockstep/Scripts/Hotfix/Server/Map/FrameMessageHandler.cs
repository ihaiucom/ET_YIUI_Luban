using System;
using System.Collections.Generic;

namespace ET.Server
{
    [MessageHandler(SceneType.RoomRoot)]
    public class FrameMessageHandler: MessageHandler<Scene, FrameMessage>
    {
        protected override async ETTask Run(Scene root, FrameMessage message)
        {
            using FrameMessage _ = message;  // 让消息回到池中
            
            Room room = root.GetComponent<Room>();
            FrameBuffer frameBuffer = room.FrameBuffer;
            
            // 每隔1秒，发送一次同步时间消息
            if (message.Frame % (1000 / LSConstValue.UpdateInterval) == 0)
            {
                long nowFrameTime = room.FixedTimeCounter.FrameTime(message.Frame);
                int diffTime = (int)(nowFrameTime - TimeInfo.Instance.ServerFrameTime());

                Room2C_AdjustUpdateTime room2CAdjustUpdateTime = Room2C_AdjustUpdateTime.Create();
                room2CAdjustUpdateTime.DiffTime = diffTime;
                room.Root().GetComponent<MessageLocationSenderComponent>().Get(LocationType.GateSession).Send(message.PlayerId, room2CAdjustUpdateTime);
            }

            if (message.Frame < room.AuthorityFrame)  // 小于AuthorityFrame，丢弃。已经执行过的确认帧，不需要再执行
            {
                Log.Warning($"FrameMessage < AuthorityFrame discard: {message}");
                return;
            }

            if (message.Frame > room.AuthorityFrame + 10)  // 大于AuthorityFrame + 10，丢弃
            {
                Log.Warning($"FrameMessage > AuthorityFrame + 10 discard: {message}");
                return;
            }
            
            // 保存到对应帧、对应玩家的输入消息
            OneFrameInputs oneFrameInputs = frameBuffer.FrameInputs(message.Frame);
            if (oneFrameInputs == null)
            {
                Log.Error($"FrameMessageHandler get frame is null: {message.Frame}, max frame: {frameBuffer.MaxFrame}");
                return;
            }
            oneFrameInputs.Inputs[message.PlayerId] = message.Input;

            await ETTask.CompletedTask;
        }
    }
}