using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.PlData {
    public class PlMusicSkillParam : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .mske
            var structs = new List<MhwMultiStructData.StructData> {
                new MhwMultiStructData.StructData("Header", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Magic 1", typeof(uint), true),
                    new MhwMultiStructData.Entry("Magic 2", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Entry Count", typeof(uint), true).Out(out var itemCount),
                    new MhwMultiStructData.Entry("Magic 3", typeof(uint), true)
                }, 1).Out(out var header),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Duration", typeof(float)),
                    new MhwMultiStructData.Entry("Extension", typeof(float)),
                    new MhwMultiStructData.Entry("M1 Duration", typeof(float)),
                    new MhwMultiStructData.Entry("M1 Extension", typeof(float)),
                    new MhwMultiStructData.Entry("M2 Duration", typeof(float)),
                    new MhwMultiStructData.Entry("M2 Extension", typeof(float)),
                    new MhwMultiStructData.Entry("Effect", typeof(float)),
                    new MhwMultiStructData.Entry("Recast Effect", typeof(float)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(uint))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.PlData", "PlMusicSkillParam", new MhwMultiStructData(structs, "mske", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".mske"]));
        }
    }
}