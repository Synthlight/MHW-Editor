using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Models {
    public class VerticalStruct {
        private const string SPACER_TEXT = "-------------------------------------------------------------------------------------------";
        public static MhwStructData.Entry Spacer => new MhwStructData.Entry(SPACER_TEXT, 3, typeof(byte), true, forceUnique: true);

        public string @namespace;
        public string className;
        public readonly MhwStructData mhwStructData;

        public VerticalStruct(string @namespace, string className, MhwStructData mhwStructData) {
            this.@namespace = @namespace;
            this.className = className;
            this.mhwStructData = mhwStructData;
        }
    }
}