using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Armors {
    public class ASkill : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .ask
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Icon Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Color", typeof(uint)),
                    new MhwMultiStructData.Entry("Sort Order", typeof(uint)),
                    new MhwMultiStructData.Entry("Mantle Item Id", typeof(uint), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mantle Id", typeof(uint), true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Unlock Flag or Item Id?", typeof(uint)),
                    new MhwMultiStructData.Entry("Deco Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Deco Lvl 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Deco Lvl 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Deco Lvl 3", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Mantle_Id}")
            };

            return new MultiStruct("MHW_Editor.Armors", "ASkill", new MhwMultiStructData(structs, "ask"));
        }
    }
}