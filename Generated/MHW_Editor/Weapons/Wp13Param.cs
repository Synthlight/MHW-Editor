using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp13Param {
        public const uint StructSize = 3200;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Shield_1_Small_displayName = "Shield 1 Small";
        public const int Shield_1_Small_sortIndex = 50;
        [SortOrder(Shield_1_Small_sortIndex)]
        [DisplayName(Shield_1_Small_displayName)]
        public virtual byte Shield_1_Small {
            get => GetData<byte>(2238);
            set {
                if (GetData<byte>(2238) == value) return;
                SetData(2238, value, nameof(Shield_1_Small));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_1_Small));
            }
        }

        public const string Shield_1_Medium_displayName = "Shield 1 Medium";
        public const int Shield_1_Medium_sortIndex = 100;
        [SortOrder(Shield_1_Medium_sortIndex)]
        [DisplayName(Shield_1_Medium_displayName)]
        public virtual byte Shield_1_Medium {
            get => GetData<byte>(2239);
            set {
                if (GetData<byte>(2239) == value) return;
                SetData(2239, value, nameof(Shield_1_Medium));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_1_Medium));
            }
        }

        public const string Shield_1_Large_displayName = "Shield 1 Large";
        public const int Shield_1_Large_sortIndex = 150;
        [SortOrder(Shield_1_Large_sortIndex)]
        [DisplayName(Shield_1_Large_displayName)]
        public virtual byte Shield_1_Large {
            get => GetData<byte>(2240);
            set {
                if (GetData<byte>(2240) == value) return;
                SetData(2240, value, nameof(Shield_1_Large));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_1_Large));
            }
        }

        public const string __200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __200_sortIndex = 200;
        [SortOrder(__200_sortIndex)]
        [DisplayName(__200_displayName)]
        [IsReadOnly]
        public virtual byte __200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__200));
            }
        }

        public const string Shield_2_Small_displayName = "Shield 2 Small";
        public const int Shield_2_Small_sortIndex = 250;
        [SortOrder(Shield_2_Small_sortIndex)]
        [DisplayName(Shield_2_Small_displayName)]
        public virtual byte Shield_2_Small {
            get => GetData<byte>(2241);
            set {
                if (GetData<byte>(2241) == value) return;
                SetData(2241, value, nameof(Shield_2_Small));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_2_Small));
            }
        }

        public const string Shield_2_Medium_displayName = "Shield 2 Medium";
        public const int Shield_2_Medium_sortIndex = 300;
        [SortOrder(Shield_2_Medium_sortIndex)]
        [DisplayName(Shield_2_Medium_displayName)]
        public virtual byte Shield_2_Medium {
            get => GetData<byte>(2242);
            set {
                if (GetData<byte>(2242) == value) return;
                SetData(2242, value, nameof(Shield_2_Medium));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_2_Medium));
            }
        }

        public const string Shield_2_Large_displayName = "Shield 2 Large";
        public const int Shield_2_Large_sortIndex = 350;
        [SortOrder(Shield_2_Large_sortIndex)]
        [DisplayName(Shield_2_Large_displayName)]
        public virtual byte Shield_2_Large {
            get => GetData<byte>(2243);
            set {
                if (GetData<byte>(2243) == value) return;
                SetData(2243, value, nameof(Shield_2_Large));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_2_Large));
            }
        }

        public const string __400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __400_sortIndex = 400;
        [SortOrder(__400_sortIndex)]
        [DisplayName(__400_displayName)]
        [IsReadOnly]
        public virtual byte __400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__400));
            }
        }

        public const string Shield_3_Small_displayName = "Shield 3 Small";
        public const int Shield_3_Small_sortIndex = 450;
        [SortOrder(Shield_3_Small_sortIndex)]
        [DisplayName(Shield_3_Small_displayName)]
        public virtual byte Shield_3_Small {
            get => GetData<byte>(2244);
            set {
                if (GetData<byte>(2244) == value) return;
                SetData(2244, value, nameof(Shield_3_Small));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_3_Small));
            }
        }

        public const string Shield_3_Medium_displayName = "Shield 3 Medium";
        public const int Shield_3_Medium_sortIndex = 500;
        [SortOrder(Shield_3_Medium_sortIndex)]
        [DisplayName(Shield_3_Medium_displayName)]
        public virtual byte Shield_3_Medium {
            get => GetData<byte>(2245);
            set {
                if (GetData<byte>(2245) == value) return;
                SetData(2245, value, nameof(Shield_3_Medium));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_3_Medium));
            }
        }

        public const string Shield_3_Large_displayName = "Shield 3 Large";
        public const int Shield_3_Large_sortIndex = 550;
        [SortOrder(Shield_3_Large_sortIndex)]
        [DisplayName(Shield_3_Large_displayName)]
        public virtual byte Shield_3_Large {
            get => GetData<byte>(2246);
            set {
                if (GetData<byte>(2246) == value) return;
                SetData(2246, value, nameof(Shield_3_Large));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_3_Large));
            }
        }

        public const string __600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __600_sortIndex = 600;
        [SortOrder(__600_sortIndex)]
        [DisplayName(__600_displayName)]
        [IsReadOnly]
        public virtual byte __600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__600));
            }
        }

        public const string Shield_4_Small_displayName = "Shield 4 Small";
        public const int Shield_4_Small_sortIndex = 650;
        [SortOrder(Shield_4_Small_sortIndex)]
        [DisplayName(Shield_4_Small_displayName)]
        public virtual byte Shield_4_Small {
            get => GetData<byte>(2247);
            set {
                if (GetData<byte>(2247) == value) return;
                SetData(2247, value, nameof(Shield_4_Small));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_4_Small));
            }
        }

        public const string Shield_4_Medium_displayName = "Shield 4 Medium";
        public const int Shield_4_Medium_sortIndex = 700;
        [SortOrder(Shield_4_Medium_sortIndex)]
        [DisplayName(Shield_4_Medium_displayName)]
        public virtual byte Shield_4_Medium {
            get => GetData<byte>(2248);
            set {
                if (GetData<byte>(2248) == value) return;
                SetData(2248, value, nameof(Shield_4_Medium));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_4_Medium));
            }
        }

        public const string Shield_4_Large_displayName = "Shield 4 Large";
        public const int Shield_4_Large_sortIndex = 750;
        [SortOrder(Shield_4_Large_sortIndex)]
        [DisplayName(Shield_4_Large_displayName)]
        public virtual byte Shield_4_Large {
            get => GetData<byte>(2249);
            set {
                if (GetData<byte>(2249) == value) return;
                SetData(2249, value, nameof(Shield_4_Large));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Shield_4_Large));
            }
        }

        public const int lastSortIndex = 800;
    }
}