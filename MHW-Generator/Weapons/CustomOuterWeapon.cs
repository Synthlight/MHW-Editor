using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class CustomOuterWeapon : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .cus_ou
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk3", typeof(int)),
                    new MhwMultiStructData.Entry("Unk4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk5", typeof(int)),
                    new MhwMultiStructData.Entry("Unk6", typeof(int)),
                    new MhwMultiStructData.Entry("Unk7", typeof(int)),
                    new MhwMultiStructData.Entry("Unk8", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk9", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk10", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Weapons", "CustomOuterWeapon", new MhwMultiStructData(structs, "cus_ou", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_ou"]));
        }
    }
}