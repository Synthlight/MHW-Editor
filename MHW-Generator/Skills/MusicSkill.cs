using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Skills {
    public class MusicSkill : ISingleStruct {
        public SingleStruct Generate() { // .msk
            return new SingleStruct("MHW_Editor.Skills", "MusicSkill", new MhwStructData {
                size = 20,
                offsetInitial = 10,
                entryCountOffset = 6,
                encryptionKey = EncryptionKeys.MSK_KEY,
                uniqueIdFormula = "{Song_Id_Raw}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Song Id Raw", 0, typeof(uint), true),
                    new MhwStructData.Entry("Note 1", 4, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 2", 8, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 3", 12, typeof(int), typeof(NoteColorWithDisabled)),
                    new MhwStructData.Entry("Note 4", 16, typeof(int), typeof(NoteColorWithDisabled))
                }
            });
        }
    }
}