using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Models {
    public class SingleStruct {
        public string        @namespace;
        public string        className;
        public MhwStructData mhwStructData;

        public SingleStruct(string @namespace, string className, MhwStructData mhwStructData) {
            this.@namespace    = @namespace;
            this.className     = className;
            this.mhwStructData = mhwStructData;
        }
    }
}