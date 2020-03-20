using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreakR {
        public const uint StructSize = 34;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual ushort Id {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Id));
            }
        }

        public const string Great_Sword_displayName = "Great Sword";
        public const int Great_Sword_sortIndex = 100;
        [SortOrder(Great_Sword_sortIndex)]
        [DisplayName(Great_Sword_displayName)]
        public virtual ushort Great_Sword {
            get => GetData<ushort>(2);
            set {
                if (GetData<ushort>(2) == value) return;
                SetData(2, value, nameof(Great_Sword));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Great_Sword));
            }
        }

        public const string Sword_Shield_displayName = "Sword & Shield";
        public const int Sword_Shield_sortIndex = 150;
        [SortOrder(Sword_Shield_sortIndex)]
        [DisplayName(Sword_Shield_displayName)]
        public virtual ushort Sword_Shield {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Sword_Shield));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sword_Shield));
            }
        }

        public const string Dual_Blades_displayName = "Dual Blades";
        public const int Dual_Blades_sortIndex = 200;
        [SortOrder(Dual_Blades_sortIndex)]
        [DisplayName(Dual_Blades_displayName)]
        public virtual ushort Dual_Blades {
            get => GetData<ushort>(6);
            set {
                if (GetData<ushort>(6) == value) return;
                SetData(6, value, nameof(Dual_Blades));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dual_Blades));
            }
        }

        public const string Long_Sword_displayName = "Long Sword";
        public const int Long_Sword_sortIndex = 250;
        [SortOrder(Long_Sword_sortIndex)]
        [DisplayName(Long_Sword_displayName)]
        public virtual ushort Long_Sword {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(Long_Sword));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Long_Sword));
            }
        }

        public const string Hammer_displayName = "Hammer";
        public const int Hammer_sortIndex = 300;
        [SortOrder(Hammer_sortIndex)]
        [DisplayName(Hammer_displayName)]
        public virtual ushort Hammer {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(Hammer));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hammer));
            }
        }

        public const string Hunting_Horn_displayName = "Hunting Horn";
        public const int Hunting_Horn_sortIndex = 350;
        [SortOrder(Hunting_Horn_sortIndex)]
        [DisplayName(Hunting_Horn_displayName)]
        public virtual ushort Hunting_Horn {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Hunting_Horn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hunting_Horn));
            }
        }

        public const string Lance_displayName = "Lance";
        public const int Lance_sortIndex = 400;
        [SortOrder(Lance_sortIndex)]
        [DisplayName(Lance_displayName)]
        public virtual ushort Lance {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(Lance));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lance));
            }
        }

        public const string Gunlance_displayName = "Gunlance";
        public const int Gunlance_sortIndex = 450;
        [SortOrder(Gunlance_sortIndex)]
        [DisplayName(Gunlance_displayName)]
        public virtual ushort Gunlance {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value) return;
                SetData(16, value, nameof(Gunlance));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gunlance));
            }
        }

        public const string Switch_Axe_displayName = "Switch Axe";
        public const int Switch_Axe_sortIndex = 500;
        [SortOrder(Switch_Axe_sortIndex)]
        [DisplayName(Switch_Axe_displayName)]
        public virtual ushort Switch_Axe {
            get => GetData<ushort>(18);
            set {
                if (GetData<ushort>(18) == value) return;
                SetData(18, value, nameof(Switch_Axe));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Switch_Axe));
            }
        }

        public const string Charge_Blade_displayName = "Charge Blade";
        public const int Charge_Blade_sortIndex = 550;
        [SortOrder(Charge_Blade_sortIndex)]
        [DisplayName(Charge_Blade_displayName)]
        public virtual ushort Charge_Blade {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(Charge_Blade));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Charge_Blade));
            }
        }

        public const string Insect_Glaive_displayName = "Insect Glaive";
        public const int Insect_Glaive_sortIndex = 600;
        [SortOrder(Insect_Glaive_sortIndex)]
        [DisplayName(Insect_Glaive_displayName)]
        public virtual ushort Insect_Glaive {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value, nameof(Insect_Glaive));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Insect_Glaive));
            }
        }

        public const string Bow_displayName = "Bow";
        public const int Bow_sortIndex = 650;
        [SortOrder(Bow_sortIndex)]
        [DisplayName(Bow_displayName)]
        public virtual ushort Bow {
            get => GetData<ushort>(24);
            set {
                if (GetData<ushort>(24) == value) return;
                SetData(24, value, nameof(Bow));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bow));
            }
        }

        public const string HBG_displayName = "HBG";
        public const int HBG_sortIndex = 700;
        [SortOrder(HBG_sortIndex)]
        [DisplayName(HBG_displayName)]
        public virtual ushort HBG {
            get => GetData<ushort>(26);
            set {
                if (GetData<ushort>(26) == value) return;
                SetData(26, value, nameof(HBG));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(HBG));
            }
        }

        public const string LBG_displayName = "LBG";
        public const int LBG_sortIndex = 750;
        [SortOrder(LBG_sortIndex)]
        [DisplayName(LBG_displayName)]
        public virtual ushort LBG {
            get => GetData<ushort>(28);
            set {
                if (GetData<ushort>(28) == value) return;
                SetData(28, value, nameof(LBG));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LBG));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 800;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual byte Unk13 {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value) return;
                SetData(33, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const int lastSortIndex = 850;
    }
}