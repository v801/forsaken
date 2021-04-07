using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class BowFrostPrefab : PrefabConfig
    {
        public BowFrostPrefab() : base("v801_BowFrost", "v801_BowFrost_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Rimefang";
            item.m_itemData.m_shared.m_description = "They won't be cold until they freeze. They won't speak unless they scream.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_maxDurability = 600;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_weight = 10;
            // combat
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 8;
            item.m_itemData.m_shared.m_attackForce = 0;
            // damage
            // attack
            // attack secondary
        }
    }
}
