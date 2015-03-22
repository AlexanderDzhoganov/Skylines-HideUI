﻿using ICities;
using UnityEngine;

namespace HideUI
{

    public class Mod : IUserMod
    {

        public string Name
        {
            get { return "HideUI"; }
        }

        public string Description
        {
            get { return "Toggle the game's UI on/ off"; }
        }

    }

    public class ModLoad : LoadingExtensionBase
    {

        private HideUI hideUI;

        public override void OnLevelLoaded(LoadMode mode)
        {
            var cameraController = GameObject.FindObjectOfType<CameraController>();
            hideUI = cameraController.gameObject.AddComponent<HideUI>();
        }

        public override void OnLevelUnloading()
        {
            GameObject.Destroy(hideUI);
        }
    }

}
