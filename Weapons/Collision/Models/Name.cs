using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Name {
        [DisplayName("Index")]
        [SortOrder(10)]
        public string name { get; set; } // Null terminated.

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