using BepInEx;
using RoR2;
using System;
using System.Collections.Generic;

namespace ItemXtraInfo
{
    public class ItemDescDict
    {
        private Dictionary<ItemIndex, string> itemsDescr;
        public ItemDescDict()
        {
            this.itemsDescr = new Dictionary<ItemIndex, string>(){
                {ItemIndex.StickyBomb, "chance to stick a bomb"},
                {ItemIndex.ShieldOnly, "attack speed"},
                {ItemIndex.SprintWisp, "damage"},
                {ItemIndex.SlowOnHit, "slow duration (seconds)"},
                {ItemIndex.Tooth, "healing per orb"},
                {ItemIndex.SecondarySkillMagazine, "secondary extra charges"},
                {ItemIndex.FallBoots, "recharge time"},
                {ItemIndex.Phasing, "stealth duration (seconds)"},
                {ItemIndex.TreasureCache, "increases item rarity"},
                {ItemIndex.DrizzlePlayerHelper, "no Xtra description"},
                {ItemIndex.WarCryOnMultiKill, "frenzy duration (seconds)"},
                {ItemIndex.ShockNearby, "max number of enemies hit"},
                {ItemIndex.PersonalShield, "amount of shield"},
                {ItemIndex.Dagger, "damage of each dagger"},
                {ItemIndex.HeadHunter, "buff duration (seconds)"},
                {ItemIndex.BarrierOnKill, "barrier on kill"},
                {ItemIndex.IceRing, "icicle damage"},
                {ItemIndex.KillEliteFrenzy, "no cooldown duration (seconds)"},
                {ItemIndex.SprintArmor, "armor gained:"},
                //Tratamiento especial
                {ItemIndex.AutoCastEquipment, "equipment cooldown reduction"},
                {ItemIndex.Hoof, "mov. speed bonus"},
                {ItemIndex.Seed, "healing per damage delt"},
                {ItemIndex.AttackSpeedOnCrit, "maximum buff stacks"},
                {ItemIndex.Crowbar, "damage boost"},
                {ItemIndex.AlienHead, "skill cd reduction"},
                {ItemIndex.Firework, "amount of fireworks fired"},
                {ItemIndex.Behemoth, "explosion radius"},
                {ItemIndex.Talisman, "cooldown reduction on kill" },
                {ItemIndex.Syringe, "attack speed bonus"},
                {ItemIndex.Clover, "maximum number of rerolls"},
                {ItemIndex.BossDamageBonus, "additional damage to bosses"},
                {ItemIndex.UtilitySkillMagazine, "maximum utility charges"},
                {ItemIndex.BarrierOnOverHeal, "total barrier gained"},
                {ItemIndex.Bear, "dodge chance"},
                {ItemIndex.Medkit, "healing after taking damage"},
                {ItemIndex.EnergizedOnEquipmentUse, "attack speed bonus (seconds)"},
                {ItemIndex.ExecuteLowHealthElite, "execution threshold"},
                {ItemIndex.ExtraLife, "number of revives left"},
                {ItemIndex.JumpBoost, "jump bonus (meters)"},
                {ItemIndex.SprintBonus, "mov. speed bonus"},
                {ItemIndex.FireRing, "flame tornado damage"},
                {ItemIndex.CooldownOnCrit, "restored cooldown (seconds)"},
                {ItemIndex.WardOnLevel, "maximum buff radius"},
                {ItemIndex.PlasmaCore, "Description Machine Broke"},
                {ItemIndex.SprintOutOfCombat, "mov. speed bonus"},
                {ItemIndex.IncreaseHealing, "healing amount"},
                {ItemIndex.Feather, "max number of jumps" },
                {ItemIndex.WarCryOnCombat, "frenzy duration (seconds)"},
                {ItemIndex.HealOnCrit, "healing per critical strike"},
                {ItemIndex.CritGlasses, "critical strike chance"},
                {ItemIndex.Bandolier, "chance to drop ammo pack"},
                {ItemIndex.Missile, "damage per missile"},
                {ItemIndex.BleedOnHit, "bleed chance"},
                {ItemIndex.Infusion, "maximum amout of HP gain"},
                {ItemIndex.StunChanceOnHit, "stun chance per hit"},
                {ItemIndex.GhostOnKill, "ghost duration (seconds)"},
                {ItemIndex.HealWhileSafe, "passive health regeneration increase"}
            };
        }
        public Dictionary<ItemIndex, string> getDictionary()
        {
            return this.itemsDescr;
        }
    }
}
