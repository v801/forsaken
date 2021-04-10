using JotunnLib.Entities;

namespace ForsakenMod
{
    public class UnarmedFenringPrefab : PrefabConfig
    {
        public UnarmedFenringPrefab() : base("v801_UnarmedFenring", "v801_UnarmedFenring_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Lycanthro";
            item.m_itemData.m_shared.m_description = "Shadows are our sails of night, and soon they'll take away your light.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_equipDuration = 0.25f;
            item.m_itemData.m_shared.m_maxDurability = 800;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_weight = 2;
            // combat
            item.m_itemData.m_shared.m_blockPower = 30;
            item.m_itemData.m_shared.m_timedBlockBonus = 2;
            item.m_itemData.m_shared.m_deflectionForce = 2;
            item.m_itemData.m_shared.m_attackForce = 2;
            item.m_itemData.m_shared.m_movementModifier = 0f;
            // damage
            item.m_itemData.m_shared.m_damages.m_slash = 50;
            item.m_itemData.m_shared.m_damages.m_pierce = 45;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_attack.m_speedFactor = 0.1f;
            item.m_itemData.m_shared.m_attack.m_speedFactorRotation = 0.1f;
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
        }
    }
}
