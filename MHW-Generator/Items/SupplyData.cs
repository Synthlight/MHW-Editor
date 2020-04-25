using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Items {
    public class SupplyData : IMultiStruct {
        public MultiStruct Generate() { // .supp
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Supply Data", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 3", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Supply Id", typeof(uint))
                }, 1),

                new MhwMultiStructData.StructData("Item Box", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Item Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Item Count", typeof(ushort))
                }, 24),

                new MhwMultiStructData.StructData("Item Box Scaling", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Items to Show", typeof(byte))
                }, 3),

                new MhwMultiStructData.StructData("Ammo Box", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Ammo Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Ammo Count", typeof(ushort))
                }, 16),

                new MhwMultiStructData.StructData("Ammo Box Scaling", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Ammo Items to Show", typeof(byte))
                }, 3)
            };

            return new MultiStruct("MHW_Editor.Items", "SupplyData", new MhwMultiStructData(structs, "supp"));
        }
    }
}