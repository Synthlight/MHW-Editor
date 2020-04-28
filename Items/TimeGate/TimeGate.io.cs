using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MHW_Editor.Items.TimeGate.Models;
using MHW_Template.Armors;
using MHW_Template.Weapons;

namespace MHW_Editor.Items.TimeGate {
    public partial class TimeGate {
        private List<DateTime> times;
        private List<Weapon>   weapons;
        private List<Armor>    armors;
        private List<Unk1>     unk1;
        private List<Unk2>     unk2;
        private List<Pendant>  pendants;
        private List<ItemTg>   items;
        private List<Unk3>     unk3;

        public void LoadFile(string targetFile) {
            using var reader = new BinaryReader(File.OpenRead(targetFile));

            reader.BaseStream.Seek(6, SeekOrigin.Begin);

            {
                var count = reader.ReadUInt32();
                var arr   = new DateTime[count];
                for (var i = 0; i < count; i++) {
                    var timeT = reader.ReadInt64();
                    arr[i] = new DateTime(1970, 1, 1).AddSeconds(timeT);
                }
                times = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Weapon[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Weapon {
                        Index          = (ulong) i,
                        unlockTime     = times[reader.ReadByte()],
                        weaponCategory = (WeaponType) reader.ReadByte(),
                        weaponId       = reader.ReadUInt32()
                    };
                }
                weapons = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Armor[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Armor {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        armorType  = (ArmorType) reader.ReadByte(),
                        armorId    = reader.ReadUInt32()
                    };
                }
                armors = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Unk1[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Unk1 {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        unk1       = reader.ReadUInt32()
                    };
                }
                unk1 = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Unk2[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Unk2 {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        unk1       = reader.ReadByte(),
                        unk2       = reader.ReadUInt32()
                    };
                }
                unk2 = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Pendant[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Pendant {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        pendantId  = reader.ReadUInt32()
                    };
                }
                pendants = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new ItemTg[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new ItemTg {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        itemId     = reader.ReadUInt32()
                    };
                }
                items = arr.ToList();
            }

            reader.BaseStream.Seek(1, SeekOrigin.Current);

            {
                var count = reader.ReadUInt32();
                var arr   = new Unk3[count];
                for (var i = 0; i < count; i++) {
                    arr[i] = new Unk3 {
                        Index      = (ulong) i,
                        unlockTime = times[reader.ReadByte()],
                        unk1       = reader.ReadByte(),
                        unk2       = reader.ReadUInt32()
                    };
                }
                unk3 = arr.ToList();
            }
        }

        public void SaveFile(string targetFile) {
        }
    }
}