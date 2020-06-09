using MHW_Template.Struct_Generation;

namespace MHW_Generator.Models {
    public class MultiStruct {
        public          string             category;
        public          string             className;
        public readonly MhwMultiStructData mhwMultiStructData;

        public MultiStruct(string category, string className, MhwMultiStructData mhwMultiStructData) {
            this.category           = category;
            this.className          = className;
            this.mhwMultiStructData = mhwMultiStructData;
        }
    }
}