using System;
using Zeng.GameFrame.UIS;

using UnityEngine;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Games.UI.Lobby
{
    /// <summary>
    /// Author  ZF
    /// Date    2025.7.29
    /// </summary>
    public sealed partial class LobbyPanel:LobbyPanelBase
    {
    
        #region 生命周期
        
        protected override void OnUIInit()
        {
            Debug.Log($"LobbyPanel OnUIInit");
        }

        protected override void OnUIEnable()
        {
            Debug.Log($"LobbyPanel OnUIEnable");
        }

        protected override void OnUIDisable()
        {
            Debug.Log($"LobbyPanel OnUIDisable");
        }

        protected override void OnUIDestroy()
        {
            Debug.Log($"LobbyPanel OnUIDestroy");
        }

        protected override async UniTask<bool> OnOpen()
        {
            await UniTask.CompletedTask;
            Debug.Log($"LobbyPanel OnOpen");
            return true;
        }

        protected override async UniTask<bool> OnOpen(ParamVo param)
        {
            return await base.OnOpen(param);
        }
        
        #endregion

        #region Event开始


       
        protected override void OnEventEnterMapAction()
        {
            
        }
         #endregion Event结束

    }
}