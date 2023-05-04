using SMC.Mod;
using UnboundLib.Cards;
using UnityEngine;

namespace SMC.Cards
{
    class Switcheroo : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            (gun.reloadTime, gun.attackSpeed) = (gun.attackSpeed, gun.reloadTime);
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            (gun.reloadTime, gun.attackSpeed) = (gun.attackSpeed, gun.reloadTime);
        }

        protected override string GetTitle()
        {
            return "Switcheroo";
        }

        protected override string GetDescription()
        {
            return "Swaps reload time and shooting cooldown";
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Reload Speed",
                    amount = "Shoot Cooldown",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Shoot Cooldown",
                    amount = "Reload Speed",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }

        public override string GetModName()
        {
            return SphericalModificationCards.ModInitials;
        }
    }
}