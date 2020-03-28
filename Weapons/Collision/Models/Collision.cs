using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Collision.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Collision {
        [IsReadOnly]
        [DisplayName("Magic (COL) 1")]
        [SortOrder(10)]
        public uint magicCol1 { get; set; }

        [IsReadOnly]
        [DisplayName("COL")]
        [SortOrder(20)]
        public string nameCol { get; set; } // COL, Exactly 4 chars in length.

        [IsReadOnly]
        [DisplayName("Magic (COL) 2")]
        [SortOrder(30)]
        public uint magicCol2 { get; set; }

        [IsReadOnly]
        [SortOrder(40)]
        public uint unk1 { get; set; }

        [IsReadOnly]
        [SortOrder(50)]
        public uint unk2 { get; set; }

        [IsReadOnly]
        [DisplayName("Name Count")]
        [SortOrder(60)]
        public uint nameCount { get; set; }

        [IsReadOnly]
        [DisplayName("Names[]")]
        [SortOrder(70)]
        public List<Name> names { get; set; } // nameCount

        [IsReadOnly]
        [DisplayName("CLND")]
        [SortOrder(80)]
        public Clnd clnd { get; set; }

        [IsReadOnly]
        [DisplayName("Magic (ATK) 1")]
        [SortOrder(90)]
        public uint magicAtk1 { get; set; }

        [IsReadOnly]
        [DisplayName("ATK")]
        [SortOrder(100)]
        public string nameAtk { get; set; } // ATK, Exactly 4 chars in length.

        [IsReadOnly]
        [DisplayName("Magic (ATK) 2")]
        [SortOrder(110)]
        public uint magicAtk2 { get; set; }

        [IsReadOnly]
        [DisplayName("ATK Count")]
        [SortOrder(120)]
        public uint atkCount { get; set; }

        [IsReadOnly]
        [DisplayName("ATK Type")]
        [SortOrder(130)]
        public uint atkType { get; set; }

        [IsReadOnly]
        [DisplayName("ATKs[]")]
        [SortOrder(140)]
        public List<dynamic> atks { get; set; } // atkCount

        [IsReadOnly]
        [DisplayName("Magic (OAP) 1")]
        [SortOrder(150)]
        public uint magicOap1 { get; set; }

        [IsReadOnly]
        [DisplayName("Magic (OAP) 2")]
        [SortOrder(160)]
        public uint magicOap2 { get; set; }

        [IsReadOnly]
        [DisplayName("OAP")]
        [SortOrder(170)]
        public string nameOap { get; set; } // OAP, Exactly 4 chars in length.

        [IsReadOnly]
        [DisplayName("Magic (OAP) 3")]
        [SortOrder(180)]
        public uint magicOap3 { get; set; }

        [IsReadOnly]
        [DisplayName("OAP Type")]
        [SortOrder(190)]
        public uint oapType { get; set; }

        [IsReadOnly]
        [SortOrder(200)]
        public uint oapInnerCount { get; set; }

        [IsReadOnly]
        [SortOrder(210)]
        public List<dynamic> oapInner { get; set; } // oapInnerCount
    }
}