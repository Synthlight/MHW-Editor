using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Items {
    public class KulveItemLottery : ISingleStruct {
        public SingleStruct Generate() { // .em117iot
            return new SingleStruct("MHW_Editor.Items", "KulveItemLottery", new MhwStructData {
                size             = 32,
                offsetInitial    = 6,
                entryCountOffset = 2,
                uniqueIdFormula  = "{Index}",
                autoOffset       = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", typeof(uint)),
                    new MhwStructData.Entry("Weapon Type", typeof(uint), enumReturn: typeof(WeaponType), extraOnPropertyChanged: new[] {"Weapon_Id_button"}),
                    new MhwStructData.Entry("Weapon Id", typeof(uint), dataSourceType: DataSourceType.WeaponsById),
                    new MhwStructData.Entry("Grade 1", typeof(uint)),
                    new MhwStructData.Entry("Grade 2", typeof(uint)),
                    new MhwStructData.Entry("Grade 3", typeof(uint)),
                    new MhwStructData.Entry("Grade 4", typeof(uint)),
                    new MhwStructData.Entry("Grade 5", typeof(uint))
                }
            });
        }
    }
}