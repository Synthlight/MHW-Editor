using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MHW_Editor.Weapons.Collision.Models;
using MHW_Template;

namespace MHW_Editor.Weapons.Collision {
    public partial class Collision {
        public static Models.Collision LoadData(string targetFile) {
            Debug.Assert(Marshal.SizeOf(typeof(Atk1)) == 218);
            Debug.Assert(Marshal.SizeOf(typeof(Atk2)) == 171);
            Debug.Assert(Marshal.SizeOf(typeof(Atk3)) == 199);
            Debug.Assert(Marshal.SizeOf(typeof(ClgmInner)) == 72);
            Debug.Assert(Marshal.SizeOf(typeof(OapInner1)) == 16);
            Debug.Assert(Marshal.SizeOf(typeof(OapInner2)) == 13);
            Debug.Assert(Marshal.SizeOf(typeof(OapInner3)) == 48);

            using var reader = new BinaryReader(File.OpenRead(targetFile));

            var collision = new Models.Collision {
                magicCol1 = reader.ReadUInt32(),
                nameCol = new string(reader.ReadChars(4)),
                magicCol2 = reader.ReadUInt32(),
                unk1 = reader.ReadUInt32(),
                unk2 = reader.ReadUInt32(),
                nameCount = reader.ReadUInt32()
            };
            collision.names = ReadNames(collision.nameCount, reader, targetFile);
            collision.clnd = ReadClnd(reader);
            collision.magicAtk1 = reader.ReadUInt32();
            collision.nameAtk = new string(reader.ReadChars(4));
            collision.magicAtk2 = reader.ReadUInt32();
            collision.atkCount = reader.ReadUInt32();
            collision.atkType = reader.ReadUInt32();
            collision.atks = ReadAtks(collision.atkCount, collision.atkType, reader);
            collision.magicOap1 = reader.ReadUInt32();
            collision.magicOap2 = reader.ReadUInt32();
            collision.nameOap = new string(reader.ReadChars(4));
            collision.magicOap3 = reader.ReadUInt32();
            collision.oapType = reader.ReadUInt32();
            collision.oapInnerCount = reader.ReadUInt32();
            collision.oapInner = ReadOapInners(collision.oapInnerCount, collision.oapType, reader);
            collision.unk10 = reader.ReadUInt32();
            collision.unk11 = reader.ReadUInt32();
            collision.unk12 = reader.ReadUInt32();

            return collision;
        }

        private static List<Name> ReadNames(uint count, BinaryReader reader, string targetFile) {
            var names = new List<Name>();

            for (uint i = 0; i < count; i++) {
                var name = new Name(targetFile);

                var stringBytes = new List<byte>();
                do {
                    stringBytes.Add(reader.ReadByte());
                } while (stringBytes[stringBytes.Count - 1] != 0);

                name.name = Encoding.UTF8.GetString(stringBytes.Subsequence(0, stringBytes.Count).ToArray());

                name.clgmId = reader.ReadInt32();
                name.moveId = reader.ReadInt32();
                name.unk2 = reader.ReadInt32();
                name.unk3 = reader.ReadUInt16();
                name.unk4 = reader.ReadByte();
                name.unk5 = reader.ReadUInt32();

                name.Init();

                names.Add(name);
            }

            return names;
        }

        private static Clnd ReadClnd(BinaryReader reader) {
            var clnd = new Clnd {
                magic1 = reader.ReadUInt32(),
                name = new string(reader.ReadChars(4)),
                magic2 = reader.ReadUInt32(),
                count = reader.ReadUInt32(),
                clgmType = reader.ReadUInt32(),
                unk2 = reader.ReadByte()
            };
            clnd.clgm = ReadClgm(clnd.count, clnd.clgmType, reader);
            clnd.unk3 = reader.ReadByte();
            clnd.unk4 = reader.ReadByte();
            clnd.unk5 = reader.ReadByte();
            return clnd;
        }

