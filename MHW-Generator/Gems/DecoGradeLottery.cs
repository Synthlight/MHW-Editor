using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Gems {
    public class DecoGradeLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .dglt
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Grade 1", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 2", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 3", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 4", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Stream (R6)", typeof(uint), createPercentField: true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Stream (R8)", typeof(uint), createPercentField: true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Grade 5", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 6", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 7", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 8", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 9", typeof(uint), createPercentField: true)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Item_Id}")
            };

            return new MultiStruct("MHW_Editor.Gems", "DecoGradeLottery", new MhwMultiStructData(structs, "dglt"));
        }
    }
}