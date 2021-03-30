using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class SwordFirePrefab : PrefabConfig
    {
        public SwordFirePrefab() : base("v801_SwordFire", "v801_SwordFire_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.TwoHandedWeapon;
            item.m_itemData.m_shared.m_name = "Riftblade";
            item.m_itemData.m_shared.m_description = "This feeling...";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_weight = 30;
            item.m_itemData.m_shared.m_maxDurability = 800;
            item.m_itemData.m_shared.m_equipDuration = 1f;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 8;
            item.m_itemData.m_shared.m_attackForce = 0;
            item.m_itemData.m_shared.m_movementModifier = -0.25f;
            item.m_itemData.m_shared.m_attack.m_attackStamina = 30;
            item.m_itemData.m_shared.m_attack.m_attackAnimation = "battleaxe_attack";
            item.m_itemData.m_shared.m_attack.m_attackChainLevels = 3;
            item.m_itemData.m_shared.m_attack.m_speedFactor = 0.1f;
            item.m_itemData.m_shared.m_attack.m_speedFactorRotation = 0.1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "battleaxe_secondary";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackChainLevels = 0;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1.25f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 90;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
            item.m_itemData.m_shared.m_damages.m_slash = 0;
            item.m_itemData.m_shared.m_damages.m_fire = 36;
            item.m_itemData.m_shared.m_damages.m_frost = 36;
            item.m_itemData.m_shared.m_damages.m_lightning = 36;
            item.m_itemData.m_shared.m_damages.m_spirit = 36;
            item.m_itemData.m_shared.m_damages.m_poison = 36;
        }
    }
}
