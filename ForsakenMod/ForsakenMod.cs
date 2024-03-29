﻿using System;
using System.IO;
using BepInEx;
using JotunnLib.Managers;
using JotunnLib.Entities;
using UnityEngine;

namespace ForsakenMod
{
    [BepInPlugin("com.bepinex.plugins.forsaken", "Forsaken", "0.7.0")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    public class ForsakenMod : BaseUnityPlugin
    {
        // ARMOR
        // WEAPONS
        private static GameObject itemPrefabBattleaxeLightning;
        private static GameObject itemPrefabSpearSpirit;
        private static GameObject itemPrefabSledgePoison;
        private static GameObject itemPrefabSledgeFire;
        private static GameObject itemPrefabUnarmedFrost;
        private static GameObject itemPrefabUnarmedFrostOH;
        private static GameObject itemPrefabUnarmedFenring;
        private static GameObject itemPrefabSwordFire;
        private static GameObject itemPrefabSwordLightning;
        private static GameObject itemPrefabShieldFire;
        private static GameObject itemPrefabSpellFire;
        private static GameObject itemPrefabBowFrost;
        private static GameObject itemPrefabKnifeFrost;
        private void Awake()
        {
            ObjectManager.Instance.ObjectRegister += registerObjects;
            PrefabManager.Instance.PrefabRegister += registerPrefabs;

            // ASSET BUNDLES
            AssetBundle bundle = AssetBundle.LoadFromFile(Path.Combine(Paths.PluginPath, "Forsaken/forsakenmod"));

            // ARMOR
            // WEAPONS
            // BATTLEAXE LIGHTNING
            itemPrefabBattleaxeLightning = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_BattleaxeLightning/v801_BattleaxeLightning.prefab");

            // SPEAR SPIRIT
            itemPrefabSpearSpirit = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SpearSpirit/v801_SpearSpirit.prefab");

            // SLEDGE POISON
            itemPrefabSledgePoison = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SledgePoison/v801_SledgePoison.prefab");

            // SLEDGE FIRE
            itemPrefabSledgeFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SledgeFire/v801_SledgeFire.prefab");

            // UNARMED FROST
            itemPrefabUnarmedFrost = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_UnarmedFrost/v801_UnarmedFrost.prefab");
            itemPrefabUnarmedFrostOH = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_UnarmedFrost/v801_UnarmedFrostOH.prefab");

            // UNARMED FENRING
            itemPrefabUnarmedFenring = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_UnarmedFenring/v801_UnarmedFenring.prefab");

            // SWORD FIRE
            itemPrefabSwordFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SwordFire/v801_SwordFire.prefab");

            // SWORD LIGHTNING
            itemPrefabSwordLightning = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SwordLightning/v801_SwordLightning.prefab");

            // SHIELD FIRE
            itemPrefabShieldFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_ShieldFire/v801_ShieldFire.prefab");

            // RANGED CHAOTIC HAND
            itemPrefabSpellFire = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_SpellFire/v801_SpellFire.prefab");

            // BOW FROST
            itemPrefabBowFrost = (GameObject)bundle.LoadAsset("Assets/Custom_Items/v801_BowFrost/v801_BowFrost.prefab");

            // KNIFE FROST
            itemPrefabKnifeFrost = (GameObject)bundle.LoadAsset("Assets/Custom_Items/weapons/v801_KnifeFrost/v801_KnifeFrost.prefab");
        }

        private void registerPrefabs(object sender, EventArgs e)
        {
            // ARMOR
            // WEAPONS
            // BATTLEAXE LIGHTNING
            PrefabManager.Instance.RegisterPrefab(itemPrefabBattleaxeLightning, "v801_BattleaxeLightning_bundle");
            PrefabManager.Instance.RegisterPrefab(new BattleaxeLightningPrefab());

            // SPEAR SPIRIT
            PrefabManager.Instance.RegisterPrefab(itemPrefabSpearSpirit, "v801_SpearSpirit_bundle");
            PrefabManager.Instance.RegisterPrefab(new SpearSpiritPrefab());

            // SLEDGE POISON
            PrefabManager.Instance.RegisterPrefab(itemPrefabSledgePoison, "v801_SledgePoison_bundle");
            PrefabManager.Instance.RegisterPrefab(new SledgePoisonPrefab());

            // SLEDGE FIRE
            PrefabManager.Instance.RegisterPrefab(itemPrefabSledgeFire, "v801_SledgeFire_bundle");
            PrefabManager.Instance.RegisterPrefab(new SledgeFirePrefab());

            // UNARMED FROST
            PrefabManager.Instance.RegisterPrefab(itemPrefabUnarmedFrost, "v801_UnarmedFrost_bundle");
            PrefabManager.Instance.RegisterPrefab(new UnarmedFrostPrefab());
            PrefabManager.Instance.RegisterPrefab(itemPrefabUnarmedFrostOH, "v801_UnarmedFrostOH_bundle");
            PrefabManager.Instance.RegisterPrefab(new UnarmedFrostOHPrefab());

            // SWORD FIRE
            PrefabManager.Instance.RegisterPrefab(itemPrefabSwordFire, "v801_SwordFire_bundle");
            PrefabManager.Instance.RegisterPrefab(new SwordFirePrefab());

            // SWORD LIGHTNING
            PrefabManager.Instance.RegisterPrefab(itemPrefabSwordLightning, "v801_SwordLightning_bundle");
            PrefabManager.Instance.RegisterPrefab(new SwordLightningPrefab());

            // UNARMED FENRING
            PrefabManager.Instance.RegisterPrefab(itemPrefabUnarmedFenring, "v801_UnarmedFenring_bundle");
            PrefabManager.Instance.RegisterPrefab(new UnarmedFenringPrefab());

            // SHIELD FIRE
            PrefabManager.Instance.RegisterPrefab(itemPrefabShieldFire, "v801_ShieldFire_bundle");
            PrefabManager.Instance.RegisterPrefab(new ShieldFirePrefab());

            // RANGED CHAOTIC HAND
            PrefabManager.Instance.RegisterPrefab(itemPrefabSpellFire, "v801_SpellFire_bundle");
            PrefabManager.Instance.RegisterPrefab(new SpellFirePrefab());

            // BOW FROST
            PrefabManager.Instance.RegisterPrefab(itemPrefabBowFrost, "v801_BowFrost_bundle");
            PrefabManager.Instance.RegisterPrefab(new BowFrostPrefab());

            // KNIFE NEEDLE
            PrefabManager.Instance.RegisterPrefab(itemPrefabKnifeFrost, "v801_KnifeFrost_bundle");
            PrefabManager.Instance.RegisterPrefab(new KnifeFrostPrefab());
        }

        private void registerObjects(object sender, EventArgs e)
        {
            // REGISTER ITEMS
            // ARMOR
            // WEAPONS
            // BATTLEAXE LIGHTNING
            ObjectManager.Instance.RegisterItem("v801_BattleaxeLightning");
            // SPEAR SPIRIT
            ObjectManager.Instance.RegisterItem("v801_SpearSpirit");
            // SLEDGE POISON
            ObjectManager.Instance.RegisterItem("v801_SledgePoison");
            // SLEDGE FIRE
            ObjectManager.Instance.RegisterItem("v801_SledgeFire");
            // UNARMED FROST
            ObjectManager.Instance.RegisterItem("v801_UnarmedFrost");
            ObjectManager.Instance.RegisterItem("v801_UnarmedFrostOH");
            // UNARMED FENRING
            ObjectManager.Instance.RegisterItem("v801_UnarmedFenring");
            // SWORD LIGHTNING
            ObjectManager.Instance.RegisterItem("v801_SwordLightning");
            // SWORD FIRE
            ObjectManager.Instance.RegisterItem("v801_SwordFire");
            // SHIELD FIRE
            ObjectManager.Instance.RegisterItem("v801_ShieldFire");
            // SPELL FIRE
            ObjectManager.Instance.RegisterItem("v801_SpellFire");
            // BOW FROST
            ObjectManager.Instance.RegisterItem("v801_BowFrost");
            // NEEDLE FROST
            ObjectManager.Instance.RegisterItem("v801_KnifeFrost");

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
            // SLEDGE FIRE RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_MoltenStar",
                Item = "v801_SledgeFire",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 6,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Flametal",
                        Amount = 80
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "SurtlingCore",
                        Amount = 60
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "BlackMetal",
                        Amount = 60
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophySurtling",
                        Amount = 60
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
                        Amount = 20
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyDragonQueen",
                        Amount = 6
                    },
                }
            });
            // UNARMED FENRING RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Lycanthro",
                Item = "v801_UnarmedFenring",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 5,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FreezeGland",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 60
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Chain",
                        Amount = 4
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyFenring",
                        Amount = 10
                    },
                }
            });
            // KNIFE FROST RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_Icicle",
                Item = "v801_KnifeFrost",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 6,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "FreezeGland",
                        Amount = 24
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Needle",
                        Amount = 60
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
                        Amount = 4
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
            // SWORD LIGHTNING RECIPE
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_BoltsEdge",
                Item = "v801_SwordLightning",
                Amount = 1,
                CraftingStation = "forge",
                MinStationLevel = 7,

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "Iron",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Crystal",
                        Amount = 40
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "Silver",
                        Amount = 36
                    },
                    new PieceRequirementConfig()
                    {
                        Item = "TrophyEikthyr",
                        Amount = 12
                    },
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