        private static List<Clgm> ReadClgm(uint count, uint type, BinaryReader reader) {
            var clgms = new List<Clgm>();

            for (var i = 0; i < count; i++) {
                var clgm = new Clgm {
                    magic1 = reader.ReadUInt32(),
                    name = new string(reader.ReadChars(4)),
                    magic2 = reader.ReadUInt32(),
                    count = reader.ReadUInt32(),
                };
                clgm.clgmInner = ReadClgmInner(clgm.count, reader);
                clgm.unk1 = reader.ReadUInt32();
                clgm.unk2 = reader.ReadUInt32();
                clgm.unk3 = reader.ReadByte();
                clgm.unk4 = reader.ReadByte();
                clgm.unk5 = reader.ReadByte();
                clgm.unk6 = reader.ReadByte();
                clgm.unk7 = reader.ReadUInt32();
                clgm.unk8 = reader.ReadUInt32();
                clgm.unk9 = reader.ReadInt16();
                clgm.unk10 = reader.ReadUInt16();
                clgm.unk11 = reader.ReadUInt16();

                if (type == 2) {
                    clgm.unk12 = reader.ReadInt32();
                    clgm.unk13 = reader.ReadInt32();
                    clgm.unk14 = reader.ReadInt32();
                    clgm.unk15 = reader.ReadInt32();
                    clgm.unk16 = reader.ReadInt32();
                    clgm.unk17 = reader.ReadInt32();
                    clgm.unk18 = reader.ReadInt32();
                    clgm.unk19 = reader.ReadInt32();
                }

                clgm.unk20 = reader.ReadByte();

                clgms.Add(clgm);
            }

            return clgms;
        }

        private static List<ClgmInner> ReadClgmInner(uint count, BinaryReader reader) {
            var clgmInners = new List<ClgmInner>();

            for (var i = 0; i < count; i++) {
                var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(ClgmInner)));

                clgmInners.Add(bytes.GetDataAs<ClgmInner>());
            }

