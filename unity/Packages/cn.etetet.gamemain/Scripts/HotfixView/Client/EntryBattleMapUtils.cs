using System.Collections.Generic;

namespace ET.Client
{
    public static class EntryBattleMapUtils
    {

        public static async ETTask EnterRoomAsync(this Scene root, string sceneName, long sceneInstanceId)
        {
            await ETTask.CompletedTask;

            long playerId = IdGenerater.Instance.GenerateId();
            root.GetComponent<PlayerComponent>().MyId = playerId;
            
            root.RemoveComponent<Room>();

            Room room = root.AddComponentWithId<Room>(sceneInstanceId);
            room.OfflineMode = true;
            room.Name = sceneName;
            
            // 等待表现层订阅的事件完成
            await EventSystem.Instance.PublishAsync(root, new LSSceneChangeStart() {Room = room});
            
            List<LockStepUnitInfo> unitInfos = new List<LockStepUnitInfo>();
            LockStepUnitInfo unitInfo = LockStepUnitInfo.Create();
            unitInfos.Add(unitInfo);
            unitInfo.PlayerId = playerId;
            
            room.LSWorld = new LSWorld(SceneType.LockStepClient);
            long timeNow = TimeInfo.Instance.ServerNow();
            room.Init(unitInfos, timeNow);
            
            room.AddComponent<LSClientOfflineUpdater>();
            
            // 这个事件中可以订阅取消loading
            EventSystem.Instance.Publish(root, new LSSceneInitFinish());
        }

    }

}
