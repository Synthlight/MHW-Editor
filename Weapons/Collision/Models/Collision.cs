using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public struct Collision {
        [DisplayName("Magic (COL) 1")]
        [SortOrder(10)]
        public uint magicCol1 { get; set; }

        [DisplayName("COL")]
        [SortOrder(20)]
        public string nameCol { get; set; } // COL, Exactly 4 chars in length.

        [DisplayName("Magic (COL) 2")]
        [SortOrder(30)]
        public uint magicCol2 { get; set; }

        [SortOrder(40)]
        public uint unk1 { get; set; }

        [SortOrder(50)]
        public uint unk2 { get; set; }

        [DisplayName("Name Count")]
        [SortOrder(60)]
        public uint nameCount { get; set; }

        [DisplayName("Names[]")]
        [SortOrder(70)]
        public List<Name> names { get; set; } // nameCount

        [DisplayName("CLND")]
        [SortOrder(80)]
        public Clnd clnd { get; set; }

        [DisplayName("Magic (ATK) 1")]
        [SortOrder(90)]
        public uint magicAtk1 { get; set; }

        [DisplayName("ATK")]
        [SortOrder(100)]
        public string nameAtk { get; set; } // ATK, Exactly 4 chars in length.

        [DisplayName("Magic (ATK) 2")]
        [SortOrder(110)]
        public uint magicAtk2 { get; set; }

        [DisplayName("ATK Count")]
        [SortOrder(120)]
        public uint atkCount { get; set; }

        [DisplayName("ATK Type")]
        [SortOrder(130)]
        public uint atkType { get; set; }

        // if (atkType == 1) ATK1
        // if (atkType == 3) ATK3
        [DisplayName("ATKs[]")]
        [SortOrder(140)]
        public List<dynamic> atks { get; set; } // atkCount

        [DisplayName("Magic (OAP) 1")]
        [SortOrder(150)]
        public uint magicOap1 { get; set; }

        [DisplayName("Magic (OAP) 2")]
        [SortOrder(160)]
        public uint magicOap2 { get; set; }

        [DisplayName("OAP")]
        [SortOrder(170)]
        public string nameOap { get; set; } // OAP, Exactly 4 chars in length.

        [DisplayName("Magic (OAP) 3")]
        [SortOrder(180)]
        public uint magicOap3 { get; set; }

        [DisplayName("OAP Type")]
        [SortOrder(190)]
        public uint oapType { get; set; }

        [SortOrder(200)]
        public uint unk4 { get; set; }

        [SortOrder(210)]
        public uint unk5 { get; set; }

        [SortOrder(220)]
        public ushort unk6 { get; set; }

        [SortOrder(230)]
        public ushort unk7 { get; set; }

        [SortOrder(240)]
        public uint unk8 { get; set; }

        // if (oapType > 0)
        [SortOrder(250)]
        public uint unk9 { get; set; }

        [SortOrder(260)]
        public uint unk10 { get; set; }

        [SortOrder(270)]
        public ushort unk11 { get; set; }

        [SortOrder(280)]
        public short unk12 { get; set; }

        [SortOrder(290)]
        public uint unk13 { get; set; }

        // if (oapType > 1)
        [SortOrder(300)]
        public uint unk14 { get; set; }

        [SortOrder(310)]
        public uint unk15 { get; set; }

        [SortOrder(320)]
        public uint unk16 { get; set; }

        [SortOrder(330)]
        public uint unk17 { get; set; }
    }
}