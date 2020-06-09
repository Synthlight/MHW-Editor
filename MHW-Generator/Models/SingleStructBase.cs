using System.Collections.Generic;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Models {
    public abstract class SingleStructBase {
        protected static MhwMultiStructData.StructData CreateSingleStructBase(out MhwMultiStructData.StructData header, out MhwMultiStructData.Entry entryCount) {
            return new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                new MhwMultiStructData.Entry("Magic 2", typeof(ushort), true),
                new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out entryCount)
            }, 1).Out(out header);
        }
    }
}