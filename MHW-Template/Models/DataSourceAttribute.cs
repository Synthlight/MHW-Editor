using System;

namespace MHW_Template.Models {
    public class DataSourceAttribute : Attribute {
        public readonly DataSourceType dataType;

        public DataSourceAttribute(DataSourceType dataType) {
            this.dataType = dataType;
        }
    }

    public enum DataSourceType {
        Items,
        Skills,
        SkillDat,
        ArmorById,
        ArmorByIndex,
        WeaponsById,
        WeaponsByIndex,
        EquipmentById
    }
}