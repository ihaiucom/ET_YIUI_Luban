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
        
        [ShowInInspector] protected UIEventP0 u_EventEnterMap { get; private set; }
        [ShowInInspector] protected UIEventHandleP0 u_EventEnterMapHandle { get; private set; }

        
        protected sealed override void UIBind()
        {
            u_EventEnterMap = EventTable.FindEvent<UIEventP0>("u_EventEnterMap");
            u_EventEnterMapHandle = u_EventEnterMap.Add(OnEventEnterMapAction);

        }

        protected sealed override void UnUIBind()
        {
            u_EventEnterMap.Remove(u_EventEnterMapHandle);

        }
     
        protected virtual void OnEventEnterMapAction(){}
   
   
    }
}