using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Items {
    public class SafiItemLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104iot
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Weapon Type", typeof(uint), enumReturn: typeof(WeaponType), extraOnPropertyChanged: new[] {"Weapon_Id_button"}),
                    new MhwMultiStructData.Entry("Weapon Id", typeof(uint), dataSourceType: DataSourceType.WeaponsById),
                    new MhwMultiStructData.Entry("All Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("GS Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("LS Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("SnS Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("DB Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("Lance Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("GL Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("Hammer Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("HH Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("SA Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("CB Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("IG Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("LBG Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("HBG Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("Bow Rarity", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Items", "SafiItemLottery", new MhwMultiStructData(structs, "em104iot"));
        }
    }
}