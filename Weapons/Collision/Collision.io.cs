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
            Debug.Assert(Marshal.SizeOf(typeof(Atk3)) == 199);
            Debug.Assert(Marshal.SizeOf(typeof(ClgmInner)) == 72);

            using var reader = new BinaryReader(File.OpenRead(targetFile));

            // TODO: Fix for these files:
            // chunk\em\em011\00\collision
            // chunk\em\em011\00\shell\collision

            var collision = new Models.Collision {
                magicCol1 = reader.ReadUInt32(),
                nameCol = new string(reader.ReadChars(4)),
                magicCol2 = reader.ReadUInt32(),
                unk1 = reader.ReadUInt32(),
                unk2 = reader.ReadUInt32(),
                nameCount = reader.ReadUInt32()
            };
            collision.names = ReadNames(collision.nameCount, reader);
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
            collision.unk4 = reader.ReadUInt32();
            collision.unk5 = reader.ReadUInt32();
            collision.unk6 = reader.ReadUInt16();
            collision.unk7 = reader.ReadUInt16();
            collision.unk8 = reader.ReadUInt32();

            if (collision.oapType > 0) {
                collision.unk9 = reader.ReadUInt32();
                collision.unk10 = reader.ReadUInt32();
                collision.unk11 = reader.ReadUInt16();
                collision.unk12 = reader.ReadInt16();
                collision.unk13 = reader.ReadUInt32();

                if (collision.oapType > 0) {
                    collision.unk14 = reader.ReadUInt32();
                    collision.unk15 = reader.ReadUInt32();
                    collision.unk16 = reader.ReadUInt32();
                    collision.unk17 = reader.ReadUInt32();
                }
            }

            return collision;
        }

        private static List<Name> ReadNames(uint count, BinaryReader reader) {
            var names = new List<Name>();

            for (uint i = 0; i < count; i++) {
                var name = new Name();

                var stringBytes = new List<byte>();
                do {
                    stringBytes.Add(reader.ReadByte());
                } while (stringBytes[stringBytes.Count - 1] != 0);

                name.name = Encoding.UTF8.GetString(stringBytes.Subsequence(0, stringBytes.Count).ToArray());

                name.unk1 = reader.ReadInt32();
                name.moveId = reader.ReadInt32();
                name.unk2 = reader.ReadInt32();
                name.unk3 = reader.ReadUInt16();
                name.unk4 = reader.ReadByte();
                name.unk5 = reader.ReadUInt32();

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
                unk1 = reader.ReadUInt32(),
                unk2 = reader.ReadByte()
            };
            clnd.clgm = ReadClgm(clnd.count, reader);
            clnd.unk3 = reader.ReadByte();
            clnd.unk4 = reader.ReadByte();
            clnd.unk5 = reader.ReadByte();
            return clnd;
        }

        private static List<Clgm> ReadClgm(uint count, BinaryReader reader) {
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
                clgm.unk12 = reader.ReadByte();

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
                } else if (type == 3) {
                    var bytes = reader.ReadBytes(Marshal.SizeOf(typeof(Atk3)));
                    atks.Add(bytes.GetDataAs<Atk3>());
                } else {
                    throw new InvalidOperationException($"Unknown attack type: {type}");
                }
            }

            return atks;
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
            writer.Write(collision.unk4);
            writer.Write(collision.unk5);
            writer.Write(collision.unk6);
            writer.Write(collision.unk7);
            writer.Write(collision.unk8);

            if (collision.oapType > 0) {
                writer.Write(collision.unk9);
                writer.Write(collision.unk10);
                writer.Write(collision.unk11);
                writer.Write(collision.unk12);
                writer.Write(collision.unk13);

                if (collision.oapType > 0) {
                    writer.Write(collision.unk14);
                    writer.Write(collision.unk15);
                    writer.Write(collision.unk16);
                    writer.Write(collision.unk17);
                }
            }
        }

        private static void WriteNames(IEnumerable<Name> names, BinaryWriter writer) {
            foreach (var name in names) {
                writer.Write(name.name.ToCharArray());
                writer.Write(name.unk1);
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
            writer.Write(clnd.unk1);
            writer.Write(clnd.unk2);
            WriteClgm(clnd.clgm, writer);
            writer.Write(clnd.unk3);
            writer.Write(clnd.unk4);
            writer.Write(clnd.unk5);
        }

        private static void WriteClgm(IEnumerable<Clgm> clgms, BinaryWriter writer) {
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
                writer.Write(clgm.unk12);
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
                } else if (type == 3) {
                    bytes = ((Atk3) atk).GetBytes();
                } else {
                    throw new InvalidOperationException($"Unknown attack type: {type}");
                }

                writer.Write(bytes);
            }
        }
    }
}