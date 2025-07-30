using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using Zeng.GameFrame.UIS;

namespace Games.UI.Login
{



    /// <summary>
    /// 由UI工具自动创建 请勿手动修改
    /// </summary>
    [ET.DisableAnalyzer]
    public abstract class LoginPanelBase:UIPanel
    {
        [ShowInInspector]
        public const string PkgName = "Login";
        
        [ShowInInspector]
        public const string ResName = "LoginPanel";
        
        [ShowInInspector] public UnityEngine.UI.InputField u_ComAccount { get; private set; }
        [ShowInInspector] public UnityEngine.UI.InputField u_ComPassword { get; private set; }
        [ShowInInspector] protected UIEventP0 u_EventLogin { get; private set; }
        [ShowInInspector] protected UIEventHandleP0 u_EventLoginHandle { get; private set; }
        [ShowInInspector] protected UIEventP0 u_EventClickTestBtn { get; private set; }
        [ShowInInspector] protected UIEventHandleP0 u_EventClickTestBtnHandle { get; private set; }

        
        protected sealed override void UIBind()
        {
            u_ComAccount = ComponentTable.FindComponent<UnityEngine.UI.InputField>("u_ComAccount");
            u_ComPassword = ComponentTable.FindComponent<UnityEngine.UI.InputField>("u_ComPassword");
            u_EventLogin = EventTable.FindEvent<UIEventP0>("u_EventLogin");
            u_EventLoginHandle = u_EventLogin.Add(OnEventLoginAction);
            u_EventClickTestBtn = EventTable.FindEvent<UIEventP0>("u_EventClickTestBtn");
            u_EventClickTestBtnHandle = u_EventClickTestBtn.Add(OnEventClickTestBtnAction);

        }

        protected sealed override void UnUIBind()
        {
            u_EventLogin.Remove(u_EventLoginHandle);
            u_EventClickTestBtn.Remove(u_EventClickTestBtnHandle);

        }
     
        protected virtual void OnEventLoginAction(){}
        protected virtual void OnEventClickTestBtnAction(){}
   
   
    }
}