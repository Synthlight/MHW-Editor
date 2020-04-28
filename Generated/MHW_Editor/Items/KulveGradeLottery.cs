using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class KulveGradeLottery {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 6;
        public const long EntryCountOffset = 2;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Item_Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        [IsReadOnly]
        public virtual uint Index {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Index));
            }
        }

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        [IsReadOnly]
        public virtual uint Item_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
                OnPropertyChanged(nameof(Item_Id_button));
            }
        }

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

        public const string Grade_1_displayName = "Grade 1";
        public const int Grade_1_sortIndex = 150;
        [SortOrder(Grade_1_sortIndex)]
        [DisplayName(Grade_1_displayName)]
        public virtual uint Grade_1 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Grade_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_1));
            }
        }

        private float _Grade_1Percent;
        [SortOrder(Grade_1_sortIndex + 1)]
        [DisplayName(Grade_1_displayName + "%")]
        public float Grade_1_percent {
            get => _Grade_1Percent;
            set {
                _Grade_1Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_1_percent));
            }
        }

        public const string Grade_2_displayName = "Grade 2";
        public const int Grade_2_sortIndex = 200;
        [SortOrder(Grade_2_sortIndex)]
        [DisplayName(Grade_2_displayName)]
        public virtual uint Grade_2 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Grade_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_2));
            }
        }

        private float _Grade_2Percent;
        [SortOrder(Grade_2_sortIndex + 1)]
        [DisplayName(Grade_2_displayName + "%")]
        public float Grade_2_percent {
            get => _Grade_2Percent;
            set {
                _Grade_2Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_2_percent));
            }
        }

        public const string Grade_3_displayName = "Grade 3";
        public const int Grade_3_sortIndex = 250;
        [SortOrder(Grade_3_sortIndex)]
        [DisplayName(Grade_3_displayName)]
        public virtual uint Grade_3 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Grade_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_3));
            }
        }

        private float _Grade_3Percent;
        [SortOrder(Grade_3_sortIndex + 1)]
        [DisplayName(Grade_3_displayName + "%")]
        public float Grade_3_percent {
            get => _Grade_3Percent;
            set {
                _Grade_3Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_3_percent));
            }
        }

        public const string Grade_4_displayName = "Grade 4";
        public const int Grade_4_sortIndex = 300;
        [SortOrder(Grade_4_sortIndex)]
        [DisplayName(Grade_4_displayName)]
        public virtual uint Grade_4 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Grade_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_4));
            }
        }

        private float _Grade_4Percent;
        [SortOrder(Grade_4_sortIndex + 1)]
        [DisplayName(Grade_4_displayName + "%")]
        public float Grade_4_percent {
            get => _Grade_4Percent;
            set {
                _Grade_4Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_4_percent));
            }
        }

        public const string Grade_5_displayName = "Grade 5";
        public const int Grade_5_sortIndex = 350;
        [SortOrder(Grade_5_sortIndex)]
        [DisplayName(Grade_5_displayName)]
        public virtual uint Grade_5 {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Grade_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_5));
            }
        }

        private float _Grade_5Percent;
        [SortOrder(Grade_5_sortIndex + 1)]
        [DisplayName(Grade_5_displayName + "%")]
        public float Grade_5_percent {
            get => _Grade_5Percent;
            set {
                _Grade_5Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Grade_5_percent));
            }
        }

        public const int lastSortIndex = 400;
    }
}