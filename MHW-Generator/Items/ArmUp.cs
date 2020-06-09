using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class ArmUp : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .arm_up
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Quest Progress 1", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 2", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 3", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 4", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 5", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 6", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 7", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 8", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 9", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 10", typeof(short)),
                    new MhwMultiStructData.Entry("Quest Progress 11", typeof(short))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Rarity}")
            };

            return new MultiStruct("MHW_Editor.Items", "ArmUp", new MhwMultiStructData(structs, "arm_up"));
        }
    }
}