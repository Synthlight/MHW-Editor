using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class QuestReward : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .rem
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 3", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Magic 4", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 5", typeof(uint), true)
                }, 1),

                new MhwMultiStructData.StructData("Items", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), dataSourceType: DataSourceType.Items)
                }, 16),

                new MhwMultiStructData.StructData("Counts", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Count", typeof(byte))
                }, 16),

                new MhwMultiStructData.StructData("Weights", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Weight", typeof(byte))
                }, 16)
            };

            return new MultiStruct("MHW_Editor.Items", "QuestReward", new MhwMultiStructData(structs, "rem"));
        }
    }
}