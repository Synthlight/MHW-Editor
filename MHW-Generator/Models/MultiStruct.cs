using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Models {
    public class MultiStruct {
        public          string             @namespace;
        public          string             className;
        public readonly MhwMultiStructData mhwMultiStructData;

        public MultiStruct(string @namespace, string className, MhwMultiStructData mhwMultiStructData) {
            this.@namespace         = @namespace;
            this.className          = className;
            this.mhwMultiStructData = mhwMultiStructData;
        }
    }
}