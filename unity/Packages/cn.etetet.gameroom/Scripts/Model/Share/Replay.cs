using System.Collections.Generic;
using MemoryPack;

namespace ET
{
    [MemoryPackable]
    public partial class Replay: Object
    {
        // 玩家信息列表
        [MemoryPackOrder(1)]
        public List<LockStepUnitInfo> UnitInfos;
        
        // 帧输入消息
        [MemoryPackOrder(2)]
        public List<OneFrameInputs> FrameInputs = new();
        
        // 帧场景数据快照
        [MemoryPackOrder(3)]
        public List<byte[]> Snapshots = new();
    }
}