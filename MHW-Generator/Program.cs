using System;
using System.Collections.Generic;
using System.IO;
using MHW_Template;
using MHW_Template.Armors;
using MHW_Template.Items;
using MHW_Template.Models;
using MHW_Template.Weapons;
using MHW_Template.Weapons.Model;

namespace MHW_Generator {
    public static class Program {
        [STAThread]
        public static void Main() {
            GenItem();
            GenBottleTable();
            GenArmUp();
            GenGem();
            GenSkillDat();
            GenArmor();
            GenMelee();
            GenRanged();
            GenSharpness();
            GenShellTable();
            GenNewLimitBreakR();
            GenNewLimitBreak();
            GenWeaponWSword();
            GenWeaponWhistle();
            GenWeaponGunLance();
            GenWeaponSwitchAxe();
            GenSkillPointData();
            GenASkill();
            GenEqCrt();
            GenEqCus();
            GenPlantFertilizer();
            GenPlantItem();
            GenOtomoWeaponDat();
            GenOtomoArmorDat();
            GenDecoLottery();
            GenDecoGradeLottery();
            GenMusicSkill();
            GenMelderItem();
            GenMelderExchange();
            GenRodInsect();
            GenCustomParts();
            GenCustomPartsR();
            GenShopSed();
            GenCharmDat();
            GenGunnerReload();
            GenGunnerShoot();
            GenItemMake();
            GenItemList();
            GenSwapItem();
            GenSwapEnemyRate();
            GenSwapN();
            GenSwapC();
            GenTreasure();
            GenValueTrader();
            GenOdr();
            GenQuestReward();
        }

        private static void GenQuestReward() {
            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Id", 0, typeof(uint), true)
            };

            const ulong itemIdStart = 8;
            const ulong itemCountStart = 72;
            const ulong itemWeightStart = 88;

