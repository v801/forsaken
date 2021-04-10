using JotunnLib.Entities;

namespace ForsakenMod
{
    public class SpellFirePrefab : PrefabConfig
    {
        public SpellFirePrefab() : base("v801_SpellFire", "v801_SpellFire_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Chaotic Hand";
            item.m_itemData.m_shared.m_description = "The burning essence of a god.";
            // general
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_weight = 0.1f;
            item.m_itemData.m_shared.m_maxDurability = 600;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            // combat
            item.m_itemData.m_shared.m_blockPower = 0;
            item.m_itemData.m_shared.m_timedBlockBonus = 0;
            item.m_itemData.m_shared.m_deflectionForce = 0;
            item.m_itemData.m_shared.m_attackForce = 0;
            // damage
            // attack
            // attack secondary
        }
    }
}
