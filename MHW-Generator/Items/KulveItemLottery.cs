using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Items {
    public class KulveItemLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em117iot
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var itemCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Weapon Type", typeof(uint), enumReturn: typeof(WeaponType), extraOnPropertyChanged: new[] {"Weapon_Id_button"}),
                    new MhwMultiStructData.Entry("Weapon Id", typeof(uint), dataSourceType: DataSourceType.WeaponsById),
                    new MhwMultiStructData.Entry("Grade 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Grade 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Grade 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Grade 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Grade 5", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "KulveItemLottery", new MhwMultiStructData(structs, "em117iot"));
        }
    }
}