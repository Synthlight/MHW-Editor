using System;
using System.Collections.Generic;

namespace MHW_Editor {
    public static class ButtonTypeInfo {
        public static readonly List<string> TYPES_WITH_BUTTONS = new List<string> {
            "Ammo",
            "Ammo_Box",
            "Armor",
            "Armors",
            "ASkill",
            "AwakenedLimitBreak",
            "Bounty",
            "Bow",
            "BowGun",
            "CustomOuterRecipe",
            "CustomPartsR",
            "DecoGradeLottery",
            "DecoLottery",
            "Decorations",
            "Entries",
            "EqCrt_Armor",
            "EqCrt_Base",
            "EqCrt_Charm",
            "EqCrt_Palico",
            "EqCrt_Weapon",
            "EqCus_Armor",
            "EqCus_Base",
            "EqCus_Misc",
            "EqCus_Weapon",
            "GcData",
            "GcData_Backgrounds",
            "GcData_Expressions",
            "GcData_Poses",
            "GcData_Title1",
            "GcData_Title2",
            "Gem",
            "GunnerReload",
            "GunnerShoot",
            "Item_Box",
            "ItemDelivery",
            "ItemList",
            "ItemLottery",
            "ItemMake",
            "Items",
            "ItemTg",
            "KulveGradeLottery",
            "KulveItemLottery",
            "LimitBreakMaterialBase",
            "LimitBreakMaterialSkill",
            "Mantles",
            "MelderItem",
            "Melee",
            "Monster_Rage",
            "Monster_Stamina_1_",
            "Monsters",
            "NewLimitBreakR",
            "Pendant",
            "PlantItem",
            "QuestRewardInternal",
            "Ranged",
            "RoomFurniture",
            "SafiItemGradeLottery",
            "SafiItemLottery",
            "ShellTable",
            "ShopSed",
            "Size_Settings",
            "SkillDat",
            "SteamRewardList",
            "SwapItem",
            "SwapN",
            "Treasure",
            "ValueTrader",
            "Weapon",
        };

