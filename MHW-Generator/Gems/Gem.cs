using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Gems {
    public class Gem : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .sgpa
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id", typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Index", typeof(uint), true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Size", typeof(uint)),
                    new MhwMultiStructData.Entry("Skill 1", typeof(uint), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Skill 1 Level", typeof(uint)),
                    new MhwMultiStructData.Entry("Skill 2", typeof(uint), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Skill 2 Level", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}")
            };

            return new MultiStruct("MHW_Editor.Gems", "Gem", new MhwMultiStructData(structs, "sgpa"));
        }
    }
}