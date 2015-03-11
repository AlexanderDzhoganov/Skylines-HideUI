using ICities;
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

        public override void OnLevelLoaded(LoadMode mode)
        {
            var gameObject = new GameObject();
            gameObject.AddComponent<HideUI>();
        }

    }

}