        public static readonly List<string> BUTTON_NAMES = new List<string> {
            "Ammo_Id_button",
            "Armor_Id_button",
            "Armor_Rec_Amnt_button",
            "Armor_Rel_Spd_button",
            "armorId_button",
            "Cluster_1_Rec_Amnt_button",
            "Cluster_1_Rel_Spd_button",
            "Cluster_2_Rec_Amnt_button",
            "Cluster_2_Rel_Spd_button",
            "Cluster_3_Rec_Amnt_button",
            "Cluster_3_Rel_Spd_button",
            "Deco_1_button",
            "Deco_2_button",
            "Deco_3_button",
            "Decoration_Reward_button",
            "Demon_Rec_Amnt_button",
            "Demon_Rel_Spd_button",
            "Dragon_Rec_Amnt_button",
            "Dragon_Rel_Spd_button",
            "Equip_Id_button",
            "Equipment_Index_button",
            "Exhaust_1_Rec_Amnt_button",
            "Exhaust_1_Rel_Spd_button",
            "Exhaust_2_Rec_Amnt_button",
            "Exhaust_2_Rel_Spd_button",
            "Flaming_Rec_Amnt_button",
            "Flaming_Rel_Spd_button",
            "Freeze_Rec_Amnt_button",
            "Freeze_Rel_Spd_button",
            "Hidden_Skill_button",
            "Id_button",
            "Item_1_Id_button",
            "Item_10_Id_button",
            "Item_2_Id_button",
            "Item_3_Id_button",
            "Item_4_Id_button",
            "Item_5_Id_button",
            "Item_6_Id_button",
            "Item_7_Id_button",
            "Item_8_Id_button",
            "Item_9_Id_button",
            "Item_button",
            "Item_Id_1_button",
            "Item_Id_2_button",
            "Item_Id_3_button",
            "Item_Id_button",
            "itemId_button",
            "Mantle_Id_button",
            "Mantle_Item_Id_button",
            "Mat_1_Id_button",
            "Mat_2_Id_button",
            "Mat_3_Id_button",
            "Mat_4_Id_button",
            "Mod_1_button",
            "Mod_2_button",
            "Mod_3_button",
            "Mod_4_button",
            "Monster_Id_button",
            "Monster_Unlock_button",
            "Needed_Item_Id_to_Unlock_button",
            "No_Mods_button",
            "Normal_1_Rec_Amnt_button",
            "Normal_1_Rel_Spd_button",
            "Normal_2_Rec_Amnt_button",
            "Normal_2_Rel_Spd_button",
            "Normal_3_Rec_Amnt_button",
            "Normal_3_Rel_Spd_button",
            "Paralysis_1_Rec_Amnt_button",
            "Paralysis_1_Rel_Spd_button",
            "Paralysis_2_Rec_Amnt_button",
            "Paralysis_2_Rel_Spd_button",
            "pendantId_button",
            "Pierce_1_Rec_Amnt_button",
            "Pierce_1_Rel_Spd_button",
            "Pierce_2_Rec_Amnt_button",
            "Pierce_2_Rel_Spd_button",
            "Pierce_3_Rec_Amnt_button",
            "Pierce_3_Rel_Spd_button",
            "Poison_1_Rec_Amnt_button",
            "Poison_1_Rel_Spd_button",
            "Poison_2_Rec_Amnt_button",
            "Poison_2_Rel_Spd_button",
            "Recover_1_Rec_Amnt_button",
            "Recover_1_Rel_Spd_button",
            "Recover_2_Rec_Amnt_button",
            "Recover_2_Rel_Spd_button",
            "Result_Id_button",
            "Result_Item_Id_button",
            "Set_Skill_1_button",
            "Skill_1_button",
            "Skill_2_button",
            "Skill_3_button",
            "Skill_button",
            "Skill_Id_button",
            "Sleep_1_Rec_Amnt_button",
            "Sleep_1_Rel_Spd_button",
            "Sleep_2_Rec_Amnt_button",
            "Sleep_2_Rel_Spd_button",
            "Slicing_Rec_Amnt_button",
            "Slicing_Rel_Spd_button",
            "Source_Item_Id_button",
            "Spread_1_Rec_Amnt_button",
            "Spread_1_Rel_Spd_button",
            "Spread_2_Rec_Amnt_button",
            "Spread_2_Rel_Spd_button",
            "Spread_3_Rec_Amnt_button",
            "Spread_3_Rel_Spd_button",
            "Sticky_1_Rec_Amnt_button",
            "Sticky_1_Rel_Spd_button",
            "Sticky_2_Rec_Amnt_button",
            "Sticky_2_Rel_Spd_button",
            "Sticky_3_Rec_Amnt_button",
            "Sticky_3_Rel_Spd_button",
            "Thunder_Rec_Amnt_button",
            "Thunder_Rel_Spd_button",
            "Tranq_Rec_Amnt_button",
            "Tranq_Rel_Spd_button",
            "Unlock_Skill_1_button",
            "Unlock_Skill_2_button",
            "Unlock_Skill_3_button",
            "Unlock_Skill_4_button",
            "Water_Rec_Amnt_button",
            "Water_Rel_Spd_button",
            "Weapon_Id_button",
            "weaponId_button",
            "Wyvern_Rec_Amnt_button",
            "Wyvern_Rel_Spd_button",
        };

