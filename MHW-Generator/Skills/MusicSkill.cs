using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Skills {
    public class MusicSkill : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .msk
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Song Id Raw", typeof(uint), true),
                    new MhwMultiStructData.Entry("Note 1", typeof(int), enumReturn: typeof(NoteColorWithDisabled)),
                    new MhwMultiStructData.Entry("Note 2", typeof(int), enumReturn: typeof(NoteColorWithDisabled)),
                    new MhwMultiStructData.Entry("Note 3", typeof(int), enumReturn: typeof(NoteColorWithDisabled)),
                    new MhwMultiStructData.Entry("Note 4", typeof(int), enumReturn: typeof(NoteColorWithDisabled))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Song_Id_Raw}")
            };

            return new MultiStruct("MHW_Editor.Skills", "MusicSkill", new MhwMultiStructData(structs, "msk", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".msk"]));
        }
    }
}