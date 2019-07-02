using BepInEx;
using RoR2;
using System;
using System.Collections.Generic;

namespace ItemXtraInfo
{
    public class ItemDict
    {
        private Dictionary<ItemIndex, Func<int, double>> items;
        public ItemDict()
        {
            this.items = new Dictionary<ItemIndex, Func<int, double>>(){
                {ItemIndex.StickyBomb, itemNum => 2.5 + 2.5 * itemNum},
                {ItemIndex.ShieldOnly, itemNum => Math.Pow(1.5,itemNum)},
                {ItemIndex.SprintWisp, itemNum => 100 * itemNum},
                {ItemIndex.SlowOnHit, itemNum => 2 * itemNum},
                {ItemIndex.Tooth, itemNum => 6 * itemNum},
                {ItemIndex.SecondarySkillMagazine, itemNum => itemNum},
                {ItemIndex.FallBoots, itemNum => 10/Math.Pow(2,itemNum)},
                {ItemIndex.Phasing, itemNum => 1.5 + (1.5 * itemNum)},
                {ItemIndex.TreasureCache, itemNum => itemNum},
                {ItemIndex.DrizzlePlayerHelper, itemNum => itemNum},
                {ItemIndex.WarCryOnMultiKill, itemNum => 2 +  (4 * itemNum)},
                {ItemIndex.ShockNearby, itemNum => 3 * itemNum},
                {ItemIndex.PersonalShield, itemNum => 25 * itemNum},
                {ItemIndex.Dagger, itemNum => itemNum * 150},
                {ItemIndex.HeadHunter, itemNum =>3 + 5 * itemNum},
                {ItemIndex.BarrierOnKill, itemNum => 20 * itemNum},
                {ItemIndex.IceRing, itemNum => 125 + 125 * itemNum},
                {ItemIndex.KillEliteFrenzy, itemNum => 1 + 2 * itemNum},
                {ItemIndex.SprintArmor, itemNum => 30 * itemNum},
                //Tratamiento especial
                {ItemIndex.AutoCastEquipment, itemNum => 35 + (15 * itemNum)},
                {ItemIndex.Hoof, itemNum => 14 * itemNum},
                {ItemIndex.Seed, itemNum => itemNum},
                {ItemIndex.AttackSpeedOnCrit, itemNum => 3 * itemNum},
                {ItemIndex.Crowbar, itemNum => 120 + 30 * itemNum},
                {ItemIndex.AlienHead, itemNum => 25 * itemNum},
                {ItemIndex.Firework, itemNum => 4 + 4 *itemNum},
                {ItemIndex.Behemoth, itemNum => 2.5 + 1.5 * itemNum},
                {ItemIndex.Talisman, itemNum => 2 + 2 * itemNum},
                {ItemIndex.Syringe, itemNum => 15*itemNum},
                {ItemIndex.Clover, itemNum => Math.Pow(2,itemNum) - 1},
                {ItemIndex.BossDamageBonus, itemNum => 20 * itemNum},
                {ItemIndex.UtilitySkillMagazine, itemNum => 2 * itemNum},
                {ItemIndex.BarrierOnOverHeal, itemNum => itemNum},
                //La formula está mal loco
                {ItemIndex.Bear, itemNum => (1 - 1/(0.15 * itemNum + 1)*100)},
                {ItemIndex.Medkit, itemNum => 10 * itemNum},
                {ItemIndex.EnergizedOnEquipmentUse, itemNum => 4 + 4*itemNum},
                {ItemIndex.ExecuteLowHealthElite, itemNum => 15 + 5*itemNum},
                {ItemIndex.ExtraLife, itemNum => itemNum},
                {ItemIndex.JumpBoost, itemNum => 10*itemNum},
                {ItemIndex.SprintBonus, itemNum => 10 + 20*itemNum},
                {ItemIndex.FireRing, itemNum => 250 + 250*itemNum},
                {ItemIndex.CooldownOnCrit, itemNum => itemNum},
                {ItemIndex.WardOnLevel, itemNum => 8 + 8 * itemNum},
                {ItemIndex.PlasmaCore, itemNum => itemNum},
                {ItemIndex.SprintOutOfCombat, itemNum => 30 * itemNum},
                {ItemIndex.IncreaseHealing, itemNum => 100 * itemNum},
                {ItemIndex.Feather, itemNum => itemNum },
                {ItemIndex.WarCryOnCombat, itemNum => 2 + 4 * itemNum},
                {ItemIndex.HealOnCrit, itemNum => 4 + 4 * itemNum},
                {ItemIndex.CritGlasses, itemNum => 10 * itemNum},
                {ItemIndex.Bandolier, itemNum => 8 + 10*itemNum},
                {ItemIndex.Missile, itemNum => 300*itemNum},
                {ItemIndex.BleedOnHit, itemNum => 15*itemNum},
                {ItemIndex.Infusion, itemNum => 100*itemNum},
                {ItemIndex.StunChanceOnHit, itemNum => 5*itemNum},
                {ItemIndex.GhostOnKill, itemNum => 30*itemNum},
                {ItemIndex.HealWhileSafe, itemNum => 100 + 150 * itemNum}
            };
        }
        public Dictionary<ItemIndex, Func<int, double>> getDictionary() {
            return this.items;
        }
    }
}
