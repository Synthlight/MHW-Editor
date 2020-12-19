using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Editor.Structs.Armors {
    public partial class Opst : MhwSingleStructFile<Opst, Opst.Entries> {
        public partial class Entries {
            [DisplayName("Armor (Head) Name")]
            public string ArmorHeadName => DataHelper.palicoArmorHeadLookupByModelId[MainWindow.locale].TryGet((uint) Index);

            [DisplayName("Armor (Body) Name")]
            public string ArmorBodyName => DataHelper.palicoArmorBodyLookupByModelId[MainWindow.locale].TryGet((uint) Index);

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 1)]
            [DisplayName("Hide Torso")]
            public bool HideTorso {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Torso) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Torso;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Torso;
                    }

                    OnPropertyChanged(nameof(HideTorso));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 2)]
            [DisplayName("Hide Head")]
            public bool HideHead {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Head) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Head;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Head;
                    }

                    OnPropertyChanged(nameof(HideHead));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 3)]
            [DisplayName("Hide Hands")]
            public bool HideHands {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Hands) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Hands;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Hands;
                    }

                    OnPropertyChanged(nameof(HideHands));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 4)]
            [DisplayName("Hide Waist")]
            public bool HideWaist {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Waist) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Waist;
                    } else {
                        Bit_Flags_1_Raw &= ~ Opst1Flags.Hide_Waist;
                    }

                    OnPropertyChanged(nameof(HideWaist));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 5)]
            [DisplayName("Hide Feet")]
            public bool HideFeet {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Feet) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Feet;
                    } else {
                        Bit_Flags_1_Raw &= ~ Opst1Flags.Hide_Feet;
                    }

                    OnPropertyChanged(nameof(HideFeet));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 6)]
            [DisplayName("Hide Eyebrows / Whiskers")]
            public bool HideEyebrowsWhiskers {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Eyebrows_Whiskers) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Eyebrows_Whiskers;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Eyebrows_Whiskers;
                    }

                    OnPropertyChanged(nameof(HideEyebrowsWhiskers));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 7)]
            [DisplayName("Hide Arms")]
            public bool HideArms {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Arms) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Arms;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Arms;
                    }

                    OnPropertyChanged(nameof(HideArms));
                }
            }

            [SortOrder(Bit_Flags_1_Raw_sortIndex + 8)]
            [DisplayName("Hide Ears / Tail")]
            public bool HideEarsTail {
                get => (Bit_Flags_1_Raw & Opst1Flags.Hide_Ears_Tail) != 0;
                set {
                    if (value) {
                        Bit_Flags_1_Raw |= Opst1Flags.Hide_Ears_Tail;
                    } else {
                        Bit_Flags_1_Raw &= ~Opst1Flags.Hide_Ears_Tail;
                    }

                    OnPropertyChanged(nameof(HideEarsTail));
                }
            }

            [SortOrder(Bit_Flags_2_Raw_sortIndex + 1)]
            [DisplayName("Tail Control")]
            public bool TailControl {
                get => (Bit_Flags_2_Raw & Opst2Flags.Tail_Control) != 0;
                set {
                    if (value) {
                        Bit_Flags_2_Raw |= Opst2Flags.Tail_Control;
                    } else {
                        Bit_Flags_2_Raw &= ~Opst2Flags.Tail_Control;
                    }

                    OnPropertyChanged(nameof(TailControl));
                }
            }

            [SortOrder(Bit_Flags_2_Raw_sortIndex + 2)]
            [DisplayName("Ear Control")]
            public bool EarControl {
                get => (Bit_Flags_2_Raw & Opst2Flags.Ear_Control) != 0;
                set {
                    if (value) {
                        Bit_Flags_2_Raw |= Opst2Flags.Ear_Control;
                    } else {
                        Bit_Flags_2_Raw &= ~Opst2Flags.Ear_Control;
                    }

                    OnPropertyChanged(nameof(EarControl));
                }
            }
        }

        public static bool ShouldCancel(string propertyName, MainWindow mainWindow) {
            var isHeadArmor = mainWindow.Title.StartsWith("helm");
            var isBodyArmor = mainWindow.Title.StartsWith("body");

            return propertyName switch {
                nameof(Entries.ArmorHeadName) => !isHeadArmor,
                nameof(Entries.ArmorBodyName) => !isBodyArmor,
                _ => false
            };
        }
    }
}