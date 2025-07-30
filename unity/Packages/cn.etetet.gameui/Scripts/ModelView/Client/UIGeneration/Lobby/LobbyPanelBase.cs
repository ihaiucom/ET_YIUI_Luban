using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using Zeng.GameFrame.UIS;

namespace Games.UI.Lobby
{



    /// <summary>
    /// 由UI工具自动创建 请勿手动修改
    /// </summary>
    [ET.DisableAnalyzer]
    public abstract class LobbyPanelBase:UIPanel
    {
        [ShowInInspector]
        public const string PkgName = "Lobby";
        
        [ShowInInspector]
        public const string ResName = "LobbyPanel";
        
        [ShowInInspector] protected UITaskEventP0 u_EventEnterMap { get; private set; }
        [ShowInInspector] protected UITaskEventHandleP0 u_EventEnterMapHandle { get; private set; }

        
        protected sealed override void UIBind()
        {
            u_EventEnterMap = EventTable.FindEvent<UITaskEventP0>("u_EventEnterMap");
            u_EventEnterMapHandle = u_EventEnterMap.Add(OnEventEnterMapAction);

        }

        protected sealed override void UnUIBind()
        {
            u_EventEnterMap.Remove(u_EventEnterMapHandle);

        }
     
        protected virtual async UniTask OnEventEnterMapAction(){await UniTask.CompletedTask;}
   
   
    }
}