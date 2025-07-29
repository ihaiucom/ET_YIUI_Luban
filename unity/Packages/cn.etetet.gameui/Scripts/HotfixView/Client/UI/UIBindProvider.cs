using Zeng.GameFrame.UIS;

namespace UICodeGenerated
{
    /// <summary>
    /// 由UI工具自动创建 请勿手动修改
    /// 用法: UIBindHelper.InternalGameGetUIBindVoFunc = UICodeGenerated.UIBindProvider.Get;
    /// </summary>
    public static class UIBindProvider
    {
        public static UIBindVo[] Get()
        {
            var UIPanel     = typeof(UIPanel);
            var UIView      = typeof(UIView);
            var UIComponent = typeof(UIComponent);
            var list          = new UIBindVo[3];
            list[0] = new UIBindVo
            {
                PkgName     = Games.UI.Lobby.LobbyPanelBase.PkgName,
                ResName     = Games.UI.Lobby.LobbyPanelBase.ResName,
                CodeType    = UIPanel,
                BaseType    = typeof(Games.UI.Lobby.LobbyPanelBase),
                CreatorType = typeof(Games.UI.Lobby.LobbyPanel),
            };
            list[1] = new UIBindVo
            {
                PkgName     = Games.UI.Login.LoginPanelBase.PkgName,
                ResName     = Games.UI.Login.LoginPanelBase.ResName,
                CodeType    = UIPanel,
                BaseType    = typeof(Games.UI.Login.LoginPanelBase),
                CreatorType = typeof(Games.UI.Login.LoginPanel),
            };
            list[2] = new UIBindVo
            {
                PkgName     = Games.UI.Main.MainPanelBase.PkgName,
                ResName     = Games.UI.Main.MainPanelBase.ResName,
                CodeType    = UIPanel,
                BaseType    = typeof(Games.UI.Main.MainPanelBase),
                CreatorType = typeof(Games.UI.Main.MainPanel),
            };

            return list;
        }
    }
}