using System;
using Zeng.GameFrame.UIS;

using UnityEngine;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Games.UI.Main
{
    /// <summary>
    /// Author  ZF
    /// Date    2025.7.29
    /// </summary>
    public sealed partial class MainPanel:MainPanelBase
    {
    
        #region 生命周期
        
        protected override void Initialize()
        {
            Debug.Log($"MainPanel Initialize");
        }

        protected override void OnEnable()
        {
            Debug.Log($"MainPanel OnEnable");
        }

        protected override void OnDisable()
        {
            Debug.Log($"MainPanel OnDisable");
        }

        protected override void OnDestroy()
        {
            Debug.Log($"MainPanel OnDestroy");
        }

        protected override async UniTask<bool> OnOpen()
        {
            await UniTask.CompletedTask;
            Debug.Log($"MainPanel OnOpen");
            return true;
        }

        protected override async UniTask<bool> OnOpen(ParamVo param)
        {
            return await base.OnOpen(param);
        }
        
        #endregion

        #region Event开始


        #endregion Event结束

    }
}