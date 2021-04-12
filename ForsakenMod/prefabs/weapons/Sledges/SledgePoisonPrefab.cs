using JotunnLib.Entities;

namespace ForsakenMod
{
    public class SledgePoisonPrefab : PrefabConfig
    {
        public SledgePoisonPrefab() : base("v801_SledgePoison", "v801_SledgePoison_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            // info
            item.m_itemData.m_shared.m_name = "Rotclub";
            item.m_itemData.m_shared.m_description = "It reeks... Absolutely disgusting...";
            // general
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.TwoHandedWeapon;
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 550;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_weight = 4;
            item.m_itemData.m_shared.m_variants = 1;
            // combat
            item.m_itemData.m_shared.m_timedBlockBonus = 6;
            item.m_itemData.m_shared.m_deflectionForce = 6;
            item.m_itemData.m_shared.m_attackForce = 12;
            item.m_itemData.m_shared.m_blockPower = 40;
            // damage
            item.m_itemData.m_shared.m_damages.m_blunt = 140;
            item.m_itemData.m_shared.m_damages.m_poison = 80;
            // attack
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_attack.m_attackAnimation = "battleaxe_attack";
            item.m_itemData.m_shared.m_attack.m_attackChainLevels = 3;
            // attack secondary
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "swing_sledge";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 35;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
        }
    }
}
