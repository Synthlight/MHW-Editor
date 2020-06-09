using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class KulveGradeLottery : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em117glt
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var itemCount)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Item Id", typeof(uint), true, dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Grade 1", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 2", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 3", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 4", typeof(uint), createPercentField: true),
                    new MhwMultiStructData.Entry("Grade 5", typeof(uint), createPercentField: true)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Item_Id}")
            };

            return new MultiStruct("MHW_Editor.Items", "KulveGradeLottery", new MhwMultiStructData(structs, "em117glt"));
        }
    }
}