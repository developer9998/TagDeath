using BepInEx;
using UnityEngine;

namespace TagDeath
{
    [BepInDependency("net.rusjj.gtlib.bananahook", "1.3.1")]
    [BepInPlugin("com.dev9998.gorillatag.tagdeath", "TagDeath", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public void Start() => BananaHook.Events.OnLocalPlayerTag += OnLocalTag;

        public void OnEnable() => GorillaTagger.Instance?.offlineVRRig?.tagSound.PlayOneShot(GorillaTagger.Instance.offlineVRRig.clipToPlay[2], 0.2f);

        public void OnDisable() => GorillaTagger.Instance?.offlineVRRig?.tagSound.PlayOneShot(GorillaTagger.Instance.offlineVRRig.clipToPlay[0], 0.2f);

        private void OnLocalTag(object sender, BananaHook.PlayerTaggedPlayerArgs e)
        {
            // haha L
            if (e.victim.IsLocal) Application.Quit();
        }
    }
}
