using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class GunnerReload {
        public const uint StructSize = 5;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string No_Mods_displayName = "No Mods";
        public const int No_Mods_sortIndex = 50;
        [SortOrder(No_Mods_sortIndex)]
        [DisplayName(No_Mods_displayName)]
        public virtual byte No_Mods {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value, nameof(No_Mods));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(No_Mods));
            }
        }

        public const string Mod_1_displayName = "Mod 1";
        public const int Mod_1_sortIndex = 100;
        [SortOrder(Mod_1_sortIndex)]
        [DisplayName(Mod_1_displayName)]
        public virtual byte Mod_1 {
            get => GetData<byte>(1);
            set {
                if (GetData<byte>(1) == value) return;
                SetData(1, value, nameof(Mod_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mod_1));
            }
        }

        public const string Mod_2_displayName = "Mod 2";
        public const int Mod_2_sortIndex = 150;
        [SortOrder(Mod_2_sortIndex)]
        [DisplayName(Mod_2_displayName)]
        public virtual byte Mod_2 {
            get => GetData<byte>(2);
            set {
                if (GetData<byte>(2) == value) return;
                SetData(2, value, nameof(Mod_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mod_2));
            }
        }

        public const string Mod_3_displayName = "Mod 3";
        public const int Mod_3_sortIndex = 200;
        [SortOrder(Mod_3_sortIndex)]
        [DisplayName(Mod_3_displayName)]
        public virtual byte Mod_3 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(Mod_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mod_3));
            }
        }

        public const string Mod_4_displayName = "Mod 4";
        public const int Mod_4_sortIndex = 250;
        [SortOrder(Mod_4_sortIndex)]
        [DisplayName(Mod_4_displayName)]
        public virtual byte Mod_4 {
            get => GetData<byte>(4);
            set {
                if (GetData<byte>(4) == value) return;
                SetData(4, value, nameof(Mod_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mod_4));
            }
        }

        public const int lastSortIndex = 300;
    }
}