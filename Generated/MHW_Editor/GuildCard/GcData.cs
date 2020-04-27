using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.GuildCard {
    public partial class GcData {
        public const uint StructSize = 20;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        [IsReadOnly]
        public virtual uint Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Unlock_Type_displayName = "Unlock Type";
        public const int Unlock_Type_sortIndex = 100;
        [SortOrder(Unlock_Type_sortIndex)]
        [DisplayName(Unlock_Type_displayName)]
        public virtual MHW_Template.GuildCard.UnlockType Unlock_Type {
            get => (MHW_Template.GuildCard.UnlockType) GetData<int>(4);
            set {
                if ((MHW_Template.GuildCard.UnlockType) GetData<int>(4) == value) return;
                SetData(4, (int) value, nameof(Unlock_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Type));
            }
        }

        public const string Unlock_Param_displayName = "Unlock Param";
        public const int Unlock_Param_sortIndex = 150;
        [SortOrder(Unlock_Param_sortIndex)]
        [DisplayName(Unlock_Param_displayName)]
        public virtual uint Unlock_Param {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Unlock_Param));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Param));
            }
        }

        public const string Monster_Id_displayName = "Monster Id";
        public const int Monster_Id_sortIndex = 200;
        [SortOrder(Monster_Id_sortIndex)]
        [DisplayName(Monster_Id_displayName)]
        public virtual uint Monster_Id {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Monster_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Monster_Id));
            }
        }

        public const string Unk_displayName = "Unk";
        public const int Unk_sortIndex = 250;
        [SortOrder(Unk_sortIndex)]
        [DisplayName(Unk_displayName)]
        public virtual uint Unk {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk));
            }
        }

        public const int lastSortIndex = 300;
    }
}