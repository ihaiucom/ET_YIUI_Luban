using System;
using Zeng.GameFrame.UIS;

using UnityEngine;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using ET;
using ET.Client;
using UnityEngine.UI;

namespace Games.UI.Login
{
    /// <summary>
    /// Author  ZF
    /// Date    2025.7.29
    /// </summary>
    public sealed partial class LoginPanel:LoginPanelBase
    {
    
        #region 生命周期
        
        protected override void Initialize()
        {
            Debug.Log($"LoginPanel Initialize");
        }

        protected override void OnEnable()
        {
            Debug.Log($"LoginPanel OnEnable");
        }

        protected override void OnDisable()
        {
            Debug.Log($"LoginPanel OnDisable");
        }

        protected override void OnDestroy()
        {
            Debug.Log($"LoginPanel OnDestroy");
        }

        protected override async UniTask<bool> OnOpen()
        {
            await UniTask.CompletedTask;
            Debug.Log($"LoginPanel OnOpen");
            return true;
        }

        protected override async UniTask<bool> OnOpen(ParamVo param)
        {
            return await base.OnOpen(param);
        }
        
        #endregion

        #region Event开始


       
        protected override void OnEventLoginAction()
        {
            GlobalComponent globalComponent = GameClient.Instance.Root.GetComponent<GlobalComponent>();
            LoginHelper.Login(
                GameClient.Instance.Root, 
                globalComponent.GlobalConfig.Address,
                this.u_ComAccount.text, 
                this.u_ComPassword.text).NoContext();
        }
        
        protected override void OnEventClickTestBtnAction()
        {
            Debug.Log($"OnEventClickTestBtnAction ~~~~~~~3");
        }
         #endregion Event结束

    }
}