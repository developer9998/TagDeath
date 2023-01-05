using BepInEx;
using UnityEngine;

namespace TagDeath
{
    [BepInDependency("net.rusjj.gtlib.bananahook", "1.3.1")]
    [BepInPlugin("com.dev9998.gorillatag.tagdeath", "TagDeath", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        // This part calls the OnLocalTag method it's not anything special
        public void Start() => BananaHook.Events.OnLocalPlayerTag += OnLocalTag;

        public void OnEnable() => GorillaTagger.Instance?.offlineVRRig?.tagSound.PlayOneShot(GorillaTagger.Instance.offlineVRRig.clipToPlay[2], 0.2f);

        public void OnDisable() => GorillaTagger.Instance?.offlineVRRig?.tagSound.PlayOneShot(GorillaTagger.Instance.offlineVRRig.clipToPlay[0], 0.2f);

        private void OnLocalTag(object sender, BananaHook.PlayerTaggedPlayerArgs e)
        {
            // Whoops forgot to check if the mod was enabled
            if (e.victim.IsLocal && enabled) Application.Quit();
        }
    }
}
