using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class SledgePoisonPrefab : PrefabConfig
    {
        public SledgePoisonPrefab() : base("v801_SledgePoison", "v801_SledgePoison_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.TwoHandedWeapon;
            item.m_itemData.m_shared.m_name = "Rotclub";
            item.m_itemData.m_shared.m_description = "It reeks... Absolutely disgusting...";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 550;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_weight = 4;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 6;
            item.m_itemData.m_shared.m_attackForce = 12;
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_attack.m_attackAnimation = "battleaxe_attack";
            item.m_itemData.m_shared.m_attack.m_attackChainLevels = 3;
            item.m_itemData.m_shared.m_attack.m_attackAngle = 180;
            item.m_itemData.m_shared.m_attack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "swing_sledge";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 30;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 180;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
            item.m_itemData.m_shared.m_damages.m_blunt = 140;
            item.m_itemData.m_shared.m_damages.m_poison = 80;
        }
    }
}
