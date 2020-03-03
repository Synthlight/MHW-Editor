using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.PlData {
    public partial class PlMusicSkillParam : MhwItem {
        private static readonly Dictionary<uint, string> musicList = new Dictionary<uint, string> {
            {1, "Self-improvement"},
            {2, "Attack Up (S)"},
            {3, "Attack Up (L)"},
            {4, "Health Boost (S)"},
            {5, "Health Boost (L)"},
            {6, "Stamina Use Reduced (S)"},
            {7, "Stamina Use Reduced (L)"},
            {8, "Wind Pressure Negated"},
            {9, "All Wind Pressure Negated"},
            {10, "Defense Up (S)"},
            {11, "Defense Up (L)"},
            {12, "Tool Use Drain Reduced (S)"},
            {13, "Tool Use Drain Reduced (L)"},
            {14, "Health Rec. (S)"},
            {15, "Health Rec. (L)"},
            {16, "Health Rec. (S) + Antidote"},
            {17, "Health Rec. (M) + Antidote"},
            {18, "Health Recovery (M)"},
            {19, "Recovery Speed (S)"},
            {20, "Recovery Speed (L)"},
            {21, "Earplugs (S)"},
            {22, "Earplugs (L)"},
            {23, "Divine Protection"},
            {24, "Scoutfly Power Up"},
            {25, "Envir. Damage Negated"},
            {26, "Stun Negated"},
            {27, "Paralysis Negated"},
            {28, "Tremors Negated"},
            {29, "Muck/Water/Deep Snow Res"},
            {30, "Fire Res Boost (S)"},
            {31, "Fire Res Boost (L)"},
            {32, "Water Res Boost (S)"},
            {33, "Water Res Boost (L)"},
            {34, "Thunder Res Boost (S)"},
            {35, "Thunder Res Boost (L)"},
            {36, "Ice Res Boost (S)"},
            {37, "Ice Res Boost (L)"},
            {38, "Dragon Res Boost (S)"},
            {39, "Dragon Res Boost (L)"},
            {40, "Elemental Attack Boost"},
            {41, "Blight Negated"},
            {42, "Sonic Waves"},
            {43, "All Melody Effects Extended"},
            {44, "Knockbacks Negated"},
            {45, "Attack and Defense Up (S)"},
            {46, "Blight Res Up"},
            {47, "Affinity Up and Health Rec. (S)"},
            {48, "All Ailments Negated"},
            {49, "Earplugs (S) / Wind Pressure Negated"},
            {50, "Abnormal Status Atk. Increased"},
            {51, "Health Recovery (M) 2"},
            {52, "Impact Echo Wave"},
            {53, "Echo Wave Dragon"},
            {54, "Max Stamina Up + Recovery"},
            {55, "Extended Health Recovery"},
            {56, "Speed Boost + Evade Window Up"},
            {57, "Elemental Effectiveness Up"},
            {58, "Evade Window Up"}
        };

        public PlMusicSkillParam(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => musicList.TryGet((uint) Index, "Unknown");

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}