            return clgmInners;
        }

        private static List<dynamic> ReadAtks(uint count, uint type, BinaryReader reader) {
            var atks = new List<dynamic>();

            for (var i = 0; i < count; i++) {
                if (type == 1) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(Atk1)));
                    atks.Add(bytes.GetDataAs<Atk1>());
                } else if (type == 2) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(Atk2)));
                    atks.Add(bytes.GetDataAs<Atk2>());
                } else if (type == 3) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(Atk3)));
                    atks.Add(bytes.GetDataAs<Atk3>());
                } else {
                    throw new InvalidOperationException($"Unknown attack type: {type}");
                }
            }

            return atks;
        }

        private static List<dynamic> ReadOapInners(uint count, uint type, BinaryReader reader) {
            var oaps = new List<dynamic>();

            for (var i = 0; i < count; i++) {
                if (type == 1) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(OapInner1)));
                    oaps.Add(bytes.GetDataAs<OapInner1>());
                } else if (type == 2) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(OapInner2)));
                    oaps.Add(bytes.GetDataAs<OapInner2>());
                } else if (type == 3) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(OapInner3)));
                    oaps.Add(bytes.GetDataAs<OapInner3>());
                } else {
                    throw new InvalidOperationException($"Unknown oap inner type: {type}");
                }
            }

            return oaps;
        }

        public static void SaveData(Models.Collision collision, string targetFile) {
            using var writer = new BinaryWriter(File.Open(targetFile, FileMode.Create, FileAccess.Write));

            writer.Write(collision.magicCol1);
            writer.Write(collision.nameCol.ToCharArray());
            writer.Write(collision.magicCol2);
            writer.Write(collision.unk1);
            writer.Write(collision.unk2);
            writer.Write(collision.nameCount);
            WriteNames(collision.names, writer);
            WriteClnd(collision.clnd, writer);
            writer.Write(collision.magicAtk1);
            writer.Write(collision.nameAtk.ToCharArray());
            writer.Write(collision.magicAtk2);
            writer.Write(collision.atkCount);
            writer.Write(collision.atkType);
            WriteAtks(collision.atks, collision.atkType, writer);
            writer.Write(collision.magicOap1);
            writer.Write(collision.magicOap2);
            writer.Write(collision.nameOap.ToCharArray());
            writer.Write(collision.magicOap3);
            writer.Write(collision.oapType);
            writer.Write(collision.oapInnerCount);
            WriteOapInners(collision.oapInner, collision.oapType, writer);
            writer.Write(collision.unk10);
            writer.Write(collision.unk11);
            writer.Write(collision.unk12);
        }

        private static void WriteNames(IEnumerable<Name> names, BinaryWriter writer) {
            foreach (var name in names) {
                writer.Write(name.name.ToCharArray());
                writer.Write(name.clgmId);
                writer.Write(name.moveId);
                writer.Write(name.unk2);
                writer.Write(name.unk3);
                writer.Write(name.unk4);
                writer.Write(name.unk5);
            }
        }

        private static void WriteClnd(Clnd clnd, BinaryWriter writer) {
            writer.Write(clnd.magic1);
            writer.Write(clnd.name.ToCharArray());
            writer.Write(clnd.magic2);
            writer.Write(clnd.count);
            writer.Write(clnd.clgmType);
            writer.Write(clnd.unk2);
            WriteClgm(clnd.clgm, clnd.clgmType, writer);
            writer.Write(clnd.unk3);
            writer.Write(clnd.unk4);
            writer.Write(clnd.unk5);
        }

        private static void WriteClgm(IEnumerable<Clgm> clgms, uint type, BinaryWriter writer) {
            foreach (var clgm in clgms) {
                writer.Write(clgm.magic1);
                writer.Write(clgm.name.ToCharArray());
                writer.Write(clgm.magic2);
                writer.Write(clgm.count);
                WriteClgmInner(clgm.clgmInner, writer);
                writer.Write(clgm.unk1);
                writer.Write(clgm.unk2);
                writer.Write(clgm.unk3);
                writer.Write(clgm.unk4);
                writer.Write(clgm.unk5);
                writer.Write(clgm.unk6);
                writer.Write(clgm.unk7);
                writer.Write(clgm.unk8);
                writer.Write(clgm.unk9);
                writer.Write(clgm.unk10);
                writer.Write(clgm.unk11);

                if (type == 2) {
                    writer.Write(clgm.unk12);
                    writer.Write(clgm.unk13);
                    writer.Write(clgm.unk14);
                    writer.Write(clgm.unk15);
                    writer.Write(clgm.unk16);
                    writer.Write(clgm.unk17);
                    writer.Write(clgm.unk18);
                    writer.Write(clgm.unk19);
                }

                writer.Write(clgm.unk20);
            }
        }

        private static void WriteClgmInner(IEnumerable<ClgmInner> clgmInners, BinaryWriter writer) {
            foreach (var clgmInner in clgmInners) {
                var bytes = clgmInner.GetBytes();

                writer.Write(bytes);
            }
        }

        private static void WriteAtks(IEnumerable<dynamic> atks, uint type, BinaryWriter writer) {
            foreach (var atk in atks) {
                byte[] bytes;
                if (type == 1) {
                    bytes = ((Atk1) atk).GetBytes();
                } else if (type == 2) {
                    bytes = ((Atk2) atk).GetBytes();
                } else if (type == 3) {
                    bytes = ((Atk3) atk).GetBytes();
                } else {
                    throw new InvalidOperationException($"Unknown attack type: {type}");
                }

                writer.Write(bytes);
            }
        }

        private static void WriteOapInners(IEnumerable<dynamic> oaps, uint type, BinaryWriter writer) {
            foreach (var oap in oaps) {
                byte[] bytes;
                if (type == 1) {
                    bytes = ((OapInner1) oap).GetBytes();
                } else if (type == 2) {
                    bytes = ((OapInner2) oap).GetBytes();
                } else if (type == 3) {
                    bytes = ((OapInner3) oap).GetBytes();
                } else {
                    throw new InvalidOperationException($"Unknown oap inner type: {type}");
                }

                writer.Write(bytes);
            }
        }
    }
}