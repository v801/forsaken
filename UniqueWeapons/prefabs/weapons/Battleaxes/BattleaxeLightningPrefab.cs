using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class BattleaxeLightningPrefab : PrefabConfig
    {
        public BattleaxeLightningPrefab() : base("v801_BattleaxeLightning", "v801_BattleaxeLightning_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Static Cleaver";
            item.m_itemData.m_shared.m_description = "Bzzzzzzzt.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.OneHandedWeapon;
            item.m_itemData.m_shared.m_maxDurability = 400;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_weight = 2.5f;
            // combat
            item.m_itemData.m_shared.m_attackForce = 12;
            item.m_itemData.m_shared.m_deflectionForce = 6;
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            // damage
            item.m_itemData.m_shared.m_damages.m_slash = 75;
            item.m_itemData.m_shared.m_damages.m_lightning = 40;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 30;
            item.m_itemData.m_shared.m_attack.m_attackAnimation = "swing_longsword";
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "atgeir_secondary";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackChainLevels = 0;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 0.75f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 360;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
        }
    }
}
