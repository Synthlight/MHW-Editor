using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Name {
        private readonly string targetFile;

        public Name(string targetFile) {
            this.targetFile = targetFile;
        }

        public void Init() {
            if (string.IsNullOrEmpty(name)) return;

            foreach (var key in DataHelper.collisionTranslationsData.Keys) {
                if (targetFile.EndsWith(key)) {
                    var nameDescPair = DataHelper.collisionTranslationsData[key].TryGet(moveId, null);
                    if (nameDescPair == null) return;
                    TranslatedName = nameDescPair.name;
                    if (TranslatedName == "") TranslatedName = name;
                    Description = nameDescPair.description;
                    if (Description == "guess dummy") Description = "Unused?";
                }
            }
        }

        [DisplayName("")]
        [SortOrder(10)]
        public string name { get; set; } // Null terminated.

        [DisplayName("Name")]
        [SortOrder(10)]
        public string TranslatedName { get; private set; }

        [SortOrder(11)]
        public string Description { get; private set; }

        [SortOrder(20)]
        public int unk1 { get; set; }

        [DisplayName("Move Id")]
        [SortOrder(30)]
        public int moveId { get; set; }

        [SortOrder(40)]
        public int unk2 { get; set; }

        [SortOrder(50)]
        public ushort unk3 { get; set; }

        [SortOrder(60)]
        public byte unk4 { get; set; }

        [SortOrder(70)]
        public uint unk5 { get; set; }
    }
}