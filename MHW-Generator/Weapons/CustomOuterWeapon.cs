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
                    new MhwMultiStructData.Entry("Entry Index", typeof(uint)),
                    new MhwMultiStructData.Entry("Recipe ID", typeof(uint)),
                    new MhwMultiStructData.Entry("Internal ID", typeof(int)),
                    new MhwMultiStructData.Entry("Unk4", typeof(uint)),
                    new MhwMultiStructData.Entry("Weapon ID", typeof(int)),
                    new MhwMultiStructData.Entry("Parts Base", typeof(int)),
                    new MhwMultiStructData.Entry("Parts Decoration", typeof(int)),
                    new MhwMultiStructData.Entry("Unique Model", typeof(int)),
                    new MhwMultiStructData.Entry("Bowgun Data Flag", typeof(short)),
                    new MhwMultiStructData.Entry("Unk11", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk12", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Weapons", "CustomOuterWeapon", new MhwMultiStructData(structs, "cus_ou", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_ou"]));
        }
    }
}