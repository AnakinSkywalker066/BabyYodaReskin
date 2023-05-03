using MelonLoader;
using BTD_Mod_Helper;
using BabyYodaReskin;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity;
using Il2CppNinjaKiwi.LiNK.DotNetZip.Zlib;
using MelonLoader.NativeUtils;
using static Il2CppSystem.Globalization.HebrewNumber;
using static MelonLoader.MelonLaunchOptions;
using UnityEngine.InputSystem;

[assembly: MelonInfo(typeof(Reskin), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BabyYodaReskin;

public class Reskin : BloonsTD6Mod
{
    
    public override void OnNewGameModel(GameModel gameModel)
    {
        
        foreach (var towerModel in gameModel.towers)
        {
            
            towerModel.displayScale = 100f;
            
            if (towerModel.baseId == "TimeMaster")
            {
                towerModel.ApplyDisplay<Yoda>();
            }
        }
    }
    public class Yoda : ModCustomDisplay
    {
        public override string AssetBundleName => "go";
        public override string PrefabName => "yoda";



    }
}
