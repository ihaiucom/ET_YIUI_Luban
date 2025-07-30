using Games.UI.Main;
using Zeng.GameFrame.UIS;

namespace ET.Client
{
    [Event(SceneType.Current)]
    public class SceneChangeFinishEvent_CreateUIHelp : AEvent<Scene, SceneChangeFinish>
    {
        protected override async ETTask Run(Scene scene, SceneChangeFinish args)
        {
            await UIManager.I.OpenPanelAsync<MainPanel>();
        }
    }
}