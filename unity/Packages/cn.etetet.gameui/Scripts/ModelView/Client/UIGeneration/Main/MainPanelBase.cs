using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using Zeng.GameFrame.UIS;

namespace Games.UI.Main
{



    /// <summary>
    /// 由UI工具自动创建 请勿手动修改
    /// </summary>
    [ET.DisableAnalyzer]
    public abstract class MainPanelBase:UIPanel
    {
        [ShowInInspector]
        public const string PkgName = "Main";
        
        [ShowInInspector]
        public const string ResName = "MainPanel";
        

        
        protected sealed override void UIBind()
        {

        }

        protected sealed override void UnUIBind()
        {

        }
     
   
   
    }
}