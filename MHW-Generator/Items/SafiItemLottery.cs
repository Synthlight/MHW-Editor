using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Weapons;

namespace MHW_Generator.Items {
    public class SafiItemLottery : ISingleStruct {
        public SingleStruct Generate() { // .em104iot
            return new SingleStruct("MHW_Editor.Items", "SafiItemLottery", new MhwStructData {
                size = 72,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                autoOffset = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", typeof(uint)),
                    new MhwStructData.Entry("Weapon Type", typeof(uint), enumReturn: typeof(WeaponType), extraOnPropertyChanged: new[] {"Weapon_Id_button"}),
                    new MhwStructData.Entry("Weapon Id", typeof(uint), dataSourceType: DataSourceType.WeaponsById),
                    new MhwStructData.Entry("All Rarity", typeof(uint)),
                    new MhwStructData.Entry("GS Rarity", typeof(uint)),
                    new MhwStructData.Entry("LS Rarity", typeof(uint)),
                    new MhwStructData.Entry("SnS Rarity", typeof(uint)),
                    new MhwStructData.Entry("DB Rarity", typeof(uint)),
                    new MhwStructData.Entry("Lance Rarity", typeof(uint)),
                    new MhwStructData.Entry("GL Rarity", typeof(uint)),
                    new MhwStructData.Entry("Hammer Rarity", typeof(uint)),
                    new MhwStructData.Entry("HH Rarity", typeof(uint)),
                    new MhwStructData.Entry("SA Rarity", typeof(uint)),
                    new MhwStructData.Entry("CB Rarity", typeof(uint)),
                    new MhwStructData.Entry("IG Rarity", typeof(uint)),
                    new MhwStructData.Entry("LBG Rarity", typeof(uint)),
                    new MhwStructData.Entry("HBG Rarity", typeof(uint)),
                    new MhwStructData.Entry("Bow Rarity", typeof(uint))
                }
            });
        }
    }
}