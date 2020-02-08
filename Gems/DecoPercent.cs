using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public abstract class DecoPercent : MhwItem {
        protected DecoPercent(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        private float r5Percent;

        [SortOrder(DecoLottery.R5_sortIndex + 1)]
        [DisplayName(DecoLottery.R5_displayName + "%")]
        public float R5_percent {
            get => r5Percent;
            set {
                r5Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R5_percent));
            }
        }

        private float r6Percent;

        [SortOrder(DecoLottery.R6_sortIndex + 1)]
        [DisplayName(DecoLottery.R6_displayName + "%")]
        public float R6_percent {
            get => r6Percent;
            set {
                r6Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R6_percent));
            }
        }

        private float r7Percent;

        [SortOrder(DecoLottery.R7_sortIndex + 1)]
        [DisplayName(DecoLottery.R7_displayName + "%")]
        public float R7_percent {
            get => r7Percent;
            set {
                r7Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R7_percent));
            }
        }

        private float r8Percent;

        [SortOrder(DecoLottery.R8_sortIndex + 1)]
        [DisplayName(DecoLottery.R8_displayName + "%")]
        public float R8_percent {
            get => r8Percent;
            set {
                r8Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R8_percent));
            }
        }

        private float r9Percent;

        [SortOrder(DecoLottery.R9_sortIndex + 1)]
        [DisplayName(DecoLottery.R9_displayName + "%")]
        public float R9_percent {
            get => r9Percent;
            set {
                r9Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R9_percent));
            }
        }

        private float r10Percent;

        [SortOrder(DecoLottery.R10_sortIndex + 1)]
        [DisplayName(DecoLottery.R10_displayName + "%")]
        public float R10_percent {
            get => r10Percent;
            set {
                r10Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R10_percent));
            }
        }

        private float r11Percent;

        [SortOrder(DecoLottery.R11_sortIndex + 1)]
        [DisplayName(DecoLottery.R11_displayName + "%")]
        public float R11_percent {
            get => r11Percent;
            set {
                r11Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R11_percent));
            }
        }

        private float r12Percent;

        [SortOrder(DecoLottery.R12_sortIndex + 1)]
        [DisplayName(DecoLottery.R12_displayName + "%")]
        public float R12_percent {
            get => r12Percent;
            set {
                r12Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R12_percent));
            }
        }

        private float r13Percent;

        [SortOrder(DecoLottery.R13_sortIndex + 1)]
        [DisplayName(DecoLottery.R13_displayName + "%")]
        public float R13_percent {
            get => r13Percent;
            set {
                r13Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(R13_percent));
            }
        }

        private float streamR6Percent;

        [SortOrder(DecoLottery.Stream_R6__sortIndex + 1)]
        [DisplayName(DecoLottery.Stream_R6__displayName + "%")]
        public float Stream_R6_percent {
            get => streamR6Percent;
            set {
                streamR6Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Stream_R6_percent));
            }
        }

        private float streamR8Percent;

        [SortOrder(DecoLottery.Stream_R8__sortIndex + 1)]
        [DisplayName(DecoLottery.Stream_R8__displayName + "%")]
        public float Stream_R8_percent {
            get => streamR8Percent;
            set {
                streamR8Percent = value.Clamp(0f, 100f);
                OnPropertyChanged(nameof(Stream_R8_percent));
            }
        }
    }
}