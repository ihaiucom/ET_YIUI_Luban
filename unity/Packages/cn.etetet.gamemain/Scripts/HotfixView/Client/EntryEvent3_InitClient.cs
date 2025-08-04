using System;
using System.Collections.Generic;
using System.IO;
using I2.Loc;
using Zeng.GameFrame.UIS;

namespace ET.Client
{
    [Event(SceneType.LockStep)]
    public class EntryEvent3_InitClient: AEvent<Scene, EntryEvent3>
    {
        protected override async ETTask Run(Scene root, EntryEvent3 args)
        {
            World.Instance.AddSingleton<LSEntitySystemSingleton>();
            
            root.AddComponent<GlobalComponent>();
            root.AddComponent<UIGlobalComponent>();
            root.AddComponent<UIComponent>();
            root.AddComponent<ResourcesLoaderComponent>();
            root.AddComponent<PlayerComponent>();
            root.AddComponent<CurrentScenesComponent>();
            
            World.Instance.AddSingleton<GameClient, Scene>(root);
            await InitUIAsync();
            
            // await EventSystem.Instance.PublishAsync(root, new AppStartInitFinish());
            
            
            await EntryBattleMapUtils.EnterRoomAsync(root, "Map1", 100);
        }
        
        
        private async ETTask InitUIAsync()
        {
            SingletonMgr.Initialize();
            UILoadProxyYooAsset.I.Init(null);
                
            UIBindHelper.InternalGameGetUIBindVoFunc = UICodeGenerated.UIBindProvider.Get;
                
                
            await MgrCenter.I.Register(SchedulerMgr.I);
            await MgrCenter.I.Register(AsyncLockMgr.I);
            await MgrCenter.I.Register(I2LocalizeMgr.I);
            await MgrCenter.I.Register(CountDownMgr.I);
            await MgrCenter.I.Register(UIManager.I);
                
            // UIManager.I.OpenPanel<LoginPanel>();
            // UIManager.I.OpenPanel<HomePanel>();
            // UIManager.I.OpenPanel<RoleSelectPanel>();
            
        }
    }
}