        public static readonly Dictionary<Type, List<string>> TYPE_AND_NAME = new Dictionary<Type, List<string>> {
            {typeof(MHW_Editor.Weapons.AwakenedLimitBreak), new List<string> {
                "Skill_Id",
            }},
            {typeof(MHW_Editor.Weapons.CustomOuterRecipe), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Weapons.CustomPartsR), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Weapons.GunnerReload), new List<string> {
                "No_Mods",
                "Mod_1",
                "Mod_2",
                "Mod_3",
                "Mod_4",
            }},
            {typeof(MHW_Editor.Weapons.GunnerShoot), new List<string> {
                "No_Mods",
                "Mod_1",
                "Mod_2",
                "Mod_3",
                "Mod_4",
            }},
            {typeof(MHW_Editor.Weapons.LimitBreakMaterialBase), new List<string> {
                "Item_1_Id",
                "Item_2_Id",
            }},
            {typeof(MHW_Editor.Weapons.LimitBreakMaterialSkill), new List<string> {
                "Item_1_Id",
            }},
            {typeof(MHW_Editor.Weapons.NewLimitBreakR), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Weapons.ShellTable), new List<string> {
                "Normal_1_Rec_Amnt",
                "Normal_1_Rel_Spd",
                "Normal_2_Rec_Amnt",
                "Normal_2_Rel_Spd",
                "Normal_3_Rec_Amnt",
                "Normal_3_Rel_Spd",
                "Pierce_1_Rec_Amnt",
                "Pierce_1_Rel_Spd",
                "Pierce_2_Rec_Amnt",
                "Pierce_2_Rel_Spd",
                "Pierce_3_Rec_Amnt",
                "Pierce_3_Rel_Spd",
                "Spread_1_Rec_Amnt",
                "Spread_1_Rel_Spd",
                "Spread_2_Rec_Amnt",
                "Spread_2_Rel_Spd",
                "Spread_3_Rec_Amnt",
                "Spread_3_Rel_Spd",
                "Cluster_1_Rec_Amnt",
                "Cluster_1_Rel_Spd",
                "Cluster_2_Rec_Amnt",
                "Cluster_2_Rel_Spd",
                "Cluster_3_Rec_Amnt",
                "Cluster_3_Rel_Spd",
                "Wyvern_Rec_Amnt",
                "Wyvern_Rel_Spd",
                "Sticky_1_Rec_Amnt",
                "Sticky_1_Rel_Spd",
                "Sticky_2_Rec_Amnt",
                "Sticky_2_Rel_Spd",
                "Sticky_3_Rec_Amnt",
                "Sticky_3_Rel_Spd",
                "Slicing_Rec_Amnt",
                "Slicing_Rel_Spd",
                "Flaming_Rec_Amnt",
                "Flaming_Rel_Spd",
                "Water_Rec_Amnt",
                "Water_Rel_Spd",
                "Freeze_Rec_Amnt",
                "Freeze_Rel_Spd",
                "Thunder_Rec_Amnt",
                "Thunder_Rel_Spd",
                "Dragon_Rec_Amnt",
                "Dragon_Rel_Spd",
                "Poison_1_Rec_Amnt",
                "Poison_1_Rel_Spd",
                "Poison_2_Rec_Amnt",
                "Poison_2_Rel_Spd",
                "Paralysis_1_Rec_Amnt",
                "Paralysis_1_Rel_Spd",
                "Paralysis_2_Rec_Amnt",
                "Paralysis_2_Rel_Spd",
                "Sleep_1_Rec_Amnt",
                "Sleep_1_Rel_Spd",
                "Sleep_2_Rec_Amnt",
                "Sleep_2_Rel_Spd",
                "Exhaust_1_Rec_Amnt",
                "Exhaust_1_Rel_Spd",
                "Exhaust_2_Rec_Amnt",
                "Exhaust_2_Rel_Spd",
                "Recover_1_Rec_Amnt",
                "Recover_1_Rel_Spd",
                "Recover_2_Rec_Amnt",
                "Recover_2_Rel_Spd",
                "Demon_Rec_Amnt",
                "Demon_Rel_Spd",
                "Armor_Rec_Amnt",
                "Armor_Rel_Spd",
                "Tranq_Rec_Amnt",
                "Tranq_Rel_Spd",
            }},
            {typeof(MHW_Editor.Weapons.Melee), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Weapons.Ranged), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Weapons.Bow), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Weapons.BowGun), new List<string> {
                "Skill",
            }},
            {typeof(MHW_Editor.Skills.SkillDat), new List<string> {
                "Unlock_Skill_1",
                "Unlock_Skill_2",
                "Unlock_Skill_3",
                "Unlock_Skill_4",
            }},
            {typeof(MHW_Editor.Items.EqCrt_Base), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCus_Base), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.ItemDelivery), new List<string> {
                "Decoration_Reward",
                "Item_1_Id",
                "Item_2_Id",
            }},
            {typeof(MHW_Editor.Items.ItemList), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.ItemLottery), new List<string> {
                "Item_1_Id",
                "Item_2_Id",
                "Item_3_Id",
                "Item_4_Id",
                "Item_5_Id",
                "Item_6_Id",
                "Item_7_Id",
                "Item_8_Id",
                "Item_9_Id",
                "Item_10_Id",
            }},
            {typeof(MHW_Editor.Items.ItemMake), new List<string> {
                "Mat_1_Id",
                "Mat_2_Id",
                "Result_Id",
            }},
            {typeof(MHW_Editor.Items.KulveGradeLottery), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.KulveItemLottery), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Items.MelderItem), new List<string> {
                "Result_Item_Id",
            }},
            {typeof(MHW_Editor.Items.Bounty), new List<string> {
                "Item_Id_1",
                "Item_Id_2",
                "Item_Id_3",
            }},
            {typeof(MHW_Editor.Items.PlantItem), new List<string> {
                "Item",
            }},
            {typeof(MHW_Editor.Items.RoomFurniture), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SafiItemGradeLottery), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SafiItemLottery), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Items.ShopSed), new List<string> {
                "Equip_Id",
            }},
            {typeof(MHW_Editor.Items.SteamRewardList), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SwapItem), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SwapN), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.Treasure), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.ValueTrader), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.EqCus_Weapon), new List<string> {
                "Equipment_Index",
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCus_Misc), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCus_Armor), new List<string> {
                "Equipment_Index",
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCrt_Palico), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCrt_Charm), new List<string> {
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCrt_Weapon), new List<string> {
                "Equipment_Index",
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.EqCrt_Armor), new List<string> {
                "Equipment_Index",
                "Needed_Item_Id_to_Unlock",
                "Monster_Unlock",
                "Mat_1_Id",
                "Mat_2_Id",
                "Mat_3_Id",
                "Mat_4_Id",
            }},
            {typeof(MHW_Editor.Items.TimeGate.Models.Armor), new List<string> {
                "armorId",
            }},
            {typeof(MHW_Editor.Items.TimeGate.Models.Pendant), new List<string> {
                "pendantId",
            }},
            {typeof(MHW_Editor.Items.TimeGate.Models.ItemTg), new List<string> {
                "itemId",
            }},
            {typeof(MHW_Editor.Items.TimeGate.Models.Weapon), new List<string> {
                "weaponId",
            }},
            {typeof(MHW_Editor.GuildCard.GcData), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.GuildCard.GcData_Poses), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.GuildCard.GcData_Expressions), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.GuildCard.GcData_Title2), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.GuildCard.GcData_Title1), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.GuildCard.GcData_Backgrounds), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Gems.DecoGradeLottery), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Gems.DecoLottery), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Gems.Gem), new List<string> {
                "Id",
                "Skill_1",
                "Skill_2",
            }},
            {typeof(MHW_Editor.Armors.Armor), new List<string> {
                "Set_Skill_1",
                "Hidden_Skill",
                "Skill_1",
                "Skill_2",
                "Skill_3",
            }},
            {typeof(MHW_Editor.Armors.ASkill), new List<string> {
                "Mantle_Item_Id",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Monsters.MonsterEnrage.Monster_Rage), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Monsters.MonsterRandomSize.Monsters), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Monsters.SmallMonsterSizeParams.Size_Settings), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Monsters.MonsterStamina.Monster_Stamina_1_), new List<string> {
                "Monster_Id",
            }},
            {typeof(MHW_Editor.Items.MelderExchange.Item_Box), new List<string> {
                "Source_Item_Id",
            }},
            {typeof(MHW_Editor.Items.QuestReward.QuestRewardInternal), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.ShopList.Entries), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SupplyData.Item_Box), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Items.SupplyData.Ammo_Box), new List<string> {
                "Ammo_Id",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries.Armors), new List<string> {
                "Armor_Id",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries.Mantles), new List<string> {
                "Mantle_Id",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries.Decorations), new List<string> {
                "Deco_1",
                "Deco_2",
                "Deco_3",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries.Items), new List<string> {
                "Item_Id",
            }},
            {typeof(MHW_Editor.Weapons.ArenaEquipment.Entries.Ammo), new List<string> {
                "Ammo_Id",
            }},
            {typeof(MHW_Editor.Items.MelderExchange.Item_Box.Items), new List<string> {
                "Item_Id",
            }},
        };
    }
}