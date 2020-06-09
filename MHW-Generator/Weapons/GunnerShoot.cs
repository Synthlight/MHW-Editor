using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class GunnerShoot : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .gun_sd
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("No Mods", typeof(byte), dataSourceType: DataSourceType.GunnerRecoil),
                    new MhwMultiStructData.Entry("Mod 1", typeof(byte), dataSourceType: DataSourceType.GunnerRecoil),
                    new MhwMultiStructData.Entry("Mod 2", typeof(byte), dataSourceType: DataSourceType.GunnerRecoil),
                    new MhwMultiStructData.Entry("Mod 3", typeof(byte), dataSourceType: DataSourceType.GunnerRecoil),
                    new MhwMultiStructData.Entry("Mod 4", typeof(byte), dataSourceType: DataSourceType.GunnerRecoil)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("Weapons", "GunnerShoot", new MhwMultiStructData(structs, "gun_sd"));
        }
    }
}