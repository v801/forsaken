using JotunnLib.Entities;

namespace ForsakenMod
{
    public class KnifeFrostPrefab : PrefabConfig
    {
        public KnifeFrostPrefab() : base("v801_KnifeFrost", "v801_KnifeFrost_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Icicle";
            item.m_itemData.m_shared.m_description = "Ancient crystalized magic.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_weight = 1.5f;
            item.m_itemData.m_shared.m_maxDurability = 500;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            //item.m_itemData.m_shared.m_variants = 1;
            // combat
            //item.m_itemData.m_shared.m_blockPower = 0;
            //item.m_itemData.m_shared.m_timedBlockBonus = 0;
            //item.m_itemData.m_shared.m_deflectionForce = 0;
            //item.m_itemData.m_shared.m_attackForce = 0;
            item.m_itemData.m_shared.m_backstabBonus = 4f;
            // damage
            item.m_itemData.m_shared.m_damages.m_slash = 0;
            item.m_itemData.m_shared.m_damages.m_pierce = 75;
            item.m_itemData.m_shared.m_damages.m_frost = 75;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 15;
            item.m_itemData.m_shared.m_attack.m_speedFactor = 0.1f;
            item.m_itemData.m_shared.m_attack.m_speedFactorRotation = 0.1f;
            item.m_itemData.m_shared.m_attack.m_attackHeight = 1f;
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1.15f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 30;
        }
    }
}
