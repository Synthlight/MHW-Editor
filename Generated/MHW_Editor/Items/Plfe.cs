
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Plfe {
        public const uint StructSize = 24;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Fertilizer_Id_displayName = "Fertilizer Id";
        protected const int Fertilizer_Id_sortIndex = 50;
        [SortOrder(Fertilizer_Id_sortIndex)]
        [DisplayName(Fertilizer_Id_displayName)]
        public MHW_Template.Items.Fertilizer Fertilizer_Id {
            get => (MHW_Template.Items.Fertilizer) GetData<uint>(0);
            set {
                SetData(0, (uint) value);
                OnPropertyChanged(nameof(Fertilizer_Id));
            }
        }
        protected const string Prize_displayName = "Prize";
        protected const int Prize_sortIndex = 100;
        [SortOrder(Prize_sortIndex)]
        [DisplayName(Prize_displayName)]
        public uint Prize {
            get => GetData<uint>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Prize));
            }
        }
        protected const string Base_duration_displayName = "Base duration";
        protected const int Base_duration_sortIndex = 150;
        [SortOrder(Base_duration_sortIndex)]
        [DisplayName(Base_duration_displayName)]
        public uint Base_duration {
            get => GetData<uint>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Base_duration));
            }
        }
        protected const string Unknown_int32_1_displayName = "Unknown (int32) 1";
        protected const int Unknown_int32_1_sortIndex = 200;
        [SortOrder(Unknown_int32_1_sortIndex)]
        [DisplayName(Unknown_int32_1_displayName)]
        public uint Unknown_int32_1 {
            get => GetData<uint>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Unknown_int32_1));
            }
        }
        protected const string Unknown_int32_2_displayName = "Unknown (int32) 2";
        protected const int Unknown_int32_2_sortIndex = 250;
        [SortOrder(Unknown_int32_2_sortIndex)]
        [DisplayName(Unknown_int32_2_displayName)]
        public uint Unknown_int32_2 {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Unknown_int32_2));
            }
        }
        protected const string Unknown_int32_3_displayName = "Unknown (int32) 3";
        protected const int Unknown_int32_3_sortIndex = 300;
        [SortOrder(Unknown_int32_3_sortIndex)]
        [DisplayName(Unknown_int32_3_displayName)]
        public uint Unknown_int32_3 {
            get => GetData<uint>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unknown_int32_3));
            }
        }
    }
}