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
                DataSourceType.WeaponsById => "DataHelper.weaponIdNameLookup[GetWeaponType()][MainWindow.locale]",
                DataSourceType.WeaponsByIndex => "DataHelper.weaponIndexNameLookup[GetWeaponType()][MainWindow.locale]",
                DataSourceType.EquipmentById => "DataHelper.equipmentIdNameLookup[GetEquipmentType()][MainWindow.locale]",
                DataSourceType.Pendants => "DataHelper.pendantNames[MainWindow.locale]",
                DataSourceType.Monsters => "DataHelper.monsterNames[MainWindow.locale]",
                DataSourceType.MonstersNeg => "DataHelper.monsterNamesNeg[MainWindow.locale]",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}