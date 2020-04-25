using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Items {
    public class ArmUp : ISingleStruct {
        public SingleStruct Generate() { // .arm_up
            return new SingleStruct("MHW_Editor.Items", "ArmUp", new MhwStructData {
                size = 22,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Rarity}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Quest Progress 1", 0, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 2", 2, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 3", 4, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 4", 6, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 5", 8, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 6", 10, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 7", 12, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 8", 14, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 9", 16, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 10", 18, typeof(short)),
                    new MhwStructData.Entry("Quest Progress 11", 20, typeof(short))
                }
            });
        }
    }
}