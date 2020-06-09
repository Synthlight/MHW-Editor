using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using MHW_Editor.Armors;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Skills;
using MHW_Editor.Structs.Armors;
using MHW_Editor.Structs.Gems;
using MHW_Editor.Structs.Items;
using MHW_Editor.Structs.Skills;
using MHW_Editor.Structs.Weapons;
using MHW_Editor.Windows.Models;
using MHW_Template;
using MHW_Template.Weapons;

namespace MHW_Editor.Windows {
    public partial class MainWindow {
        private void Btn_open_Click(object sender, RoutedEventArgs e) {
            Load();
        }

        private void Btn_open_as_json_Click(object sender, RoutedEventArgs e) {
            LoadJson();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e) {
            Save();
        }

        private void Btn_save_as_json_Click(object sender, RoutedEventArgs e) {
            SaveJson(false);
        }

        private void Btn_save_as_json_merge_Click(object sender, RoutedEventArgs e) {
            SaveJson(true);
        }

        private void Btn_chunk_search_Click(object sender, RoutedEventArgs e) {
            new FindFileInChunk().ShowDialog();
        }

        private void Btn_customize_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Armor),
                                   typeof(SkillDat))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case SkillDat.Entries skillDat: {
                        switch (skillDat.Id) {
                            case SkillDataValueClass.Scholar:
                            case SkillDataValueClass.Scenthound:
                                skillDat.Param_5 = 5000;
                                break;
                            case SkillDataValueClass.Tool_Specialist:
                                skillDat.Param_5 = 1;
                                break;
                            case SkillDataValueClass.Item_Prolonger:
                                skillDat.Param_5 = 5000;
                                break;
                            case SkillDataValueClass.Focus:
                                skillDat.Param_6 = 1;
                                break;
                        }

                        break;
                    }
                    case Armor.Entries armor: {
                        switch (armor.Index) {
                            case ArmorDataValueClass.Guildwork_Head_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Effluvial_Expert;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Scholar;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Aquatic_Polar_Mobility;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Kushala_Cista_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Bow_Charge_Plus;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Coldproof;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Defense_Boost;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Kirin_Longarms_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Effluvia_Resistance;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Focus;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Free_Meal;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Fellshroud_Coil_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Guard;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Guard_Up;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Heat_Guard;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Rimeguard_Greaves_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Hunger_Resistance;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Maximum_Might;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Mind_s_Eye_Ballistics;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Critical_Charm_II:
                                armor.Skill_1       = SkillDataValueClass.Non_elemental_Boost;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Power_Prolonger;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Quick_Sheath;
                                armor.Skill_3_Level = 10;
                                break;
                            // Gathering Set
                            case ArmorDataValueClass.Guildwork_Body_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Cliffhanger;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Quick_Sheath;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Recovery_Speed;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Guildwork_Braces_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Honey_Hunter;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Master_Gatherer;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Pro_Transporter;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Guildwork_Waist_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Scoutfly_Range_Up;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Coldproof;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Heat_Guard;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Guildwork_Feet_a_plus:
                                armor.Skill_1       = SkillDataValueClass.Hunger_Resistance;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Item_Prolonger;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Paralysis_Resistance;
                                armor.Skill_3_Level = 10;
                                break;
                            case ArmorDataValueClass.Tremor_Charm_III:
                                armor.Skill_1       = SkillDataValueClass.Forager_s_Luck;
                                armor.Skill_1_Level = 10;
                                armor.Skill_2       = SkillDataValueClass.Detector;
                                armor.Skill_2_Level = 10;
                                armor.Skill_3       = SkillDataValueClass.Scenthound;
                                armor.Skill_3_Level = 10;
                                break;
                        }

                        break;
                    }
                }
            }
        }

        private void Btn_slot_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Armor),
                                   typeof(ASkill),
                                   typeof(IWeapon))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case ISlots slotItem: {
                        slotItem.Slot_Count  = 3;
                        slotItem.Slot_1_Size = 4;
                        slotItem.Slot_2_Size = 4;
                        slotItem.Slot_3_Size = 4;

                        break;
                    }
                    case ASkill.Entries aSkill: {
                        aSkill.Deco_Count = 2;
                        aSkill.Deco_Lvl_1 = 4;
                        aSkill.Deco_Lvl_2 = 4;

                        break;
                    }
                }
            }
        }

        private void Btn_set_bonus_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Armor))) return;

            foreach (Armor.Entries item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                if (item.Set_Skill_1_Level > 0) item.Set_Skill_1_Level = 5;
            }
        }

        private void Btn_skill_level_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Armor),
                                   typeof(Gem))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case Gem.Entries gem: {
                        gem.Skill_1_Level = 10;
                        if (gem.Skill_2_Level > 0) gem.Skill_2_Level = 10;
                        break;
                    }
                    case Armor.Entries armor: {
                        if (armor.Skill_1_Level > 0) armor.Skill_1_Level = 10;
                        if (armor.Skill_2_Level > 0) armor.Skill_2_Level = 10;
                        if (armor.Skill_3_Level > 0) armor.Skill_3_Level = 10;
                        break;
                    }
                }
            }
        }

        private void Btn_cost_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Armor),
                                   typeof(CustomOuterRecipe),
                                   typeof(CustomParts),
                                   typeof(CustomPartsR),
                                   typeof(EqCrt),
                                   typeof(EqCus),
                                   typeof(Item),
                                   typeof(IWeapon),
                                   typeof(NewLimitBreak),
                                   typeof(NewLimitBreakR),
                                   typeof(RodInsect))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case Item.Entries itm: {
                        if (itm.Buy_Price > 0) itm.Buy_Price = 1;
                        break;
                    }
                    case Armor.Entries armor: {
                        if (armor.Cost > 0) armor.Cost = 1;
                        break;
                    }
                    case IWeapon weapon: {
                        if (weapon.Cost > 0) weapon.Cost = 1;
                        break;
                    }
                    case EqCrt.Entries eqCrt: {
                        if (eqCrt.Mat_1_Count > 0) eqCrt.Mat_1_Count = 1;
                        if (eqCrt.Mat_2_Count > 0) eqCrt.Mat_2_Count = 1;
                        if (eqCrt.Mat_3_Count > 0) eqCrt.Mat_3_Count = 1;
                        if (eqCrt.Mat_4_Count > 0) eqCrt.Mat_4_Count = 1;
                        break;
                    }
                    case EqCus.Entries eqCus: {
                        if (eqCus.Mat_1_Count > 0) eqCus.Mat_1_Count = 1;
                        if (eqCus.Mat_2_Count > 0) eqCus.Mat_2_Count = 1;
                        if (eqCus.Mat_3_Count > 0) eqCus.Mat_3_Count = 1;
                        if (eqCus.Mat_4_Count > 0) eqCus.Mat_4_Count = 1;
                        break;
                    }
                    case NewLimitBreakR.Entries newLimitBreakRecipe: {
                        if (newLimitBreakRecipe.Mat_1_Count > 0) newLimitBreakRecipe.Mat_1_Count = 1;
                        if (newLimitBreakRecipe.Mat_2_Count > 0) newLimitBreakRecipe.Mat_2_Count = 1;
                        if (newLimitBreakRecipe.Mat_3_Count > 0) newLimitBreakRecipe.Mat_3_Count = 1;
                        if (newLimitBreakRecipe.Mat_4_Count > 0) newLimitBreakRecipe.Mat_4_Count = 1;
                        break;
                    }
                    case NewLimitBreak.Entries newLimitBreak: {
                        if (newLimitBreak.Research_Cost_r10_ > 0) newLimitBreak.Research_Cost_r10_ = 1;
                        if (newLimitBreak.Research_Cost_r11_ > 0) newLimitBreak.Research_Cost_r11_ = 1;
                        if (newLimitBreak.Research_Cost_r12_ > 0) newLimitBreak.Research_Cost_r12_ = 1;
                        if (newLimitBreak.Aug_Slot_Cost > 1) newLimitBreak.Aug_Slot_Cost           = 1;
                        break;
                    }
                    case CustomParts.Entries customParts: {
                        if (customParts.Craft_Cost > 0) customParts.Craft_Cost = 1;
                        break;
                    }
                    case CustomPartsR.Entries customPartsRecipe: {
                        if (customPartsRecipe.Mat_1_Count > 0) customPartsRecipe.Mat_1_Count = 1;
                        if (customPartsRecipe.Mat_2_Count > 0) customPartsRecipe.Mat_2_Count = 1;
                        if (customPartsRecipe.Mat_3_Count > 0) customPartsRecipe.Mat_3_Count = 1;
                        if (customPartsRecipe.Mat_4_Count > 0) customPartsRecipe.Mat_4_Count = 1;
                        break;
                    }
                    case RodInsect.Entries rodInsect: {
                        if (rodInsect.Craft_Cost > 0) rodInsect.Craft_Cost = 1;
                        break;
                    }
                    case CustomOuterRecipe.Entries recipe: {
                        if (recipe.Cost > 0) recipe.Cost               = 1;
                        if (recipe.Mat_1_Count > 0) recipe.Mat_1_Count = 1;
                        if (recipe.Mat_2_Count > 0) recipe.Mat_2_Count = 1;
                        if (recipe.Mat_3_Count > 0) recipe.Mat_3_Count = 1;
                        if (recipe.Mat_4_Count > 0) recipe.Mat_4_Count = 1;
                        break;
                    }
                }
            }
        }

        private void Btn_damage_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(IWeapon),
                                   typeof(OtomoWeaponDat))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case OtomoWeaponDat.Entries palicoWeapon: {
                        if (palicoWeapon.Melee_Damage > 0) palicoWeapon.Melee_Damage   = 50000;
                        if (palicoWeapon.Ranged_Damage > 0) palicoWeapon.Ranged_Damage = 50000;
                        break;
                    }
                    case IWeapon weapon: {
                        if (weapon.Damage > 0) weapon.Damage = 50000;
                        break;
                    }
                }
            }
        }

        private void Btn_enable_all_coatings_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(BottleTable))) return;

            foreach (BottleTable.Entries item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                item.Close_Range = CoatingType.Plus;
                item.Power       = CoatingType.Plus;
                item.Paralysis   = CoatingType.Plus;
                item.Poison      = CoatingType.Plus;
                item.Sleep       = CoatingType.Plus;
                item.Blast       = CoatingType.Plus;
            }
        }

        private void Btn_max_sharpness_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Melee),
                                   typeof(Sharpness))) {
                return;
            }

            foreach (var item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                switch (item) {
                    case Sharpness.Entries sharpness: {
                        sharpness.Red    = 1;
                        sharpness.Orange = 1;
                        sharpness.Yellow = 1;
                        sharpness.Green  = 1;
                        sharpness.Blue   = 1;
                        sharpness.White  = 1;
                        sharpness.Purple = 400;
                        break;
                    }
                    case Melee.Entries weapon: {
                        if (weapon.Sharpness_Amount > 0) weapon.Sharpness_Amount = 5;
                        break;
                    }
                }
            }
        }

        private void Btn_unlock_skill_limit_cheat_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(SkillDat))) return;

            foreach (SkillDat.Entries item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                item.Unlock_Skill_1 = 0;
                item.Unlock_Skill_2 = 0;
                item.Unlock_Skill_3 = 0;
                item.Unlock_Skill_4 = 0;
            }
        }

        private void Btn_fast_reload_rapid_fire_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(ShellTable))) return;

            const int reloadSpeed  = 17;
            const int recoilAmount = 29;

            foreach (ShellTable.Entries item in fileData.GetAllEnumerableOfType<IMhwStructItem>()) {
                item.Normal_1_Rel_Spd  = reloadSpeed;
                item.Normal_1_Rec_Amnt = recoilAmount;
                item.Normal_2_Rel_Spd  = reloadSpeed;
                item.Normal_2_Rec_Amnt = recoilAmount;
                item.Normal_3_Rel_Spd  = reloadSpeed;
                item.Normal_3_Rec_Amnt = recoilAmount;
                item.Pierce_1_Rel_Spd  = reloadSpeed;
                item.Pierce_1_Rec_Amnt = recoilAmount;
                item.Pierce_2_Rel_Spd  = reloadSpeed;
                item.Pierce_2_Rec_Amnt = recoilAmount;
                item.Pierce_3_Rel_Spd  = reloadSpeed;
                item.Pierce_3_Rec_Amnt = recoilAmount;
                item.Spread_1_Rel_Spd  = reloadSpeed;
                item.Spread_1_Rec_Amnt = recoilAmount;
                item.Spread_2_Rel_Spd  = reloadSpeed;
                item.Spread_2_Rec_Amnt = recoilAmount;
                item.Spread_3_Rel_Spd  = reloadSpeed;
                item.Spread_3_Rec_Amnt = recoilAmount;
                item.Cluster_1_Rel_Spd = reloadSpeed;
                //item.Cluster_1_Rec_Amnt = recoilAmount;
                item.Cluster_2_Rel_Spd = reloadSpeed;
                //item.Cluster_2_Rec_Amnt = recoilAmount;
                item.Cluster_3_Rel_Spd = reloadSpeed;
                //item.Cluster_3_Rec_Amnt = recoilAmount;
                item.Wyvern_Rel_Spd = reloadSpeed;
                //item.Wyvern_Rec_Amnt = recoilAmount;
                item.Sticky_1_Rel_Spd     = reloadSpeed;
                item.Sticky_1_Rec_Amnt    = recoilAmount;
                item.Sticky_2_Rel_Spd     = reloadSpeed;
                item.Sticky_2_Rec_Amnt    = recoilAmount;
                item.Sticky_3_Rel_Spd     = reloadSpeed;
                item.Sticky_3_Rec_Amnt    = recoilAmount;
                item.Slicing_Rel_Spd      = reloadSpeed;
                item.Slicing_Rec_Amnt     = recoilAmount;
                item.Flaming_Rel_Spd      = reloadSpeed;
                item.Flaming_Rec_Amnt     = recoilAmount;
                item.Water_Rel_Spd        = reloadSpeed;
                item.Water_Rec_Amnt       = recoilAmount;
                item.Freeze_Rel_Spd       = reloadSpeed;
                item.Freeze_Rec_Amnt      = recoilAmount;
                item.Thunder_Rel_Spd      = reloadSpeed;
                item.Thunder_Rec_Amnt     = recoilAmount;
                item.Dragon_Rel_Spd       = reloadSpeed;
                item.Dragon_Rec_Amnt      = recoilAmount;
                item.Poison_1_Rel_Spd     = reloadSpeed;
                item.Poison_1_Rec_Amnt    = recoilAmount;
                item.Poison_2_Rel_Spd     = reloadSpeed;
                item.Poison_2_Rec_Amnt    = recoilAmount;
                item.Paralysis_1_Rel_Spd  = reloadSpeed;
                item.Paralysis_1_Rec_Amnt = recoilAmount;
                item.Paralysis_2_Rel_Spd  = reloadSpeed;
                item.Paralysis_2_Rec_Amnt = recoilAmount;
                item.Sleep_1_Rel_Spd      = reloadSpeed;
                item.Sleep_1_Rec_Amnt     = recoilAmount;
                item.Sleep_2_Rel_Spd      = reloadSpeed;
                item.Sleep_2_Rec_Amnt     = recoilAmount;
                item.Exhaust_1_Rel_Spd    = reloadSpeed;
                item.Exhaust_1_Rec_Amnt   = recoilAmount;
                item.Exhaust_2_Rel_Spd    = reloadSpeed;
                item.Exhaust_2_Rec_Amnt   = recoilAmount;
                item.Recover_1_Rel_Spd    = reloadSpeed;
                item.Recover_1_Rec_Amnt   = recoilAmount;
                item.Recover_2_Rel_Spd    = reloadSpeed;
                item.Recover_2_Rec_Amnt   = recoilAmount;
                item.Demon_Rel_Spd        = reloadSpeed;
                item.Demon_Rec_Amnt       = recoilAmount;
                item.Armor_Rel_Spd        = reloadSpeed;
                item.Armor_Rec_Amnt       = recoilAmount;
                item.Tranq_Rel_Spd        = reloadSpeed;
                item.Tranq_Rec_Amnt       = recoilAmount;
            }
        }

        private void Btn_sort_jewel_order_by_name_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!targetFileType.Is(typeof(Item))) return;

            var rawList = new List<GemData>();
            var items   = fileData.GetStructList<Item.Entries>();

            foreach (var itemId in DataHelper.gemItemIds) {
                var item = items[(int) itemId];
                rawList.Add(new GemData {index = itemId, itemName = item.Name, sortOrder = item.Sort_Order});
            }

            // One list of the sorted "sortOrder"s.
            var sortedSortIndexes = new List<GemData>(rawList)
                                    .OrderBy(data => data.sortOrder)
                                    .Select(data => data.sortOrder)
                                    .ToList();
            // And another list of item indexes, sorted by gem name.
            var sortedGemNameIndexes = new List<GemData>(rawList)
                                       .OrderBy(data => data.itemName)
                                       .Select(data => data.index)
                                       .ToList();

            for (var i = 0; i < sortedSortIndexes.Count; i++) {
                var index        = sortedGemNameIndexes[i];
                var newSortIndex = sortedSortIndexes[i];
                var item         = items[(int) index];
                item.Sort_Order = newSortIndex;
            }
        }

        private void Btn_open_wiki_OnClick(object sender, RoutedEventArgs e) {
            try {
                Process.Start("https://github.com/Synthlight/MHW-Editor/wiki");
            } catch (Exception err) {
                Console.Error.WriteLine(err);
            }
        }
    }
}