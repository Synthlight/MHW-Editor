using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using MHW_Editor.Models;
using MHW_Editor.Structs.Armors;
using MHW_Editor.Structs.Items;
using MHW_Editor.Structs.Weapons;
using MHW_Editor.Windows;
using MHW_Template;
using Newtonsoft.Json;

namespace Mod_Maker;

public static class Program {
    private const string EQUIP_ROOT  = $@"{Global.CHUNK_ROOT}\common\equip";
    private const string OUTPUT_ROOT = $@"R:\Games\Monster Hunter World\Mods\_For Mod-Manager";

    /**
    Cost:

    armor.am_dat
    customParts.cus_pa
    new_limit_break.new_lb
    otomoArmor.oam_dat
    otomoWeapon.owp_dat
    rod_insect.rod_inse

    Materials:

    armor.eq_crt
    charm.eq_crt
    ot_equip.eq_crt
    weapon.eq_crt
    equip_custom.eq_cus
    insect.eq_cus
    insect_element.eq_cus
    weapon.eq_cus

    Cost & Materials:

    customOuterRecipe.cus_otr
    customParts.cus_par
    limit_break_mat_base.lbm_base
    limit_break_mat_skill.lbm_skill
    new_limit_break.new_lbr
     */
    private static readonly List<string> FILES = [
        "armor.am_dat",
        "armor.eq_crt",
        "charm.eq_crt",
        "customOuterRecipe.cus_otr",
        "customParts.cus_pa",
        "customParts.cus_par",
        "equip_custom.eq_cus",
        "insect.eq_cus",
        "insect_element.eq_cus",
        "limit_break_mat_base.lbm_base",
        "limit_break_mat_skill.lbm_skill",
        "new_limit_break.new_lb",
        "new_limit_break.new_lbr",
        "ot_equip.eq_crt",
        "otomoArmor.oam_dat",
        "otomoWeapon.owp_dat",
        "rod_insect.rod_inse",
        "weapon.eq_crt",
        "weapon.eq_cus",
    ];

    [STAThread]
    public static void Main() {
        foreach (var file in Directory.EnumerateFiles(EQUIP_ROOT, "*.wp_dat*")) {
            if (file.Contains(".wp_dat")) {
                FILES.Add(Path.GetFileName(file));
            }
        }

        MakeMod("No Crafting Requirements", false);
        MakeMod("No Crafting Requirements (Ignore Requirements)", true);
    }

    public static void MakeMod(string name, bool ignoreUnlockRequirements) {
        var outputRoot = $@"{OUTPUT_ROOT}\{name}\nativePC\common\equip";
        Directory.CreateDirectory(outputRoot);

        foreach (var file in FILES) {
            var outFilePath = $@"{outputRoot}\{file}";
            File.Copy($@"{EQUIP_ROOT}\{file}", outFilePath, true);

            var data = Load(outFilePath);

            ModData(data, ignoreUnlockRequirements);

            Save(outFilePath, data);
            SaveJson(outFilePath, data);
        }
    }

