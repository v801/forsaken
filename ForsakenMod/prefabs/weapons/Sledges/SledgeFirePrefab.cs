using HarmonyLib;
using JotunnLib.Entities;
using UnityEngine;

namespace ForsakenMod
{
    public class SledgeFirePrefab : PrefabConfig
    {
        public SledgeFirePrefab() : base("v801_SledgeFire", "v801_SledgeFire_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Molten Star";
            item.m_itemData.m_shared.m_description = "Smells of sulfur and burning flesh...";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.TwoHandedWeapon;
            item.m_itemData.m_shared.m_maxDurability = 750;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_weight = 4;
            // combat
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 6;
            item.m_itemData.m_shared.m_attackForce = 6;
            // damage
            item.m_itemData.m_shared.m_damages.m_blunt = 40;
            item.m_itemData.m_shared.m_damages.m_pierce = 100;
            item.m_itemData.m_shared.m_damages.m_fire = 100;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_attack.m_attackAnimation = "battleaxe_attack";
            item.m_itemData.m_shared.m_attack.m_attackChainLevels = 3;
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "swing_sledge";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 35;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;

            // status effect
            var burning = ScriptableObject.CreateInstance<SE_Burning>();
            // load damages field
            var burnDamageField = AccessTools.Field(typeof(SE_Burning), "m_damage");
            var burnDamage = (HitData.DamageTypes)burnDamageField.GetValue(burning);
            // edit fire damage
            burnDamage.m_fire = 6;
            // save damages field
            burnDamageField.SetValue(burning, burnDamage);
            // set item status effect
            item.m_itemData.m_shared.m_equipStatusEffect = burning;
        }
    }
}
