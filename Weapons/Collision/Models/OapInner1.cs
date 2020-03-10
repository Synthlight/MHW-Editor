using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class OapInner1 : IOapInner { // 16
        [SortOrder(10)]
        public uint unk1 { get; set; }

        [SortOrder(20)]
        public int unk2 { get; set; }

        [SortOrder(30)]
        public uint unk3 { get; set; }

        [SortOrder(40)]
        public uint unk4 { get; set; }
    }
}