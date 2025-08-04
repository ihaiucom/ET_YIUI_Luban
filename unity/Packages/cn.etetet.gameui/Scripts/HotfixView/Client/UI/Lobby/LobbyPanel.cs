using System;
using Zeng.GameFrame.UIS;

using UnityEngine;
using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using ET;
using ET.Client;

namespace Games.UI.Lobby
{
    /// <summary>
    /// Author  ZF
    /// Date    2025.7.29
    /// </summary>
    public sealed partial class LobbyPanel:LobbyPanelBase
    {
    
        #region 生命周期
        
        protected override void Initialize()
        {
            Debug.Log($"LobbyPanel Initialize");
        }

        protected override void OnEnable()
        {
            Debug.Log($"LobbyPanel OnEnable");
        }

        protected override void OnDisable()
        {
            Debug.Log($"LobbyPanel OnDisable");
        }

        protected override void OnDestroy()
        {
            Debug.Log($"LobbyPanel OnDestroy");
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
        protected override async UniTask OnEventEnterMapAction()
        {
            Scene root = GameClient.Instance.Root;
            await EnterMapHelper.Match(root.Fiber());
        }
        private void OnEventReplayAction2()
        {
            string replayPath = "";
            Scene root = GameClient.Instance.Root;
            byte[] bytes = File.ReadAllBytes(replayPath);
            
            Replay replay = MemoryPackHelper.Deserialize(typeof (Replay), bytes, 0, bytes.Length) as Replay;
            Log.Debug($"start replay: {replay.Snapshots.Count} {replay.FrameInputs.Count} {replay.UnitInfos.Count}");
            LSSceneChangeHelper.SceneChangeToReplay(root, replay).NoContext();
        }
         #endregion Event结束

    }
}