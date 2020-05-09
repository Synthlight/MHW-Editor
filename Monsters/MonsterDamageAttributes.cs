using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Monsters {
    public partial class MonsterDamageAttributes : MhwMultiStructItem<MonsterDamageAttributes> {
        public override void SetupViews(Grid grid, MainWindow main) {
            var mainEntries    = new ObservableCollection<MultiStructItemCustomView>();
            var statusBuildups = new ObservableCollection<IStatusBuildup>();
            var theRest        = new List<MhwStructDataContainer>();

            foreach (var entry in data) {
                if (entry.type.Is(typeof(IStatusBuildup))) {
                    foreach (var item in entry.list) {
                        statusBuildups.Add((IStatusBuildup) item);
                    }
                } else if (entry.type.IsGeneric(typeof(IHasCustomView<>))) {
                    var list = (IHasCustomView<MultiStructItemCustomView>) entry.list[0];
                    foreach (var view in list.GetCustomView()) {
                        mainEntries.Add(view);
                    }
                } else if (entry.type == typeof(Monster_Damage_Attributes_1_)) {
                    SetupView(entry, grid, main);
                } else {
                    theRest.Add(entry);
                }
            }

            grid.AddControl(new Label {Content = "Monster Damage Attributes (2)", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(mainEntries);

            grid.AddControl(new Label {Content = "Status Buildups", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(statusBuildups);

            foreach (var entry in theRest) {
                SetupView(entry, grid, main);
            }
        }

        public interface IStatusBuildup {
            string Name    { get; }
            uint   Base    { get; set; }
            uint   Buildup { get; set; }

            [DisplayName("Max Cap")]
            uint Max_Cap { get; set; }

            [DisplayName("Drain Time")]
            float Drain_Time { get; set; }

            [DisplayName("Drain Value")]
            uint Drain_Value { get; set; }

            float Duration { get; set; }

            [DisplayName("Duration Decrease Per Use")]
            float Duration_Decrease_Per_Use { get; set; }

            [DisplayName("Duration Minimum")]
            float Duration_Minimum { get; set; }
        }

        public partial class Status_Buildup_Poison : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Poison",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Sleep_Paralysis_Stun_Exhaustion : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Sleep",
                        1 => "Paralysis",
                        2 => "Stun",
                        3 => "Exhaustion",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Mount_Blastblight : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Mount",
                        1 => "Blastblight",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Capture : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Capture",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Dizziness_LR_HR : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Dizziness LR/HR",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Dizziness_MR : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Dizziness MR",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Mount_Knock_Down : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Mount Knock Down",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Dung : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Dung",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Shock Trap",
                        1 => "Pitfall Trap",
                        2 => "Ivy Trap Unk",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Dragonseal : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Dragonseal",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Unk : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Concussion : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Concussion",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Status_Buildup_Clagger : IStatusBuildup {
            public string Name {
                get {
                    return Index switch {
                        0 => "Clagger",
                        _ => "Unknown"
                    };
                }
            }
        }

        public partial class Rage_Build_Up {
            public string Name {
                get {
                    return Index switch {
                        0 => "Normal",
                        1 => "Special",
                        _ => "Unknown"
                    };
                }
            }
        }
    }
}