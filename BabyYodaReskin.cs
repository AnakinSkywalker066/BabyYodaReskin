using MelonLoader;
using BTD_Mod_Helper;
using BabyYodaReskin;
using Il2CppAssets.Scripts.Models;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Display;
using Il2CppNinjaKiwi.Common;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppNinjaKiwi.Players.Files.SaveStrategies;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Simulation.Objects;

[assembly: MelonInfo(typeof(Reskin), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BabyYodaReskin;

public class Reskin : BloonsTD6Mod
{
    

    public override void OnNewGameModel(GameModel gameModel)
    {
        
        foreach (var towerModel in gameModel.towers)
        {

            
             if (towerModel.baseId == "TimeMaster")
            {
                towerModel.ApplyDisplay<Yoda>();
                towerModel.displayScale = 7.5f;
            }
        }
    }

    
    public class Yoda : ModCustomDisplay
    {
        public override string AssetBundleName => "go";
        public override string PrefabName => "Grogu";
    }

    
}
