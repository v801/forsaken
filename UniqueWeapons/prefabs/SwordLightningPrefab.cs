using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class SwordLightningPrefab : PrefabConfig
    {
        public SwordLightningPrefab() : base("v801_SwordLightning", "v801_SwordLightning_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_name = "Bolt's Edge";
            item.m_itemData.m_shared.m_description = "In battle there is no law.";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 700;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_timedBlockBonus = 2;
            item.m_itemData.m_shared.m_deflectionForce = 2;
            item.m_itemData.m_shared.m_attackForce = 8;
            item.m_itemData.m_shared.m_blockPower = 30;
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1.25f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
            item.m_itemData.m_shared.m_damages.m_slash = 40;
            item.m_itemData.m_shared.m_damages.m_pierce = 40;
            item.m_itemData.m_shared.m_damages.m_lightning = 80;
        }
    }
}
