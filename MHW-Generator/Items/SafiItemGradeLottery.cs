using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class SafiItemGradeLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104glt
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Grade 1", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 2", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 3", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 4", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 5", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 6", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 7", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 8", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 9", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 10", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 11", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 12", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 13", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 14", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 15", typeof(uint), createPercentField: true)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Item_Id}")
            };

            return new MultiStruct("Items", "SafiItemGradeLottery", new MhwMultiStructData(structs, "em104glt"));
        }
    }
}