using System;
using System.IO;
using BepInEx;
using JotunnLib.Managers;
using JotunnLib.Entities;
using JotunnLib.Utils;
using UnityEngine;

namespace UniqueWeapons
{
    [BepInPlugin("com.bepinex.plugins.uniqueweapons", "UniqueWeapons", "0.4.0")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    public class UniqueWeapons : BaseUnityPlugin
    {
        private static GameObject itemPrefabBattleaxeLightning;
        private static GameObject itemPrefabSpearSpirit;
        private static GameObject itemPrefabSledgePoison;
        private static GameObject itemPrefabUnarmedFrost;
        private static GameObject itemPrefabUnarmedFrostOH;
        private static GameObject itemPrefabSwordFire;
        private static GameObject itemPrefabShieldFire;
        private static GameObject itemPrefabSpellFire;
        private static GameObject itemPrefabBowFrost;
        private void Awake()
        {
            ObjectManager.Instance.ObjectRegister += registerObjects;
            PrefabManager.Instance.PrefabRegister += registerPrefabs;

            // ASSET BUNDLES
            AssetBundle bundle = AssetBundle.LoadFromFile(Path.Combine(Paths.PluginPath, "UniqueWeapons/uniqueweapons"));

            // BATTLEAXE LIGHTNING
            itemPrefabBattleaxeLightning = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_BattleaxeLightning/v801_BattleaxeLightning.prefab");

            // SPEAR SPIRIT
            itemPrefabSpearSpirit = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SpearSpirit/v801_SpearSpirit.prefab");

            // SLEDGE POISON
            itemPrefabSledgePoison = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SledgePoison/v801_SledgePoison.prefab");

            // UNARMED FROST
            itemPrefabUnarmedFrost = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_UnarmedFrost/v801_UnarmedFrost.prefab");
            itemPrefabUnarmedFrostOH = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_UnarmedFrost/v801_UnarmedFrostOH.prefab");

            // SWORD FIRE
            itemPrefabSwordFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SwordFire/v801_SwordFire.prefab");

            // SHIELD FIRE
            itemPrefabShieldFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_ShieldFire/v801_ShieldFire.prefab");

            // SPELL FIRE
            itemPrefabSpellFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SpellFire/v801_SpellFire.prefab");

            // BOW FROST
            itemPrefabBowFrost = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_BowFrost/v801_BowFrost.prefab");
        }

        private void registerPrefabs(object sender, EventArgs e)
        {
            // BATTLEAXE LIGHTNING
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabBattleaxeLightning, "v801_BattleaxeLightning_bundle" });
            PrefabManager.Instance.RegisterPrefab(new BattleaxeLightningPrefab());

            // SPEAR SPIRIT
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabSpearSpirit, "v801_SpearSpirit_bundle" });
            PrefabManager.Instance.RegisterPrefab(new SpearSpiritPrefab());

            // SLEDGE POISON
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabSledgePoison, "v801_SledgePoison_bundle" });
            PrefabManager.Instance.RegisterPrefab(new SledgePoisonPrefab());

            // UNARMED FROST
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabUnarmedFrost, "v801_UnarmedFrost_bundle" });
            PrefabManager.Instance.RegisterPrefab(new UnarmedFrostPrefab());
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabUnarmedFrostOH, "v801_UnarmedFrostOH_bundle" });
            PrefabManager.Instance.RegisterPrefab(new UnarmedFrostOHPrefab());

            // SWORD FIRE
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabSwordFire, "v801_SwordFire_bundle" });
            PrefabManager.Instance.RegisterPrefab(new SwordFirePrefab());

            // SHIELD FIRE
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabShieldFire, "v801_ShieldFire_bundle" });
            PrefabManager.Instance.RegisterPrefab(new ShieldFirePrefab());

            // SPELL FIRE
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabSpellFire, "v801_SpellFire_bundle" });
            PrefabManager.Instance.RegisterPrefab(new SpellFirePrefab());

            // BOW FROST
            ReflectionUtils.InvokePrivate(PrefabManager.Instance, "RegisterPrefab", new object[] { itemPrefabBowFrost, "v801_BowFrost_bundle" });
            PrefabManager.Instance.RegisterPrefab(new BowFrostPrefab());
        }

        private void registerObjects(object sender, EventArgs e)
        {
            // REGISTER ITEMS
            // BATTLEAXE LIGHTNING
            ObjectManager.Instance.RegisterItem("v801_BattleaxeLightning");
            // SPEAR SPIRIT
            ObjectManager.Instance.RegisterItem("v801_SpearSpirit");
            // SLEDGE POISON
            ObjectManager.Instance.RegisterItem("v801_SledgePoison");
            // UNARMED FROST
            ObjectManager.Instance.RegisterItem("v801_UnarmedFrost");
            ObjectManager.Instance.RegisterItem("v801_UnarmedFrostOH");
            // SWORD FIRE
            ObjectManager.Instance.RegisterItem("v801_SwordFire");
            // SHIELD FIRE
            ObjectManager.Instance.RegisterItem("v801_ShieldFire");
            // SPELL FIRE
            ObjectManager.Instance.RegisterItem("v801_SpellFire");
            // BOW FROST
            ObjectManager.Instance.RegisterItem("v801_BowFrost");

            // REGISTER RECIPES
            // BATTLEAXE LIGHTNING
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_StaticCleaver",
                Item = "v801_BattleaxeLightning",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 1,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FineWood",
                        Amount = 30
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "LeatherScraps",
                        Amount = 12
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 90
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyEikthyr",
                        Amount = 1
                    }
                }
            });
            // SPEAR SPIRIT
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_PrimordialImpaler",
                Item = "v801_SpearSpirit",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 4,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "ElderBark",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Crystal",
                        Amount = 12
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "AncientSeed",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyTheElder",
                        Amount = 3
                    }
                }
            });
            // SLEDGE POISON RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Rotclub",
                Item = "v801_SledgePoison",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 4,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "WitheredBone",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Guck",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "BlackMetal",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyBonemass",
                        Amount = 6
                    }
                }
            });
            // BOW FROST RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Rimefang",
                Item = "v801_BowFrost",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 6,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FreezeGland",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Crystal",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "DragonTear",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyDragonQueen",
                        Amount = 8
                    },
                }
            });
            // UNARMED FROST RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Wyrmfist",
                Item = "v801_UnarmedFrost",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 6,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FreezeGland",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyHatchling",
                        Amount = 10
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "DragonTear",
                        Amount = 80
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyDragonQueen",
                        Amount = 8
                    },
                }
            });
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Wyrmripper",
                Item = "v801_UnarmedFrostOH",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 6,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FreezeGland",
                        Amount = 10
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyHatchling",
                        Amount = 4
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "DragonTear",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyDragonQueen",
                        Amount = 2
                    },
                }
            });
            // SHIELD FIRE RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_AegisOfTheDeadKing",
                Item = "v801_ShieldFire",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 7,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Flametal",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyGoblinKing",
                        Amount = 10
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "YagluthDrop",
                        Amount = 30
                    }
                }
            });
            // SWORD FIRE RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Riftblade",
                Item = "v801_SwordFire",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 7,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Crystal",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Flametal",
                        Amount = 60
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyGoblinKing",
                        Amount = 12
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "YagluthDrop",
                        Amount = 36
                    }
                }
            });
            // SPELL FIRE RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_ChaoticHand",
                Item = "v801_SpellFire",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 7,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Crystal",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyGoblinKing",
                        Amount = 12
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "YagluthDrop",
                        Amount = 36
                    }
                }
            });
        }
    }
}