    private static void ModData(IMhwMultiStructFile data, bool ignoreUnlockRequirements) {
        const int zennyCost            = 1;
        const int requiredItem         = 1; // Potion
        const int requiredItemQuantity = 0;

        foreach (var item in data.GetAllEnumerableOfType<IMhwStructItem>()) {
            switch (item) {
                case Armor.Entries entries: { // am_dat
                    if (entries.Cost > 0) entries.Cost = zennyCost;
                    break;
                }
                case CustomOuterRecipe.Entries entries: { // cus_otr
                    entries.Cost        = zennyCost;
                    entries.Mat_1_Id    = requiredItem;
                    entries.Mat_2_Id    = 0;
                    entries.Mat_3_Id    = 0;
                    entries.Mat_4_Id    = 0;
                    entries.Mat_1_Count = requiredItemQuantity;
                    entries.Mat_2_Count = 0;
                    entries.Mat_3_Count = 0;
                    entries.Mat_4_Count = 0;
                    if (ignoreUnlockRequirements) {
                        entries.Needed_Item_Id_to_Unlock = 0;
                    }
                    break;
                }
                case CustomParts.Entries entries: { // cus_pa
                    entries.Craft_Cost = zennyCost;
                    break;
                }
                case CustomPartsR.Entries entries: { // cus_par
                    entries.Mat_1_Id    = requiredItem;
                    entries.Mat_2_Id    = 0;
                    entries.Mat_3_Id    = 0;
                    entries.Mat_4_Id    = 0;
                    entries.Mat_1_Count = requiredItemQuantity;
                    entries.Mat_2_Count = 0;
                    entries.Mat_3_Count = 0;
                    entries.Mat_4_Count = 0;
                    if (ignoreUnlockRequirements) {
                        entries.Needed_Item_Id_to_Unlock = 0;
                    }
                    break;
                }
                case EqCrt.Entries entries: { // eq_crt
                    entries.Mat_1_Id    = requiredItem;
                    entries.Mat_2_Id    = 0;
                    entries.Mat_3_Id    = 0;
                    entries.Mat_4_Id    = 0;
                    entries.Mat_1_Count = requiredItemQuantity;
                    entries.Mat_2_Count = 0;
                    entries.Mat_3_Count = 0;
                    entries.Mat_4_Count = 0;
                    if (ignoreUnlockRequirements) {
                        entries.Needed_Item_Id_to_Unlock = 0;
                        entries.Monster_Unlock           = -1;
                        entries.Story_Unlock             = 0;
                    }
                    break;
                }
                case EqCus.Entries entries: { // eq_cus
                    entries.Mat_1_Id    = requiredItem;
                    entries.Mat_2_Id    = 0;
                    entries.Mat_3_Id    = 0;
                    entries.Mat_4_Id    = 0;
                    entries.Mat_1_Count = requiredItemQuantity;
                    entries.Mat_2_Count = 0;
                    entries.Mat_3_Count = 0;
                    entries.Mat_4_Count = 0;
                    if (ignoreUnlockRequirements) {
                        entries.Needed_Item_Id_to_Unlock = 0;
                        entries.Monster_Unlock           = -1;
                        entries.Story_Unlock             = 0;
                    }
                    break;
                }
                case LimitBreakMaterialBase.Entries entries: { // lbm_base
                    entries.Cost       = zennyCost;
                    entries.Item_1_Id  = requiredItem;
                    entries.Item_2_Id  = 0;
                    entries.Item_1_Cnt = requiredItemQuantity;
                    entries.Item_2_Cnt = 0;
                    break;
                }
                case LimitBreakMaterialSkill.Entries entries: { // lbm_skill
                    entries.Item_1_Id  = requiredItem;
                    entries.Item_1_Cnt = requiredItemQuantity;
                    break;
                }
                case NewLimitBreak.Entries entries: { // new_lb
                    entries.Research_Cost_r10_ = 0;
                    entries.Research_Cost_r11_ = 0;
                    entries.Research_Cost_r12_ = 0;
                    break;
                }
                case NewLimitBreakR.Entries entries: { // new_lbr
                    entries.Mat_1_Id    = requiredItem;
                    entries.Mat_2_Id    = 0;
                    entries.Mat_3_Id    = 0;
                    entries.Mat_4_Id    = 0;
                    entries.Mat_1_Count = requiredItemQuantity;
                    entries.Mat_2_Count = 0;
                    entries.Mat_3_Count = 0;
                    entries.Mat_4_Count = 0;
                    if (ignoreUnlockRequirements) {
                        entries.Needed_Item_Id_to_Unlock = 0;
                    }
                    break;
                }
                case OtomoArmorDat.Entries entries: { // oam_dat
                    entries.Cost = zennyCost;
                    break;
                }
                case OtomoWeaponDat.Entries entries: { // owp_dat
                    entries.Cost = zennyCost;
                    break;
                }
                case RodInsect.Entries entries: { // rod_inse
                    entries.Craft_Cost = zennyCost;
                    break;
                }
                case IWeapon entries: { // wp_dat / wp_dat_g
                    entries.Cost = zennyCost;
                    break;
                }
            }
        }
    }

    private static IMhwMultiStructFile Load(string targetFile) {
        var targetFileType = MainWindow.GetFileType(targetFile);
        var loadData       = targetFileType.GetMethod("LoadData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);

        Debug.Assert(loadData != null, nameof(loadData) + " != null");

        var fileData = (IMhwMultiStructFile) loadData.Invoke(null, [targetFile]);
        if (fileData is ITargetFile obj) obj.Init(targetFile);
        return fileData;
    }

    private static void Save(string targetFile, IMhwMultiStructFile fileData) {
        var targetFileType = MainWindow.GetFileType(targetFile);
        var saveData       = targetFileType.GetMethod("SaveData", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
        Debug.Assert(saveData != null, nameof(saveData) + " != null");
        saveData.Invoke(null, [fileData, targetFile]);
    }

    private static void SaveJson(string outFilePath, IMhwMultiStructFile data) {
        var changesToSave = MainWindow.GetChangesToSave(outFilePath, data, null);
        var json          = JsonConvert.SerializeObject(changesToSave, Formatting.Indented);
        File.WriteAllText($"{outFilePath}.json", json);
    }
}