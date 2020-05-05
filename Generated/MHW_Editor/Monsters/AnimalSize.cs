using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class AnimalSize {
        public const uint StructSize = 72;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Endemic_Id_displayName = "Endemic Id";
        public const int Endemic_Id_sortIndex = 50;
        [SortOrder(Endemic_Id_sortIndex)]
        [DisplayName(Endemic_Id_displayName)]
        public virtual uint Endemic_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Endemic_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Endemic_Id));
            }
        }

        public const string Endemic_Sub_Species_Id_displayName = "Endemic Sub Species Id";
        public const int Endemic_Sub_Species_Id_sortIndex = 100;
        [SortOrder(Endemic_Sub_Species_Id_sortIndex)]
        [DisplayName(Endemic_Sub_Species_Id_displayName)]
        public virtual uint Endemic_Sub_Species_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Endemic_Sub_Species_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Endemic_Sub_Species_Id));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 150;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 200;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 250;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 300;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Animal_Base_Size_displayName = "Animal Base Size";
        public const int Animal_Base_Size_sortIndex = 350;
        [SortOrder(Animal_Base_Size_sortIndex)]
        [DisplayName(Animal_Base_Size_displayName)]
        public virtual float Animal_Base_Size {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Animal_Base_Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Animal_Base_Size));
            }
        }

        public const string Model_Size_Multi_displayName = "Model Size Multi";
        public const int Model_Size_Multi_sortIndex = 400;
        [SortOrder(Model_Size_Multi_sortIndex)]
        [DisplayName(Model_Size_Multi_displayName)]
        public virtual float Model_Size_Multi {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(Model_Size_Multi));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Model_Size_Multi));
            }
        }

        public const string Minimum_Size_Limit_displayName = "Minimum Size Limit";
        public const int Minimum_Size_Limit_sortIndex = 450;
        [SortOrder(Minimum_Size_Limit_sortIndex)]
        [DisplayName(Minimum_Size_Limit_displayName)]
        public virtual float Minimum_Size_Limit {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Minimum_Size_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Minimum_Size_Limit));
            }
        }

        public const string Maximum_Size_Limit_displayName = "Maximum Size Limit";
        public const int Maximum_Size_Limit_sortIndex = 500;
        [SortOrder(Maximum_Size_Limit_sortIndex)]
        [DisplayName(Maximum_Size_Limit_displayName)]
        public virtual float Maximum_Size_Limit {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Maximum_Size_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Maximum_Size_Limit));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 550;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual uint Unk11 {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 600;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual float Unk12 {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 650;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual float Unk13 {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 700;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual float Unk14 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 750;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 800;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual uint Unk16 {
            get => GetData<uint>(60);
            set {
                if (GetData<uint>(60) == value) return;
                SetData(60, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Small_Gold_Crown_Limit_displayName = "Small Gold Crown Limit";
        public const int Small_Gold_Crown_Limit_sortIndex = 850;
        [SortOrder(Small_Gold_Crown_Limit_sortIndex)]
        [DisplayName(Small_Gold_Crown_Limit_displayName)]
        public virtual float Small_Gold_Crown_Limit {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Small_Gold_Crown_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Small_Gold_Crown_Limit));
            }
        }

        public const string Big_Gold_Crown_Limit_displayName = "Big Gold Crown Limit";
        public const int Big_Gold_Crown_Limit_sortIndex = 900;
        [SortOrder(Big_Gold_Crown_Limit_sortIndex)]
        [DisplayName(Big_Gold_Crown_Limit_displayName)]
        public virtual float Big_Gold_Crown_Limit {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(Big_Gold_Crown_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Big_Gold_Crown_Limit));
            }
        }

        public const int lastSortIndex = 950;
    }
}