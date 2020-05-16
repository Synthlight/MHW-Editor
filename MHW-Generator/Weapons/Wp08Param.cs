using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Multi;

namespace MHW_Generator.Weapons {
    public class Wp08Param : WpParamBase, IMultiStruct {
        private const string N = "08";

        public MultiStruct Generate() { // .w08p
            var structs = new List<MhwMultiStructData.StructData>();
            structs.AddRange(CreateBase(N));

            structs.AddRange(new List<MhwMultiStructData.StructData> {
            });

            return new MultiStruct("MHW_Editor.Weapons", $"Wp{N}Param", new MhwMultiStructData(structs, $"w{N}p", EncryptionKeys.FILE_EXT_KEY_LOOKUP[$".w{N}p"]));
        }
    }
}