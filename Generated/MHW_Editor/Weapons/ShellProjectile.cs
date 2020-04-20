using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellProjectile : MhwMultiStructItem {
        public const ulong InitialOffset = 0;
        public const string EncryptionKey = "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";

        public partial class Shlp : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string DisplayName = "Shlp";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected char[] SLP_raw;
            public const string SLP_displayName = "SLP";
            public const int SLP_sortIndex = 100;
            [SortOrder(SLP_sortIndex)]
            [DisplayName(SLP_displayName)]
            [IsReadOnly]
            public virtual string SLP {
                get => (string) new string(SLP_raw);
                set {
                    if ((string) new string(SLP_raw) == value) return;
                    SLP_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(SLP));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 150;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            public static ulong GetEntryCount(List<List<dynamic>> data) {
                return FixedSizeCount;
            }

            public static Shlp LoadData(BinaryReader reader) {
                var data = new Shlp();
                data.Magic_1_raw = reader.ReadUInt32();
                data.SLP_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                return data;
            }
        }

        public partial class Assets : MhwStructItem {
            public const ulong FixedSizeCount = 25;
            public const string DisplayName = "Assets";

            protected uint Magic_raw;
            public const string Magic_displayName = "Magic";
            public const int Magic_sortIndex = 50;
            [SortOrder(Magic_sortIndex)]
            [DisplayName(Magic_displayName)]
            public virtual uint Magic {
                get => Magic_raw;
                set {
                    if (Magic_raw == value) return;
                    Magic_raw = value;
                    OnPropertyChanged(nameof(Magic));
                }
            }

            protected string Path_raw;
            public const string Path_displayName = "Path";
            public const int Path_sortIndex = 100;
            [SortOrder(Path_sortIndex)]
            [DisplayName(Path_displayName)]
            public virtual string Path {
                get => Path_raw;
                set {
                    if (Path_raw == value) return;
                    Path_raw = value;
                    OnPropertyChanged(nameof(Path));
                }
            }

            public static ulong GetEntryCount(List<List<dynamic>> data) {
                return FixedSizeCount;
            }

            public static Assets LoadData(BinaryReader reader) {
                var data = new Assets();
                data.Magic_raw = reader.ReadUInt32();
                if (data.Magic_raw != 0) data.Path_raw = reader.ReadNullTermString();
                return data;
            }
        }

        public static List<List<dynamic>> LoadData(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            var data = new List<List<dynamic>>();
            var Shlp_list = new List<dynamic>();
            for (ulong i = 0; i < Shlp.GetEntryCount(data); i++) {
                var item = Shlp.LoadData(reader);
                item.index = i;
                Shlp_list.Add(item);
            }
            data.Add(Shlp_list);
            var Assets_list = new List<dynamic>();
            for (ulong i = 0; i < Assets.GetEntryCount(data); i++) {
                var item = Assets.LoadData(reader);
                item.index = i;
                Assets_list.Add(item);
            }
            data.Add(Assets_list);
            return data;
        }
    }
}