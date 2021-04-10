using JotunnLib.Entities;

namespace ForsakenMod
{
    public class UnarmedFrostOHPrefab : PrefabConfig
    {
        public UnarmedFrostOHPrefab() : base("v801_UnarmedFrostOH", "v801_UnarmedFrostOH_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Wyrmripper";
            item.m_itemData.m_shared.m_description = "Dragon Queen's Underbite";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 700;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            // combat
            item.m_itemData.m_shared.m_timedBlockBonus = 2;
            item.m_itemData.m_shared.m_deflectionForce = 2;
            item.m_itemData.m_shared.m_attackForce = 8;
            item.m_itemData.m_shared.m_blockPower = 90;
            item.m_itemData.m_shared.m_deflectionForce = 1;
            // damage
            item.m_itemData.m_shared.m_damages.m_blunt = 90;
            item.m_itemData.m_shared.m_damages.m_frost = 80;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 180;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
        }
    }
}
