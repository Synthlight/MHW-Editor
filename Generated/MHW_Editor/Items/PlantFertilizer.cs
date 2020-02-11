using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class PlantFertilizer {
        public const uint StructSize = 24;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Fertilizer_Id_displayName = "Fertilizer Id";
        public const int Fertilizer_Id_sortIndex = 50;
        [SortOrder(Fertilizer_Id_sortIndex)]
        [DisplayName(Fertilizer_Id_displayName)]
        public virtual MHW_Template.Items.Fertilizer Fertilizer_Id {
            get => (MHW_Template.Items.Fertilizer) GetData<uint>(0);
            set {
                if ((MHW_Template.Items.Fertilizer) GetData<uint>(0) == value) return;
                SetData(0, (uint) value, nameof(Fertilizer_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fertilizer_Id));
            }
        }

        public const string Prize_displayName = "Prize";
        public const int Prize_sortIndex = 100;
        [SortOrder(Prize_sortIndex)]
        [DisplayName(Prize_displayName)]
        public virtual uint Prize {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Prize));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Prize));
            }
        }

        public const string Base_duration_displayName = "Base duration";
        public const int Base_duration_sortIndex = 150;
        [SortOrder(Base_duration_sortIndex)]
        [DisplayName(Base_duration_displayName)]
        public virtual uint Base_duration {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Base_duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Base_duration));
            }
        }

        public const string Unknown_int32_1_displayName = "Unknown (int32) 1";
        public const int Unknown_int32_1_sortIndex = 200;
        [SortOrder(Unknown_int32_1_sortIndex)]
        [DisplayName(Unknown_int32_1_displayName)]
        public virtual uint Unknown_int32_1 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Unknown_int32_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_int32_1));
            }
        }

        public const string Unknown_int32_2_displayName = "Unknown (int32) 2";
        public const int Unknown_int32_2_sortIndex = 250;
        [SortOrder(Unknown_int32_2_sortIndex)]
        [DisplayName(Unknown_int32_2_displayName)]
        public virtual uint Unknown_int32_2 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Unknown_int32_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_int32_2));
            }
        }

        public const string Unknown_int32_3_displayName = "Unknown (int32) 3";
        public const int Unknown_int32_3_sortIndex = 300;
        [SortOrder(Unknown_int32_3_sortIndex)]
        [DisplayName(Unknown_int32_3_displayName)]
        public virtual uint Unknown_int32_3 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Unknown_int32_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_int32_3));
            }
        }

        public const int lastSortIndex = 350;
    }
}