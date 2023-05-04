using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using SMC.Cards;

namespace SMC.Mod
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class SphericalModificationCards : BaseUnityPlugin
    {
        private const string ModId = "xyz.spherical.modification.cards";
        private const string ModName = "Spherical Modification Cards";
        public const string Version = "0.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "SMC";

        public static SphericalModificationCards instance { get; private set; }
        
        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            Harmony harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            
            CustomCard.BuildCard<Switcheroo>();
        }
    }
}