using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MHW_Weapon_Editor.Gems {
    public class Gem : IMhwItem {
        public const int GEM_SIZE = 28;
        public const int GEM_OFFSET_INITIAL = 6;
        public const int GEM_OFFSET_BETWEEN = GEM_SIZE;

        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte SkillLevel { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }

        public int Offset { get; set; }

        public static Gem FromByteArray(byte[] buff) {
            if (buff.Length < GEM_SIZE) return null;

            return new Gem {
                Unknown1 = buff[Offsets.UNKNOWN1],
                Unknown2 = buff[Offsets.UNKNOWN2],
                Unknown3 = buff[Offsets.UNKNOWN3],
                Unknown4 = buff[Offsets.UNKNOWN4],
                Unknown5 = buff[Offsets.UNKNOWN5],
                Unknown6 = buff[Offsets.UNKNOWN6],
                Unknown7 = buff[Offsets.UNKNOWN7],
                Unknown8 = buff[Offsets.UNKNOWN8],
                Unknown9 = buff[Offsets.UNKNOWN9],
                Unknown10 = buff[Offsets.UNKNOWN10],
                Unknown11 = buff[Offsets.UNKNOWN11],
                Unknown12 = buff[Offsets.UNKNOWN12],
                Unknown13 = buff[Offsets.UNKNOWN13],
                Unknown14 = buff[Offsets.UNKNOWN14],
                Unknown15 = buff[Offsets.UNKNOWN15],
                Unknown16 = buff[Offsets.UNKNOWN16],
                SkillLevel = buff[Offsets.SKILL_LEVEL],
                Unknown18 = buff[Offsets.UNKNOWN18],
                Unknown19 = buff[Offsets.UNKNOWN19],
                Unknown20 = buff[Offsets.UNKNOWN20],
                Unknown21 = buff[Offsets.UNKNOWN21],
                Unknown22 = buff[Offsets.UNKNOWN22],
                Unknown23 = buff[Offsets.UNKNOWN23],
                Unknown24 = buff[Offsets.UNKNOWN24],
                Unknown25 = buff[Offsets.UNKNOWN25],
                Unknown26 = buff[Offsets.UNKNOWN26],
                Unknown27 = buff[Offsets.UNKNOWN27],
                Unknown28 = buff[Offsets.UNKNOWN28]
            };
        }

        public byte[] ToByteArray() {
            var buff = new byte[GEM_SIZE];
            buff[Offsets.UNKNOWN1] = Unknown1;
            buff[Offsets.UNKNOWN2] = Unknown2;
            buff[Offsets.UNKNOWN3] = Unknown3;
            buff[Offsets.UNKNOWN4] = Unknown4;
            buff[Offsets.UNKNOWN5] = Unknown5;
            buff[Offsets.UNKNOWN6] = Unknown6;
            buff[Offsets.UNKNOWN7] = Unknown7;
            buff[Offsets.UNKNOWN8] = Unknown8;
            buff[Offsets.UNKNOWN9] = Unknown9;
            buff[Offsets.UNKNOWN10] = Unknown10;
            buff[Offsets.UNKNOWN11] = Unknown11;
            buff[Offsets.UNKNOWN12] = Unknown12;
            buff[Offsets.UNKNOWN13] = Unknown13;
            buff[Offsets.UNKNOWN14] = Unknown14;
            buff[Offsets.UNKNOWN15] = Unknown15;
            buff[Offsets.UNKNOWN16] = Unknown16;
            buff[Offsets.SKILL_LEVEL] = SkillLevel;
            buff[Offsets.UNKNOWN18] = Unknown18;
            buff[Offsets.UNKNOWN19] = Unknown19;
            buff[Offsets.UNKNOWN20] = Unknown20;
            buff[Offsets.UNKNOWN21] = Unknown21;
            buff[Offsets.UNKNOWN22] = Unknown22;
            buff[Offsets.UNKNOWN23] = Unknown23;
            buff[Offsets.UNKNOWN24] = Unknown24;
            buff[Offsets.UNKNOWN25] = Unknown25;
            buff[Offsets.UNKNOWN26] = Unknown26;
            buff[Offsets.UNKNOWN27] = Unknown27;
            buff[Offsets.UNKNOWN28] = Unknown28;
            return buff;
        }

        public static class Offsets {
            public const int UNKNOWN1 = 0;
            public const int UNKNOWN2 = 1;
            public const int UNKNOWN3 = 2;
            public const int UNKNOWN4 = 3;
            public const int UNKNOWN5 = 4;
            public const int UNKNOWN6 = 5;
            public const int UNKNOWN7 = 6;
            public const int UNKNOWN8 = 7;
            public const int UNKNOWN9 = 8;
            public const int UNKNOWN10 = 9;
            public const int UNKNOWN11 = 10;
            public const int UNKNOWN12 = 11;
            public const int UNKNOWN13 = 12;
            public const int UNKNOWN14 = 13;
            public const int UNKNOWN15 = 14;
            public const int UNKNOWN16 = 15;
            public const int SKILL_LEVEL = 16;
            public const int UNKNOWN18 = 17;
            public const int UNKNOWN19 = 18;
            public const int UNKNOWN20 = 19;
            public const int UNKNOWN21 = 20;
            public const int UNKNOWN22 = 21;
            public const int UNKNOWN23 = 22;
            public const int UNKNOWN24 = 23;
            public const int UNKNOWN25 = 24;
            public const int UNKNOWN26 = 25;
            public const int UNKNOWN27 = 26;
            public const int UNKNOWN28 = 27;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}