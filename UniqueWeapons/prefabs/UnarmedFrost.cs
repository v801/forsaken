using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class UnarmedFrostPrefab : PrefabConfig
    {
        public UnarmedFrostPrefab() : base("v801_UnarmedFrost", "v801_UnarmedFrost_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_name = "Wyrmfist";
            item.m_itemData.m_shared.m_description = "Dragon Queen's Overbite";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 700;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_timedBlockBonus = 2;
            item.m_itemData.m_shared.m_deflectionForce = 2;
            item.m_itemData.m_shared.m_attackForce = 8;
            item.m_itemData.m_shared.m_blockPower = 70;
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "knife_secondary";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1.25f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 2.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 50;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
            item.m_itemData.m_shared.m_damages.m_blunt = 60;
            item.m_itemData.m_shared.m_damages.m_frost = 90;
        }
    }
}
