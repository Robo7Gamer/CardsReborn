using System;
using BepInEx;
using HarmonyLib;
using UnboundLib;
using UnboundLib.Cards;
using CardsReborn.Cards;

namespace CardsReborn
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    //[BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class CardsReborn : BaseUnityPlugin
    {
        private const string ModId = "com.robo.rounds.Cards.Reborn.Id";
        private const string ModName = "CardsReborn";
        public const string Version = "0.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "CR";

        public static CardsReborn instance { get; private set; }

        void Awake()
        {
            instance = this;

            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            CustomCard.BuildCard<EvasiveManeuvers>();
        }
    }
}
