using System;
using MHW_Template.Models;

namespace MHW_Template {
    public static class GenerationHelper {
        public static string GetDataSourceType(DataSourceType dataSourceType) {
            return dataSourceType switch {
                DataSourceType.Items => "DataHelper.itemNames[MainWindow.locale]",
                DataSourceType.Skills => "DataHelper.skillNames[MainWindow.locale]",
                DataSourceType.SkillDat => "MainWindow.skillDatLookup[MainWindow.locale]",
                DataSourceType.ArmorById => "DataHelper.armorIdNameLookup[GetArmorType()][MainWindow.locale]",
                DataSourceType.ArmorByIndex => "DataHelper.armorIndexNameLookup[GetArmorType()][MainWindow.locale]",
                DataSourceType.ArmorByIndexNeg => "DataHelper.armorIndexNegNameLookup[GetArmorType()][MainWindow.locale]",
                DataSourceType.ArmorByFileIndexNeg => "DataHelper.armorFileIndexNegNameLookup[MainWindow.locale]",
                DataSourceType.WeaponsById => "DataHelper.weaponIdNameLookup[GetWeaponType()][MainWindow.locale]",
                DataSourceType.WeaponsByIndex => "DataHelper.weaponIndexNameLookup[GetWeaponType()][MainWindow.locale]",
                DataSourceType.EquipmentById => "DataHelper.equipmentIdNameLookup[GetEquipmentType()][MainWindow.locale]",
                DataSourceType.Pendants => "DataHelper.pendantNames[MainWindow.locale]",
                DataSourceType.Monsters => "DataHelper.monsterNames[MainWindow.locale]",
                DataSourceType.MonstersNeg => "DataHelper.monsterNamesNeg[MainWindow.locale]",
                DataSourceType.ShellRecoil => "ShellTable.recoilLookup",
                DataSourceType.ShellReload => "ShellTable.reloadLookup",
                DataSourceType.GunnerRecoil => "GunnerShoot.recoilLookup",
                DataSourceType.GunnerReload => "GunnerReload.reloadLookup",
                DataSourceType.MantleByIdNeg => "DataHelper.mantleNamesNeg[MainWindow.locale]",
                DataSourceType.KinsectById => "DataHelper.kinsectNames[MainWindow.locale]",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}