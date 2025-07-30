using Games.UI.Lobby;
using Zeng.GameFrame.UIS;

namespace ET.Client
{
	[Event(SceneType.StateSync)]
	public class LoginFinish_CreateLobbyUI: AEvent<Scene, LoginFinish>
	{
		protected override async ETTask Run(Scene scene, LoginFinish args)
		{
			await UIManager.I.OpenPanelAsync<LobbyPanel>();
		}
	}
}