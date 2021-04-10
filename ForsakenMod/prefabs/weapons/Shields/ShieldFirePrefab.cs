using JotunnLib.Entities;

namespace ForsakenMod
{
    public class ShieldFirePrefab : PrefabConfig
    {
        public ShieldFirePrefab() : base("v801_ShieldFire", "v801_ShieldFire_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Aegis of the Dead King";
            item.m_itemData.m_shared.m_description = "All returns to dust.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_weight = 10;
            item.m_itemData.m_shared.m_maxDurability = 600;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            // combat
            item.m_itemData.m_shared.m_blockPower = 120;
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 8;
            item.m_itemData.m_shared.m_attackForce = 0;
            // damage
            // attack
            // attack secondary
        }
    }
}
