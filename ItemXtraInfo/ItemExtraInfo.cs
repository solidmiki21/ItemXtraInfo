using BepInEx;
using RoR2;
using System;
using System.Collections.Generic;

namespace ItemXtraInfo
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.solidmiki21.ItemExtraInfo", "ItemExtraInfo", "0.2.2")]
    public class ItemExtraInfo : BaseUnityPlugin
    {
        public void Awake()
        {
            Chat.AddMessage("Creating dictionaries");
            Dictionary<ItemIndex, Func<int, double>> items = new ItemDict().getDictionary();
            Dictionary<ItemIndex, string> itemsDescr = new ItemDescDict().getDictionary();
            Chat.AddMessage("Dictionaries created");
            Chat.AddMessage("Creating hooks");
            //Hook de cuando se actualiza el número de objetos (al obtener uno nuevo) en la interfaz.
            On.RoR2.UI.ItemIcon.SetItemIndex += (orig, self, newIndex, newCount) =>
            {
                //Llamar a la función original.
                orig(self, newIndex, newCount);

                //Obtener qué objeto es de entre todos los del juego
                var itemDef = ItemCatalog.GetItemDef(newIndex);
                ItemIndex item = itemDef.itemIndex;
                if (self.tooltipProvider != null && itemDef != null)
                {
                    //obtener descripción
                    var itemDescription = Language.GetString(itemDef.descriptionToken);
                    //Obtener la función correspondiente a ese objeto, tratando los casos especiales.
                    switch (item) {
                        case ItemIndex.TitanGoldDuringTP:
                            itemDescription += "\n Current damage: " + (50 + 50 * newCount);
                            itemDescription += "\n Current health: " + (100 * newCount);
                            break;
                        case ItemIndex.LunarDagger:
                            itemDescription += "\n Current damage bonus: " + (Math.Pow(2, newCount));
                            itemDescription += "\n Current health: " + (100 / Math.Pow(2, newCount));
                            break;
                        case ItemIndex.Mushroom:
                            itemDescription += "\n Current healing: " + (2.5 + 2.5 * newCount);
                            itemDescription += "\n Current health: " + (1.5 + 1.5 * newCount);
                            break;
                        case ItemIndex.ExplodeOnDeath:
                            itemDescription += "\n Current damage: " + (9.6 + 2.4 * newCount);
                            itemDescription += "\n Current health: " + (70 + 280 * newCount);
                            break;
                        case ItemIndex.BounceNearby:
                            itemDescription += "\n Proc chance: " + (20 * newCount);
                            itemDescription += "\n Max number of enemies hit: " + (5 + 5 * newCount);
                            break;
                        case ItemIndex.Knurl:
                            itemDescription += "\n Max health increase: " + (40 * newCount);
                            itemDescription += "\n Regeneration bonus: " + (1.6 * newCount);
                            break;
                        case ItemIndex.ExtraLifeConsumed:
                            itemDescription += "\n You can hear some vampiric noises coming out of it.";
                            break;
                        case ItemIndex.EquipmentMagazine:
                            itemDescription += "\n Total charges: " + (1 + newCount);
                            itemDescription += "\n Cooldown reduced: " + (15 * newCount);
                            break;
                        case ItemIndex.Icicle:
                            itemDescription += "\n Total damage: " + (150 * newCount);
                            itemDescription += "\n Total max radius: " + (6 * newCount);
                            break;
                        case ItemIndex.GoldOnHit:
                            itemDescription += "\n Total gold per hit: " + (3 * newCount);
                            itemDescription += "\n Total gold loss depends on various factors.";
                            break;
                        case ItemIndex.ChainLightning:
                            itemDescription += "\n Max number of enemies hit: " + (1 + 2 * newCount);
                            itemDescription += "\n Bounce radius: " + (18 + 2 * newCount);
                            break;
                        case ItemIndex.NovaOnHeal:
                            itemDescription += "\n Maximum energy stored: " + (100 * newCount);
                            break;
                        case ItemIndex.IgniteOnKill:
                            itemDescription += "\n Current damage: " + (75 + 75 * newCount);
                            itemDescription += "\n Current radius: " + (8 + 4 * newCount);
                            break;
                        case ItemIndex.RepeatHeal:
                            itemDescription += "\n Healing bonus: " + (100 * newCount);
                            itemDescription += "\n Current health: " + (10 / Math.Pow(2, newCount));
                            break;
                        case ItemIndex.BeetleGland:
                            itemDescription += "\n Maximum number of guards: " + (newCount);
                            break;
                        default:
                            Func<int, double> XtraDescription;
                            if (items.TryGetValue(itemDef.itemIndex, out XtraDescription)) {
                                string XtraDesc;
                                if (itemsDescr.TryGetValue(itemDef.itemIndex, out XtraDesc)) {
                                    itemDescription += "\n Total " + XtraDesc + ": " + "<color=#00ff00>" + XtraDescription(newCount) + "</color>";
                                }
                                else { itemDescription += "\n Total effect of item: " + XtraDescription(newCount); }
                                 }
                            else { Chat.AddMessage("Couldn't find item."); }
                            break;
                    }

                    //Actualizar la descripción del objeto en la interfaz
                    self.tooltipProvider.overrideBodyText = itemDescription;
                }
            };
            Chat.AddMessage("Hooks created");
            Chat.AddMessage("Loaded ItemXtraInfo");
        }
    }
}