            for (ulong i = 0; i <= 15; i++) {
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Id", itemIdStart + i * 4, typeof(uint)));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Cnt", itemCountStart + i, typeof(byte)));
                entries.Add(new MhwStructData.Entry($"Item {i + 1} Wt", itemWeightStart + i, typeof(byte)));
            }

            GenerateItemProps("MHW_Editor.Items", "QuestReward", new MhwStructData { // .odr
                size = 104,
                offsetInitial = 10,
                entryCountOffset = -1,
                uniqueIdFormula = "{Id}",
                entries = entries
            });
        }

        private static void GenOdr() {
            GenerateItemProps("MHW_Editor.Items", "Odr", new MhwStructData { // .odr
                size = 77,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 9, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 13, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 17, typeof(int)),
                    new MhwStructData.Entry("Unk6", 21, typeof(uint)),
                    new MhwStructData.Entry("Unk7", 25, typeof(uint)),
                    new MhwStructData.Entry("Unk8", 29, typeof(uint)),
                    new MhwStructData.Entry("Unk9", 33, typeof(int)),
                    new MhwStructData.Entry("Unk10", 37, typeof(uint)),
                    new MhwStructData.Entry("Unk11", 41, typeof(uint)),
                    new MhwStructData.Entry("Unk12", 45, typeof(uint)),
                    new MhwStructData.Entry("Unk13", 49, typeof(uint)),
                    new MhwStructData.Entry("Unk14", 53, typeof(uint)),
                    new MhwStructData.Entry("Unk15", 57, typeof(uint)),
                    new MhwStructData.Entry("Unk16", 61, typeof(uint)),
                    new MhwStructData.Entry("Unk17", 65, typeof(uint)),
                    new MhwStructData.Entry("Unk18", 69, typeof(uint)),
                    new MhwStructData.Entry("Unk19", 72, typeof(uint))
                }
            });
        }

        private static void GenValueTrader() {
            GenerateItemProps("MHW_Editor.Items", "ValueTrader", new MhwStructData { // .trdr
                size = 56,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk3", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 16, typeof(uint)),
                    new MhwStructData.Entry("Unk6", 20, typeof(uint)),
                    new MhwStructData.Entry("Unk7", 24, typeof(uint)),
                    new MhwStructData.Entry("Unk8", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk9", 32, typeof(uint)),
                    new MhwStructData.Entry("Unk10", 36, typeof(uint)),
                    new MhwStructData.Entry("Unk11", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk12", 44, typeof(uint)),
                    new MhwStructData.Entry("Unk13", 48, typeof(uint)),
                    new MhwStructData.Entry("Unk14", 52, typeof(uint))
                }
            });
        }

        private static void GenTreasure() {
            GenerateItemProps("MHW_Editor.Items", "Treasure", new MhwStructData { // .trsr
                size = 56,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 12, typeof(uint)),
                    new MhwStructData.Entry("Unk5", 16, typeof(uint)),
                    new MhwStructData.Entry("Unk6", 20, typeof(uint)),
                    new MhwStructData.Entry("Unk7", 24, typeof(uint)),
                    new MhwStructData.Entry("Unk8", 28, typeof(uint)),
                    new MhwStructData.Entry("Unk9", 32, typeof(uint)),
                    new MhwStructData.Entry("Unk10", 36, typeof(uint)),
                    new MhwStructData.Entry("Unk11", 40, typeof(uint)),
                    new MhwStructData.Entry("Unk12", 44, typeof(uint)),
                    new MhwStructData.Entry("Unk13", 48, typeof(uint)),
                    new MhwStructData.Entry("Unk14", 52, typeof(uint))
                }
            });
        }

        private static void GenSwapC() {
            GenerateItemProps("MHW_Editor.Items", "SwapC", new MhwStructData { // .swpc
                size = 16,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk3", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk4", 12, typeof(uint))
                }
            });
        }

        private static void GenSwapN() {
            GenerateItemProps("MHW_Editor.Items", "SwapN", new MhwStructData { // .swpn
                size = 12,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint))
                }
            });
        }

        private static void GenSwapEnemyRate() {
            GenerateItemProps("MHW_Editor.Items", "SwapEnemyRate", new MhwStructData { // .swer
                size = 12,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 8, typeof(uint))
                }
            });
        }

        private static void GenSwapItem() {
            GenerateItemProps("MHW_Editor.Items", "SwapItem", new MhwStructData { // .swpi
                size = 26,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 16, typeof(ushort)),
                    new MhwStructData.Entry("Unk3", 18, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 20, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 22, typeof(ushort)),
                    new MhwStructData.Entry("Unk6", 24, typeof(ushort))
                }
            });
        }

        private static void GenItemList() {
            GenerateItemProps("MHW_Editor.Items", "ItemList", new MhwStructData { // .itlist
                size = 8,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Item Id", 0, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Quantity", 4, typeof(uint))
                }
            });
        }

        private static void GenItemMake() {
            GenerateItemProps("MHW_Editor.Items", "ItemMake", new MhwStructData { // .imk
                size = 31,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(ushort)),
                    new MhwStructData.Entry("Mat 1 Id", 6, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Id", 10, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Result Id", 14, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Quantity", 18, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 22, typeof(uint)),
                    new MhwStructData.Entry("Category", 26, typeof(uint), typeof(ItemCategory)),
                    new MhwStructData.Entry("Can Auto-Craft Raw", 30, typeof(byte))
                }
            });
        }

        private static void GenGunnerShoot() {
            GenerateItemProps("MHW_Editor.Weapons", "GunnerShoot", new MhwStructData { // .gun_sd
                size = 5,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("No Mods", 0, typeof(byte)),
                    new MhwStructData.Entry("Mod 1", 1, typeof(byte)),
                    new MhwStructData.Entry("Mod 2", 2, typeof(byte)),
                    new MhwStructData.Entry("Mod 3", 3, typeof(byte)),
                    new MhwStructData.Entry("Mod 4", 4, typeof(byte))
                }
            });
        }

        private static void GenGunnerReload() {
            GenerateItemProps("MHW_Editor.Weapons", "GunnerReload", new MhwStructData { // .gun_rd
                size = 5,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("No Mods", 0, typeof(byte)),
                    new MhwStructData.Entry("Mod 1", 1, typeof(byte)),
                    new MhwStructData.Entry("Mod 2", 2, typeof(byte)),
                    new MhwStructData.Entry("Mod 3", 3, typeof(byte)),
                    new MhwStructData.Entry("Mod 4", 4, typeof(byte))
                }
            });
        }

        private static void GenCharmDat() {
            GenerateItemProps("MHW_Editor.Armors", "CharmDat", new MhwStructData { // .ch_dat
                size = 27,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(byte)),
                    new MhwStructData.Entry("Unk2", 5, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 6, typeof(byte)),
                    new MhwStructData.Entry("Unk4", 7, typeof(byte)),
                    new MhwStructData.Entry("Unk5", 8, typeof(byte)),
                    new MhwStructData.Entry("Unk6", 9, typeof(ushort)),
                    new MhwStructData.Entry("Unk7", 11, typeof(ushort)),
                    new MhwStructData.Entry("Unk8", 13, typeof(byte)),
                    new MhwStructData.Entry("Unk9", 14, typeof(byte)),
                    new MhwStructData.Entry("Cost", 15, typeof(uint)),
                    new MhwStructData.Entry("Unk10", 19, typeof(int))
                }
            });
        }

        private static void GenShopSed() {
            GenerateItemProps("MHW_Editor.Items", "ShopSed", new MhwStructData { // .sed
                size = 12,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Unk1", 0, typeof(uint)),
                    new MhwStructData.Entry("Unk2", 4, typeof(uint)),
                    new MhwStructData.Entry("Story Unlock", 8, typeof(uint))
                }
            });
        }

        private static void GenCustomPartsR() {
            GenerateItemProps("MHW_Editor.Weapons", "CustomPartsR", new MhwStructData { // .cus_par
                size = 51,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.CUS_PAR_KEY,
                uniqueIdFormula = "{Id}|{Weapon_Type}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 1, typeof(uint), true),
                    new MhwStructData.Entry("Weapon Type", 0, typeof(byte), true, typeof(WeaponType)),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 5, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 7, typeof(int)),
                    new MhwStructData.Entry("Mat 1 Id", 15, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 17, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 18, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 20, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 21, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 23, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 24, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 26, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 27, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 29, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 31, typeof(ushort)),
                    new MhwStructData.Entry("Unk6", 33, typeof(ushort)),
                    new MhwStructData.Entry("Unk7", 50, typeof(byte))
                }
            });
        }

        private static void GenCustomParts() {
            GenerateItemProps("MHW_Editor.Weapons", "CustomParts", new MhwStructData { // .cus_pa
                size = 25,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.CUS_PAR_KEY,
                uniqueIdFormula = "{Id}|{Weapon_Type}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Weapon Type", 4, typeof(uint), true, typeof(WeaponType)),
                    new MhwStructData.Entry("Part 1 Id", 8, typeof(uint)),
                    new MhwStructData.Entry("Unk (uint8)", 12, typeof(byte)),
                    new MhwStructData.Entry("Craft Cost", 13, typeof(uint)),
                    new MhwStructData.Entry("Attack", 17, typeof(ushort)),
                    new MhwStructData.Entry("Defense", 19, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 21, typeof(byte)),
                    new MhwStructData.Entry("Element", 22, typeof(byte))
                }
            });
        }

        private static void GenRodInsect() {
            GenerateItemProps("MHW_Editor.Weapons", "RodInsect", new MhwStructData { // .rod_inse
                size = 28,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.ROD_INSE_KEY,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Attack Type", 4, typeof(byte), typeof(AttackType)),
                    new MhwStructData.Entry("Id", 5, typeof(byte), true),
                    new MhwStructData.Entry("Tree Position Id", 6, typeof(byte)),
                    new MhwStructData.Entry("Base Model Id", 7, typeof(ushort)),
                    new MhwStructData.Entry("Tree Id", 9, typeof(byte)),
                    new MhwStructData.Entry("Craft Cost", 10, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 14, typeof(byte)),
                    new MhwStructData.Entry("Power", 15, typeof(ushort)),
                    new MhwStructData.Entry("Speed", 17, typeof(ushort)),
                    new MhwStructData.Entry("Heal", 19, typeof(ushort)),
                    new MhwStructData.Entry("Element", 21, typeof(ushort)),
                    new MhwStructData.Entry("Dust Effect", 23, typeof(ushort), typeof(DustEffect)),
                    new MhwStructData.Entry("Tree Pos", 25, typeof(byte)),
                    new MhwStructData.Entry("Equip Id", 26, typeof(ushort))
                }
            });
        }

        private static void GenMelderExchange() {
            const ulong size = 430;
            var entries = new List<MhwStructData.Entry> {
                new MhwStructData.Entry("Source Item Id", 0, typeof(uint), true, dataSourceType: DataSourceType.Items),
                new MhwStructData.Entry("Unknown (int32) 1", 4, typeof(int))
            };

            var index = 1;
            for (ulong i = 8; i < size; i += 2) {
                entries.Add(new MhwStructData.Entry($"Un {++index}", i, typeof(ushort)));
            }

            GenerateItemProps("MHW_Editor.Items", "MelderExchange", new MhwStructData { // .mkex
                size = size,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Source_Item_Id}",
                entries = entries
            });
        }

        private static void GenMelderItem() {
            GenerateItemProps("MHW_Editor.Items", "MelderItem", new MhwStructData { // .mkit
                size = 21,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Result_Item_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Result Item Id", 0, typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Research Points", 4, typeof(uint)),
                    new MhwStructData.Entry("Melding Points", 8, typeof(uint)),
                    new MhwStructData.Entry("Category", 12, typeof(uint), typeof(ItemCategory)),
                    new MhwStructData.Entry("Unlock Flag", 16, typeof(uint)),
                    new MhwStructData.Entry("Unknown (uint8)", 20, typeof(byte))
                }
            });
        }

        private static void GenMusicSkill() {
            GenerateItemProps("MHW_Editor.Skills", "MusicSkill", new MhwStructData { // .msk
                size = 20,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.MSK_KEY,
                uniqueIdFormula = "{Song_Id_Raw}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Song Id Raw", 0, typeof(uint), true),
                    new MhwStructData.Entry("Note 1", 4, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 2", 8, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 3", 12, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 4", 16, typeof(int), typeof(NoteColorWithDisabled))
                }
            });
        }

        private static void GenDecoGradeLottery() { // .dglt
            GenerateItemProps("MHW_Editor.Gems", "DecoGradeLottery", new MhwStructData { // .owp_dat
                size = 52,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), true),
                    new MhwStructData.Entry("R5", 8, typeof(uint)),
                    new MhwStructData.Entry("R6", 12, typeof(uint)),
                    new MhwStructData.Entry("R7", 16, typeof(uint)),
                    new MhwStructData.Entry("R8", 20, typeof(uint)),
                    new MhwStructData.Entry("R9", 32, typeof(uint)),
                    new MhwStructData.Entry("R10", 36, typeof(uint)),
                    new MhwStructData.Entry("R11", 40, typeof(uint)),
                    new MhwStructData.Entry("R12", 44, typeof(uint)),
                    new MhwStructData.Entry("R13", 48, typeof(uint)),
                    new MhwStructData.Entry("Stream (R6)", 24, typeof(uint)),
                    new MhwStructData.Entry("Stream (R8)", 28, typeof(uint))
                }
            });
        }

        private static void GenDecoLottery() { // .diot
            GenerateItemProps("MHW_Editor.Gems", "DecoLottery", new MhwStructData { // .owp_dat
                size = 52,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), true),
                    new MhwStructData.Entry("R5", 8, typeof(uint)),
                    new MhwStructData.Entry("R6", 12, typeof(uint)),
                    new MhwStructData.Entry("R7", 16, typeof(uint)),
                    new MhwStructData.Entry("R8", 20, typeof(uint)),
                    new MhwStructData.Entry("R9", 32, typeof(uint)),
                    new MhwStructData.Entry("R10", 36, typeof(uint)),
                    new MhwStructData.Entry("R11", 40, typeof(uint)),
                    new MhwStructData.Entry("R12", 44, typeof(uint)),
                    new MhwStructData.Entry("R13", 48, typeof(uint)),
                    new MhwStructData.Entry("Stream (R6)", 24, typeof(uint)),
                    new MhwStructData.Entry("Stream (R8)", 28, typeof(uint))
                }
            });
        }

        private static void GenOtomoArmorDat() {
            GenerateItemProps("MHW_Editor.Armors", "OtomoArmorDat", new MhwStructData { // .owp_dat
                size = 42,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Set_Id}|{Variant}|{Equip_Slot}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Set Id", 4, typeof(ushort), true),
                    new MhwStructData.Entry("Equip Slot", 6, typeof(byte), true, typeof(EquipSlot)),
                    new MhwStructData.Entry("Is Full Set Raw", 7, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Is Full Set"}),
                    new MhwStructData.Entry("Defense", 8, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 12, typeof(byte)),
                    new MhwStructData.Entry("Order", 13, typeof(ushort)),
                    new MhwStructData.Entry("Model Id", 15, typeof(uint)),
                    new MhwStructData.Entry("Cost", 19, typeof(uint)),
                    new MhwStructData.Entry("Variant", 23, typeof(byte), typeof(Variant)),
                    new MhwStructData.Entry("Fire Res", 27, typeof(sbyte)),
                    new MhwStructData.Entry("Water Res", 28, typeof(sbyte)),
                    new MhwStructData.Entry("Ice Res", 29, typeof(sbyte)),
                    new MhwStructData.Entry("Thunder Res", 30, typeof(sbyte)),
                    new MhwStructData.Entry("Dragon Res", 31, typeof(sbyte)),
                    new MhwStructData.Entry("Set Group", 36, typeof(ushort)),
                    new MhwStructData.Entry("GMD Name Index", 38, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 40, typeof(ushort), true)
                }
            });
        }

        private static void GenOtomoWeaponDat() {
            GenerateItemProps("MHW_Editor.Weapons", "OtomoWeaponDat", new MhwStructData { // .owp_dat
                size = 38,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.OWP_DAT_KEY,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint)),
                    new MhwStructData.Entry("Id", 32, typeof(ushort)),
                    new MhwStructData.Entry("Set Id", 4, typeof(ushort)),
                    new MhwStructData.Entry("Element", 6, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Attack Type", 7, typeof(byte), typeof(AttackType)),
                    new MhwStructData.Entry("Melee Damage", 9, typeof(ushort)),
                    new MhwStructData.Entry("Ranged Damage", 11, typeof(ushort)),
                    new MhwStructData.Entry("Elemental Damage", 13, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 15, typeof(short)),
                    new MhwStructData.Entry("Defense", 17, typeof(ushort)),
                    new MhwStructData.Entry("Elderseal", 19, typeof(byte)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Order", 21, typeof(ushort)),
                    new MhwStructData.Entry("Cost", 27, typeof(uint)),
                    new MhwStructData.Entry("Unknown (byte) 1", 31, typeof(byte)),
                    new MhwStructData.Entry("GMD Name Index", 34, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 36, typeof(ushort), true)
                }
            });
        }

        private static void GenPlantFertilizer() {
            GenerateItemProps("MHW_Editor.Items", "PlantFertilizer", new MhwStructData {
                size = 24,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Fertilizer_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Fertilizer Id", 0, typeof(uint), typeof(Fertilizer)),
                    new MhwStructData.Entry("Prize", 4, typeof(uint)),
                    new MhwStructData.Entry("Base duration", 8, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 1", 12, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 2", 16, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 3", 20, typeof(uint))
                }
            });
        }

        private static void GenPlantItem() {
            GenerateItemProps("MHW_Editor.Items", "PlantItem", new MhwStructData {
                size = 37,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Cultivation category", 0, typeof(uint), typeof(CultivationCategory)),
                    new MhwStructData.Entry("Unlocked from start Raw", 8, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Unlocked from start"}),
                    new MhwStructData.Entry("Item", 9, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Required time", 13, typeof(uint)),
                    new MhwStructData.Entry("Catalyst time bonus", 17, typeof(uint)),
                    new MhwStructData.Entry("Amount (Base)", 25, typeof(uint)),
                    new MhwStructData.Entry("Amount (+1)", 29, typeof(uint)),
                    new MhwStructData.Entry("Amount (+2)", 33, typeof(uint)),
                    new MhwStructData.Entry("Unknown (int32) 1", 4, typeof(uint))
                }
            });
        }

        private static void GenEqCus() {
            GenerateItemProps("MHW_Editor.Items", "EqCus", new MhwStructData {
                size = 41,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Equipment_Category}|{Equipment_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Equipment Category", 0, typeof(byte), true),
                    new MhwStructData.Entry("Equipment Id", 1, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 3, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Monster Unlock", 5, typeof(int)),
                    new MhwStructData.Entry("Story Unlock", 9, typeof(uint)),
                    new MhwStructData.Entry("Item Rank", 13, typeof(uint)),
                    new MhwStructData.Entry("Mat 1 Id", 17, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 19, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 20, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 22, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 23, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 25, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 26, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 28, typeof(byte)),
                    new MhwStructData.Entry("Child index 1", 29, typeof(ushort)),
                    new MhwStructData.Entry("Child index 2", 31, typeof(ushort)),
                    new MhwStructData.Entry("Child index 3", 33, typeof(ushort)),
                    new MhwStructData.Entry("Child index 4", 35, typeof(ushort))
                }
            });
        }

        private static void GenEqCrt() {
            GenerateItemProps("MHW_Editor.Items", "EqCrt", new MhwStructData {
                size = 37,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Equipment_Category}|{Equipment_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Equipment Category", 0, typeof(byte), true),
                    new MhwStructData.Entry("Equipment Id", 1, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 3, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Monster Unlock", 5, typeof(int)),
                    new MhwStructData.Entry("Story Unlock", 9, typeof(uint)),
                    new MhwStructData.Entry("Unknown (uint32)", 13, typeof(uint)),
                    new MhwStructData.Entry("Item Rank", 17, typeof(uint)),
                    new MhwStructData.Entry("Mat 1 Id", 21, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 23, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 24, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 26, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 27, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 29, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 30, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 32, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 1", 33, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 2", 34, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 3", 35, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8) 4", 36, typeof(byte))
                }
            });
        }

        private static void GenASkill() {
            GenerateItemProps("MHW_Editor.Armors", "ASkill", new MhwStructData {
                size = 28,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Mantle_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Mantle Id", 16, typeof(uint), true),
                    new MhwStructData.Entry("Icon Id", 0, typeof(uint)),
                    new MhwStructData.Entry("Color", 4, typeof(uint)),
                    new MhwStructData.Entry("Sort Order", 8, typeof(uint)),
                    new MhwStructData.Entry("Mantle Item Id", 12, typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unlock Flag or Item Id?", 20, typeof(uint)),
                    new MhwStructData.Entry("Deco Count", 24, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 1", 25, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 2", 26, typeof(byte)),
                    new MhwStructData.Entry("Deco Lvl 3", 27, typeof(byte))
                }
            });
        }

        private static void GenSkillPointData() {
            GenerateItemProps("MHW_Editor.Skills", "SkillPointData", new MhwStructData {
                size = 2,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Is Set Bonus Raw", 0, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Is Set Bonus"}),
                    new MhwStructData.Entry("Icon Color Id", 1, typeof(byte))
                }
            });
        }

        private static void GenWeaponSwitchAxe() {
            GenerateItemProps("MHW_Editor.Weapons", "WeaponSwitchAxe", new MhwStructData {
                size = 7,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Unknown 1 (uint8)", 4, typeof(byte)),
                    new MhwStructData.Entry("Unknown 2 (uint16)", 5, typeof(ushort))
                }
            });
        }

        private static void GenWeaponGunLance() {
            GenerateItemProps("MHW_Editor.Weapons", "WeaponGunLance", new MhwStructData {
                size = 8,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Shell Type", 4, typeof(ushort), typeof(ShellType)),
                    new MhwStructData.Entry("Shell Level", 6, typeof(ushort))
                }
            });
        }

        private static void GenWeaponWhistle() {
            GenerateItemProps("MHW_Editor.Weapons", "WeaponWhistle", new MhwStructData {
                size = 7,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Note 1", 4, typeof(byte), typeof(NoteColor)),
                    new MhwStructData.Entry("Note 2", 5, typeof(byte), typeof(NoteColor)),
                    new MhwStructData.Entry("Note 3", 6, typeof(byte), typeof(NoteColor))
                }
            });
        }

        private static void GenWeaponWSword() {
            GenerateItemProps("MHW_Editor.Weapons", "WeaponWSword", new MhwStructData {
                size = 10,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Element 1 Type", 4, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element 1 Dmg", 5, typeof(short)),
                    new MhwStructData.Entry("Element 2 Type", 7, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element 2 Dmg", 8, typeof(short))
                }
            });
        }

        private static void GenNewLimitBreak() { // .new_lb
            GenerateItemProps("MHW_Editor.Weapons", "NewLimitBreak", new MhwStructData {
                size = 24,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Aug_Category}|{Aug_Level}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Aug Category", 0, typeof(uint), true, typeof(AugmentationCategory)),
                    new MhwStructData.Entry("Aug Level", 4, typeof(uint), true),
                    new MhwStructData.Entry("Aug Slot Cost", 8, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r10)", 12, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r11)", 16, typeof(uint)),
                    new MhwStructData.Entry("Research Cost (r12)", 20, typeof(uint))
                }
            });
        }

        private static void GenNewLimitBreakR() { // .new_lbr
            GenerateItemProps("MHW_Editor.Weapons", "NewLimitBreakR", new MhwStructData {
                size = 38,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id_1}|{Id_2}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id 1", 0, typeof(ushort), true),
                    new MhwStructData.Entry("Id 2", 2, typeof(ushort), true),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 4, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk1", 6, typeof(int)),
                    new MhwStructData.Entry("Mat 1 Id", 14, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 16, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 17, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 19, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 20, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 22, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 23, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 25, typeof(byte)),
                    new MhwStructData.Entry("Id 3", 37, typeof(byte), true)
                }
            });
        }

        private static void GenShellTable() {
            var types = new List<ShellTableTypes> {
                new ShellTableTypes("Normal", 3),
                new ShellTableTypes("Pierce", 3),
                new ShellTableTypes("Spread", 3),
                new ShellTableTypes("Cluster", 3),
                new ShellTableTypes("Wyvern", 1),
                new ShellTableTypes("Sticky", 3),
                new ShellTableTypes("Slicing", 1),
                new ShellTableTypes("Flaming", 1),
                new ShellTableTypes("Water", 1),
                new ShellTableTypes("Freeze", 1),
                new ShellTableTypes("Thunder", 1),
                new ShellTableTypes("Dragon", 1),
                new ShellTableTypes("Poison", 2),
                new ShellTableTypes("Paralysis", 2),
                new ShellTableTypes("Sleep", 2),
                new ShellTableTypes("Exhaust", 2),
                new ShellTableTypes("Recover", 2),
                new ShellTableTypes("Demon", 1),
                new ShellTableTypes("Armor", 1),
                new ShellTableTypes("Unknown", 2),
                new ShellTableTypes("Tranq", 1)
            };

            var entries = new List<MhwStructData.Entry>();

            ulong x = 0;
            foreach (var type in types) {
                for (var i = 0; i < type.num; i++) {
                    if (type.name == "Unknown") {
                        x += 3;
                        continue;
                    }

                    var name = type.name;
                    if (type.num > 1) {
                        name += $" {i + 1}";
                    }

                    entries.Add(new MhwStructData.Entry($"{name} Mag Cnt", x++, typeof(byte), valueString: "value.Clamp((byte) 0, (byte) 10)"));
                    entries.Add(new MhwStructData.Entry($"{name} Rec Amnt", x++, typeof(byte)));
                    entries.Add(new MhwStructData.Entry($"{name} Rel Spd", x++, typeof(byte)));
                }
            }

            GenerateItemProps("MHW_Editor.Weapons", "ShellTable", new MhwStructData {
                size = 111,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = entries
            });
        }

        private static void GenSharpness() {
            GenerateItemProps("MHW_Editor.Weapons", "Sharpness", new MhwStructData {
                size = 18,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Red", 4, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Orange", 6, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Yellow", 8, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Green", 10, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Blue", 12, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("White", 14, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)"),
                    new MhwStructData.Entry("Purple", 16, typeof(ushort), valueString: "value.Clamp((ushort) 0, (ushort) 400)")
                }
            });
        }

        private static void GenRanged() {
            GenerateItemProps("MHW_Editor.Weapons", "Ranged", new MhwStructData {
                size = 69,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Id", 59, typeof(ushort), true),
                    new MhwStructData.Entry("Base Model Id", 6, typeof(short)),
                    new MhwStructData.Entry("Part 1 Id", 8, typeof(short)),
                    new MhwStructData.Entry("Part 2 Id", 10, typeof(short)),
                    new MhwStructData.Entry("Is Fixed Upgrade Raw", 15, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Is Fixed Upgrade"}),
                    new MhwStructData.Entry("Muzzle Type", 16, typeof(byte), typeof(MuzzleType)),
                    new MhwStructData.Entry("Barrel Type", 17, typeof(byte), typeof(BarrelType)),
                    new MhwStructData.Entry("Magazine Type", 18, typeof(byte), typeof(MagazineType)),
                    new MhwStructData.Entry("Scope Type", 19, typeof(byte), typeof(ScopeType)),
                    new MhwStructData.Entry("Cost", 20, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 24, typeof(byte)),
                    new MhwStructData.Entry("Damage", 25, typeof(ushort)),
                    new MhwStructData.Entry("Defense", 27, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 29, typeof(sbyte), valueString: "value.Clamp((sbyte) -100, (sbyte) 100)"),
                    new MhwStructData.Entry("Element", 30, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element Damage", 31, typeof(ushort)),
                    new MhwStructData.Entry("Element (Hidden)", 33, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element (Hidden) Damage", 34, typeof(ushort)),
                    new MhwStructData.Entry("Elderseal", 36, typeof(byte), typeof(Elderseal)),
                    new MhwStructData.Entry("Shell Type Id", 37, typeof(byte)),
                    new MhwStructData.Entry("Deviation", 39, typeof(byte), typeof(Deviation)),
                    new MhwStructData.Entry("Slot Count", 40, typeof(byte)),
                    new MhwStructData.Entry("Slot 1 Size", 41, typeof(byte)),
                    new MhwStructData.Entry("Slot 2 Size", 42, typeof(byte)),
                    new MhwStructData.Entry("Slot 3 Size", 43, typeof(byte)),
                    new MhwStructData.Entry("Special Ammo Type", 57, typeof(byte)),
                    new MhwStructData.Entry("Skill", 65, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("GMD Name Index", 61, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 63, typeof(ushort), true)
                }
            });
        }

        private static void GenMelee() {
            GenerateItemProps("MHW_Editor.Weapons", "Melee", new MhwStructData {
                size = 66,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Id", 56, typeof(ushort), true),
                    new MhwStructData.Entry("Unk1", 4, typeof(short)),
                    new MhwStructData.Entry("Base Model Id", 6, typeof(short)),
                    new MhwStructData.Entry("Part 1 Id", 8, typeof(short)),
                    new MhwStructData.Entry("Part 2 Id", 10, typeof(short)),
                    new MhwStructData.Entry("Unk2", 13, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 14, typeof(byte)),
                    new MhwStructData.Entry("Is Fixed Upgrade Raw", 15, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Is Fixed Upgrade"}),
                    new MhwStructData.Entry("Cost", 16, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Sharpness (.kire) Id", 21, typeof(byte)),
                    new MhwStructData.Entry("Sharpness Amount", 22, typeof(byte)),
                    new MhwStructData.Entry("Damage", 23, typeof(ushort)),
                    new MhwStructData.Entry("Defense", 25, typeof(ushort)),
                    new MhwStructData.Entry("Affinity", 27, typeof(sbyte), valueString: "value.Clamp((sbyte) -100, (sbyte) 100)"),
                    new MhwStructData.Entry("Element", 28, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element Damage", 29, typeof(ushort)),
                    new MhwStructData.Entry("Element (Hidden)", 31, typeof(byte), typeof(Element)),
                    new MhwStructData.Entry("Element (Hidden) Damage", 32, typeof(ushort)),
                    new MhwStructData.Entry("Elderseal", 34, typeof(byte), typeof(Elderseal)),
                    new MhwStructData.Entry("Slot Count", 35, typeof(byte)),
                    new MhwStructData.Entry("Slot 1 Size", 36, typeof(byte)),
                    new MhwStructData.Entry("Slot 2 Size", 37, typeof(byte)),
                    new MhwStructData.Entry("Slot 3 Size", 38, typeof(byte)),
                    new MhwStructData.Entry("Special Ability 1 ID", 39, typeof(ushort)),
                    new MhwStructData.Entry("Special Ability 2 ID", 41, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 55, typeof(byte)),
                    new MhwStructData.Entry("Skill", 62, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("GMD Name Index", 58, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 60, typeof(ushort), true)
                }
            });
        }

        private static void GenArmor() {
            GenerateItemProps("MHW_Editor.Armors", "Armor", new MhwStructData {
                size = 60,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Set_Group}|{Variant}|{Type}|{Equip_Slot}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Order", 4, typeof(ushort)),
                    new MhwStructData.Entry("Variant", 6, typeof(byte), true, typeof(Variant)),
                    new MhwStructData.Entry("Set (Layered) Id", 7, typeof(ushort), true),
                    new MhwStructData.Entry("Type", 9, typeof(byte), true, typeof(ArmorType)),
                    new MhwStructData.Entry("Equip Slot", 10, typeof(byte), true, typeof(EquipSlot)),
                    new MhwStructData.Entry("Defense", 11, typeof(ushort)),
                    new MhwStructData.Entry("Model Id 1", 13, typeof(ushort)),
                    new MhwStructData.Entry("Model Id 2", 15, typeof(ushort)),
                    new MhwStructData.Entry("Unk1", 17, typeof(ushort)),
                    new MhwStructData.Entry("Unk2", 19, typeof(byte)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Cost", 21, typeof(uint)),
                    new MhwStructData.Entry("Fire Res", 25, typeof(sbyte)),
                    new MhwStructData.Entry("Water Res", 26, typeof(sbyte)),
                    new MhwStructData.Entry("Ice Res", 27, typeof(sbyte)),
                    new MhwStructData.Entry("Thunder Res", 28, typeof(sbyte)),
                    new MhwStructData.Entry("Dragon Res", 29, typeof(sbyte)),
                    new MhwStructData.Entry("Slot Count", 30, typeof(byte)),
                    new MhwStructData.Entry("Slot 1 Size", 31, typeof(byte)),
                    new MhwStructData.Entry("Slot 2 Size", 32, typeof(byte)),
                    new MhwStructData.Entry("Slot 3 Size", 33, typeof(byte)),
                    new MhwStructData.Entry("Set Skill 1", 34, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Set Skill 1 Level", 36, typeof(byte)),
                    new MhwStructData.Entry("Set Skill 2", 37, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Set Skill 2 Level", 39, typeof(byte)),
                    new MhwStructData.Entry("Skill 1", 40, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 1 Level", 42, typeof(byte)),
                    new MhwStructData.Entry("Skill 2", 43, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 2 Level", 45, typeof(byte)),
                    new MhwStructData.Entry("Skill 3", 46, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 3 Level", 48, typeof(byte)),
                    new MhwStructData.Entry("Gender", 49, typeof(uint), typeof(Gender)),
                    new MhwStructData.Entry("Set Group", 53, typeof(ushort), true),
                    new MhwStructData.Entry("Is Permanent Raw", 59, typeof(byte), accessLevel: "private", extraOnPropertyChanged: new[] {"Is Permanent"}),
                    new MhwStructData.Entry("GMD Name Index", 55, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 57, typeof(ushort), true)
                }
            });
        }

        private static void GenSkillDat() {
            GenerateItemProps("MHW_Editor.Skills", "SkillDat", new MhwStructData {
                size = 27,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}|{Level}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(ushort), true),
                    new MhwStructData.Entry("Level", 2, typeof(byte), true),
                    new MhwStructData.Entry("Unlock Skill 1", 3, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 2", 7, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 3", 11, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Unlock Skill 4", 15, typeof(uint), dataSourceType: DataSourceType.SkillDat),
                    new MhwStructData.Entry("Param 5", 19, typeof(ushort)),
                    new MhwStructData.Entry("Param 6", 21, typeof(ushort)),
                    new MhwStructData.Entry("Param 7", 23, typeof(ushort)),
                    new MhwStructData.Entry("Param 8", 25, typeof(ushort))
                }
            });
        }

        private static void GenGem() {
            GenerateItemProps("MHW_Editor.Gems", "Gem", new MhwStructData {
                size = 28,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 4, typeof(ushort), true),
                    new MhwStructData.Entry("Id", 0, typeof(ushort), true),
                    new MhwStructData.Entry("Size", 8, typeof(byte)),
                    new MhwStructData.Entry("Skill 1", 12, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 1 Level", 16, typeof(byte)),
                    new MhwStructData.Entry("Skill 2", 20, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 2 Level", 24, typeof(byte))
                }
            });
        }

        private static void GenArmUp() {
            GenerateItemProps("MHW_Editor.Items", "ArmUp", new MhwStructData {
                size = 22,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Rarity}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Quest Progress 1", 0, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 2", 2, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 3", 4, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 4", 6, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 5", 8, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 6", 10, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 7", 12, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 8", 14, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 9", 16, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 10", 18, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 11", 20, typeof(short))
                }
            });
        }

        private static void GenBottleTable() {
            GenerateItemProps("MHW_Editor.Items", "BottleTable", new MhwStructData {
                size = 6,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Close Range", 0, typeof(byte), typeof(CoatingType)),
                    new MhwStructData.Entry("Power", 1, typeof(byte), typeof(CoatingType)),
                    new MhwStructData.Entry("Paralysis", 2, typeof(byte), typeof(CoatingType)),
                    new MhwStructData.Entry("Poison", 3, typeof(byte), typeof(CoatingType)),
                    new MhwStructData.Entry("Sleep", 4, typeof(byte), typeof(CoatingType)),
                    new MhwStructData.Entry("Blast", 5, typeof(byte), typeof(CoatingType))
                }
            });
        }

        private static void GenItem() {
            GenerateItemProps("MHW_Editor.Items", "Item", new MhwStructData {
                size = 32,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 0, typeof(uint), true),
                    new MhwStructData.Entry("Sub Type", 4, typeof(byte), typeof(ItemSubType)),
                    new MhwStructData.Entry("Type", 5, typeof(uint), typeof(ItemType)),
                    new MhwStructData.Entry("Rarity", 9, typeof(byte)),
                    new MhwStructData.Entry("Carry Limit", 10, typeof(byte)),
                    new MhwStructData.Entry("Unknown (uint8)", 11, typeof(byte)),
                    new MhwStructData.Entry("Sort Order", 12, typeof(ushort)),
                    new MhwStructData.Entry("Icon Id", 18, typeof(uint)),
                    new MhwStructData.Entry("Icon Color Id", 22, typeof(ushort)),
                    new MhwStructData.Entry("Sell Price", 24, typeof(uint)),
                    new MhwStructData.Entry("Buy Price", 28, typeof(uint)),
                    new MhwStructData.Entry("Flags Raw", 14, typeof(uint), accessLevel: "private", extraOnPropertyChanged: new[] {"Flags"})
                }
            });
        }

        public static void GenerateItemProps(string @namespace, string className, MhwStructData structData) {
            WriteResult($"{Global.GENERATED_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new ItemTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });

            WriteResult($"{Global.STRUCT_OUTPUT_ROOT}\\{@namespace.Replace(".", "\\")}", @namespace, className, new RawStructTemplate {
                Session = new Dictionary<string, object> {
                    {"_namespace", @namespace},
                    {"className", className},
                    {"structData", structData}
                }
            });
        }

        public static void WriteResult(string dir, string @namespace, string className, dynamic template) {
            template.Initialize();
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText($"{dir}\\{className}.cs", (string) template.TransformText());
        }
    }
}