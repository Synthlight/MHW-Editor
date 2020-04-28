using System;
using System.Collections.Generic;
using MHW_Editor.Armors;
using MHW_Editor.Gems;
using MHW_Editor.GuildCard;
using MHW_Editor.Items;
using MHW_Editor.Items.TimeGate.Models;
using MHW_Editor.Monsters;
using MHW_Editor.Skills;
using MHW_Editor.Weapons;
using Armor = MHW_Editor.Items.TimeGate.Models.Armor;

namespace MHW_Editor {
    public static class ButtonTypeInfo {
        public static readonly List<string> TYPES_WITH_BUTTONS = new List<string> {
            "Ammo_Box",
            "Armor",
            "ASkill",
            "AwakenedLimitBreak",
            "Bounty",
            "Bow",
            "BowGun",
            "CustomOuterRecipe",
            "CustomPartsR",
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
            "Item_Box",
            "ItemDelivery",
            "ItemList",
            "ItemLottery",
            "ItemMake",
            "ItemTg",
            "KulveItemLottery",
            "LimitBreakMaterialBase",
            "LimitBreakMaterialSkill",
            "MelderExchange",
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
            "SafiItemLottery",
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
            "armorId_button",
            "Decoration_Reward_button",
            "Equip_Id_button",
            "Equipment_Index_button",
            "Hidden_Skill_button",
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
            "Mantle_Item_Id_button",
            "Mat_1_Id_button",
            "Mat_2_Id_button",
            "Mat_3_Id_button",
            "Mat_4_Id_button",
            "Monster_Id_button",
            "Monster_Unlock_button",
            "Needed_Item_Id_to_Unlock_button",
            "pendantId_button",
            "Result_Id_button",
            "Result_Item_Id_button",
            "Set_Skill_1_button",
            "Skill_1_button",
            "Skill_2_button",
            "Skill_3_button",
            "Skill_button",
            "Skill_Id_button",
            "Source_Item_Id_button",
            "Unlock_Skill_1_button",
            "Unlock_Skill_2_button",
            "Unlock_Skill_3_button",
            "Unlock_Skill_4_button",
            "Weapon_Id_button",
            "weaponId_button",
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
            {typeof(MHW_Editor.Items.KulveItemLottery), new List<string> {
                "Weapon_Id",
            }},
            {typeof(MHW_Editor.Items.MelderExchange), new List<string> {
                "Source_Item_Id",
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
            {typeof(MHW_Editor.Gems.Gem), new List<string> {
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
        };
    }
}