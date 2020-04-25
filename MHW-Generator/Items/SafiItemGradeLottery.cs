using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class SafiItemGradeLottery : ISingleStruct {
        public SingleStruct Generate() { // .em104glt
            return new SingleStruct("MHW_Editor.Items", "SafiItemGradeLottery", new MhwStructData {
                size = 68,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item_Id}",
                autoOffset = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", typeof(uint), true),
                    new MhwStructData.Entry("Item Id", typeof(uint), true),
                    new MhwStructData.Entry("Grade 1", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 2", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 3", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 4", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 5", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 6", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 7", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 8", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 9", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 10", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 11", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 12", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 13", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 14", typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 15", typeof(uint), createPercentField: true)
                }
            });
        }
    }
}