using System.ComponentModel;
using System.Runtime.InteropServices;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons.Shlp.Models {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
    public class Shlp {
        [IsReadOnly]
        [DisplayName("Magic (SLP) 1")]
        [SortOrder(10)]
        public uint magicSlp1 { get; set; }

        [IsReadOnly]
        [DisplayName("SLP")]
        [SortOrder(20)]
        public string nameSlp { get; set; } // SLP, Exactly 4 chars in length.

        [IsReadOnly]
        [DisplayName("Magic (SLP) 2")]
        [SortOrder(30)]
        public uint magicSlp2 { get; set; }

        [DisplayName("Mod Header")]
        [SortOrder(40)]
        public uint modHeader { get; set; }

        [DisplayName("Mod Path")]
        [SortOrder(50)]
        public string modPath { get; set; } // If assetHeader != 0.

        // Epv Assets

        [DisplayName("Epv1 Header")]
        [SortOrder(60)]
        public uint epv1Header { get; set; }

        [DisplayName("Epv1 Path")]
        [SortOrder(70)]
        public string epv1Path { get; set; } // If epv1Header != 0.

        [DisplayName("Epv2 Header")]
        [SortOrder(80)]
        public uint epv2Header { get; set; }

        [DisplayName("Epv2 Path")]
        [SortOrder(90)]
        public string epv2Path { get; set; } // If epv2Header != 0.

        [DisplayName("Epv3 Header")]
        [SortOrder(100)]
        public uint epv3Header { get; set; }

        [DisplayName("Epv3 Path")]
        [SortOrder(110)]
        public string epv3Path { get; set; } // If epv3Header != 0.

        [DisplayName("Epv4 Header")]
        [SortOrder(120)]
        public uint epv4Header { get; set; }

        [DisplayName("Epv4 Path")]
        [SortOrder(130)]
        public string epv4Path { get; set; } // If epv4Header != 0.

        [DisplayName("Epv5 Header")]
        [SortOrder(140)]
        public uint epv5Header { get; set; }

        [DisplayName("Epv5 Path")]
        [SortOrder(150)]
        public string epv5Path { get; set; } // If epv5Header != 0.

        [DisplayName("Epv6 Header")]
        [SortOrder(160)]
        public uint epv6Header { get; set; }

        [DisplayName("Epv6 Path")]
        [SortOrder(170)]
        public string epv6Path { get; set; } // If epv6Header != 0.

        [DisplayName("Epv7 Header")]
        [SortOrder(180)]
        public uint epv7Header { get; set; }

        [DisplayName("Epv7 Path")]
        [SortOrder(190)]
        public string epv7Path { get; set; } // If epv7Header != 0.

        [DisplayName("Epv8 Header")]
        [SortOrder(200)]
        public uint epv8Header { get; set; }

        [DisplayName("Epv8 Path")]
        [SortOrder(210)]
        public string epv8Path { get; set; } // If epv8Header != 0.

        [DisplayName("Epv9 Header")]
        [SortOrder(220)]
        public uint epv9Header { get; set; }

        [DisplayName("Epv9 Path")]
        [SortOrder(230)]
        public string epv9Path { get; set; } // If epv9Header != 0.

        [DisplayName("Epv10 Header")]
        [SortOrder(240)]
        public uint epv10Header { get; set; }

        [DisplayName("Epv10 Path")]
        [SortOrder(250)]
        public string epv10Path { get; set; } // If epv10Header != 0.

        [DisplayName("Epv11 Header")]
        [SortOrder(260)]
        public uint epv11Header { get; set; }

        [DisplayName("Epv11 Path")]
        [SortOrder(270)]
        public string epv11Path { get; set; } // If epv11Header != 0.

        [DisplayName("Epv12 Header")]
        [SortOrder(280)]
        public uint epv12Header { get; set; }

        [DisplayName("Epv12 Path")]
        [SortOrder(290)]
        public string epv12Path { get; set; } // If epv12Header != 0.

        // Sound Assets

        [DisplayName("Sound1 Header")]
        [SortOrder(300)]
        public uint sound1Header { get; set; }

        [DisplayName("Sound1 Path")]
        [SortOrder(310)]
        public string sound1Path { get; set; } // If sound1Header != 0.

        [DisplayName("Sound2 Header")]
        [SortOrder(320)]
        public uint sound2Header { get; set; }

        [DisplayName("Sound2 Path")]
        [SortOrder(330)]
        public string sound2Path { get; set; } // If sound2Header != 0.

        [DisplayName("Sound3 Header")]
        [SortOrder(340)]
        public uint sound3Header { get; set; }

        [DisplayName("Sound3 Path")]
        [SortOrder(350)]
        public string sound3Path { get; set; } // If sound3Header != 0.

        [DisplayName("Sound4 Header")]
        [SortOrder(360)]
        public uint sound4Header { get; set; }

        [DisplayName("Sound4 Path")]
        [SortOrder(370)]
        public string sound4Path { get; set; } // If sound4Header != 0.

        [DisplayName("Sound5 Header")]
        [SortOrder(380)]
        public uint sound5Header { get; set; }

        [DisplayName("Sound5 Path")]
        [SortOrder(390)]
        public string sound5Path { get; set; } // If sound5Header != 0.

        [DisplayName("Sound6 Header")]
        [SortOrder(400)]
        public uint sound6Header { get; set; }

        [DisplayName("Sound6 Path")]
        [SortOrder(410)]
        public string sound6Path { get; set; } // If sound6Header != 0.

        [DisplayName("Sound7 Header")]
        [SortOrder(420)]
        public uint sound7Header { get; set; }

        [DisplayName("Sound7 Path")]
        [SortOrder(430)]
        public string sound7Path { get; set; } // If sound7Header != 0.

        [DisplayName("Sound8 Header")]
        [SortOrder(440)]
        public uint sound8Header { get; set; }

        [DisplayName("Sound8 Path")]
        [SortOrder(450)]
        public string sound8Path { get; set; } // If sound8Header != 0.

        [DisplayName("Sound9 Header")]
        [SortOrder(460)]
        public uint sound9Header { get; set; }

        [DisplayName("Sound9 Path")]
        [SortOrder(470)]
        public string sound9Path { get; set; } // If sound9Header != 0.

        [DisplayName("Sound10 Header")]
        [SortOrder(480)]
        public uint sound10Header { get; set; }

        [DisplayName("Sound10 Path")]
        [SortOrder(490)]
        public string sound10Path { get; set; } // If sound10Header != 0.

        [DisplayName("Sound11 Header")]
        [SortOrder(500)]
        public uint sound11Header { get; set; }

        [DisplayName("Sound11 Path")]
        [SortOrder(510)]
        public string sound11Path { get; set; } // If sound11Header != 0.

        [DisplayName("Sound12 Header")]
        [SortOrder(520)]
        public uint sound12Header { get; set; }

        [DisplayName("Sound12 Path")]
        [SortOrder(530)]
        public string sound12Path { get; set; } // If sound12Header != 0.

        [DisplayName("Projectile Particle Id")]
        [SortOrder(540)]
        public uint projectileParticleId { get; set; } //No clue about particles but, caused particles to change

        [DisplayName("Projectile Particle Sub Id")]
        [SortOrder(550)]
        public uint projectileParticleSubId { get; set; } // trying out ID 2003 and SubID 101 makes snipe_hit_3 particles(smoky), ID 2001 and SubID 0 is normal ammo 1 particles

        [DisplayName("Unk1")]
        [SortOrder(560)]
        public uint unk1 { get; set; }

        [DisplayName("Unk2")]
        [SortOrder(570)]
        public uint unk2 { get; set; }

        [DisplayName("Unk3")]
        [SortOrder(580)]
        public uint unk3 { get; set; }
    }
}