using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;

namespace MHW_Generator.Gems {
    public class DecoLottery : ISingleStruct {
        public SingleStruct Generate() { // .owp_dat
            return new SingleStruct("MHW_Editor.Gems", "DecoLottery", new MhwStructData {
                size = 52,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Item_Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Item Id", 4, typeof(uint), true),
                    new MhwStructData.Entry("Grade 1", 8, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 2", 12, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 3", 16, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 4", 20, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 5", 32, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 6", 36, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 7", 40, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 8", 44, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Grade 9", 48, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Stream (R6)", 24, typeof(uint), createPercentField: true),
                    new MhwStructData.Entry("Stream (R8)", 28, typeof(uint), createPercentField: true)
                }
            });
        }
    }
}