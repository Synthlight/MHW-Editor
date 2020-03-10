using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Clgm {
        [DisplayName("Magic 1")]
        [SortOrder(10)]
        public uint magic1 { get; set; }

        [DisplayName("Type")]
        [SortOrder(20)]
        public string name { get; set; } // Exactly 4 chars in length.

        [DisplayName("Magic 2")]
        [SortOrder(30)]
        public uint magic2 { get; set; }

        [DisplayName("Array Count")]
        [SortOrder(40)]
        public uint count { get; set; }

        [DisplayName("CLGM Inner[]")]
        [SortOrder(50)]
        public List<ClgmInner> clgmInner { get; set; } // count

        [SortOrder(60)]
        public uint unk1 { get; set; }

        [SortOrder(70)]
        public uint unk2 { get; set; }

        [SortOrder(80)]
        public byte unk3 { get; set; }

        [SortOrder(90)]
        public byte unk4 { get; set; }

        [SortOrder(100)]
        public byte unk5 { get; set; }

        [SortOrder(110)]
        public byte unk6 { get; set; }

        [SortOrder(120)]
        public uint unk7 { get; set; }

        [SortOrder(130)]
        public uint unk8 { get; set; }

        [SortOrder(140)]
        public short unk9 { get; set; }

        [SortOrder(150)]
        public ushort unk10 { get; set; }

        [SortOrder(160)]
        public ushort unk11 { get; set; }

        [SortOrder(170)]
        public byte unk12 { get; set; }
    }
}