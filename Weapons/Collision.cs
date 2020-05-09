using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class Collision : MhwMultiStructItem<Collision> {
        public void Init(string targetFile) {
            var nameContainer = data.First(o => o.list.OfType<Names>().Any());
            foreach (Names name in nameContainer.list) {
                name.Init(targetFile);

                var clgm = GetClgm(name.CLGM_Id);
                if (clgm != null) {
                    name.LinkedClgm.Add(clgm);
                }

                var move = GetMove(name.Move_Id);
                if (move != null) {
                    name.LinkedMove.Add(move);
                    ((dynamic) move).translatedName = name.TranslatedName;
                }
            }
        }

        private CLND.CLGMs GetClgm(int clgmId) {
            var clnd = (CLND) data.First(o => o.list.OfType<CLND>().Any()).list.FirstOrDefault();
            return clnd?.CLGMs_raw?.FirstOrDefault(clgm => (int) clgm.Index == clgmId);
        }

        private object GetMove(int moveId) {
            var moveContainer = data.First(o => o.list.OfType<Moves>().Any());
            return (from Moves move in moveContainer.list
                    select GetAtk(moveId, move.Atks))
                .FirstOrDefault(atk => atk != null);
        }

        private object GetAtk(int moveId, dynamic atks) {
            foreach (var atk in atks) {
                if ((int) atk.Index == moveId) {
                    return atk;
                }
            }
            return null;
        }

        public partial class Names {
            public void Init(string targetFile) {
                TranslatedName = Name;

                var translatedName = Name;
                var description    = "";

                if (translatedName == "\0") translatedName = null;

                if (string.IsNullOrEmpty(Name) || Move_Id == -1) return;

                // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
                foreach (var key in DataHelper.collisionTranslationsData.Keys) {
                    if (targetFile.EndsWith(key)) {
                        var nameDescPair = DataHelper.collisionTranslationsData[key].TryGet(Move_Id, null);
                        if (nameDescPair != null) {
                            if (!string.IsNullOrEmpty(nameDescPair.name)) {
                                translatedName = nameDescPair.name;
                            }
                            description = nameDescPair.description;
                            if (description == "guess dummy") {
                                description = "Unused?";
                            }
                        } else {
                            return;
                        }
                    }
                }

                TranslatedName = translatedName;
                if (string.IsNullOrEmpty(TranslatedName)) {
                    TranslatedName = description;
                } else if (!string.IsNullOrEmpty(description)) {
                    TranslatedName += $", {description}";
                }
            }

            [DisplayName("Name")]
            [SortOrder(40)]
            public string TranslatedName { get; private set; }

            [SortOrder(CLGM_Id_sortIndex + 1)]
            [DisplayName("Linked CLGM")]
            public ObservableCollection<CLND.CLGMs> LinkedClgm { get; } = new ObservableCollection<CLND.CLGMs>();

            [SortOrder(Move_Id_sortIndex + 1)]
            [DisplayName("Linked Move")]
            public ObservableCollection<object> LinkedMove { get; } = new ObservableCollection<object>();
        }

        public partial class Moves {
            [SortOrder(Atk0_sortIndex)]
            [DisplayName("Atks")]
            [IsList]
            public dynamic Atks {
                get {
                    return Move_Type switch {
                        0 => Atk0_raw,
                        1 => Atk1_raw,
                        2 => Atk2_raw,
                        3 => Atk3_raw,
                        _ => null // Should never happen.
                    };
                }
            }

            private const string TRANSLATED_NAME_DISPLAY_NAME = "First Matching Name";
            private const int    TRANSLATED_NAME_SORT_ORDER   = 55;

            public partial class Atk0 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk1 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk2 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public partial class Atk3 : IAtk {
                [UsedImplicitly] public string translatedName;

                [DisplayName(TRANSLATED_NAME_DISPLAY_NAME)]
                [SortOrder(TRANSLATED_NAME_SORT_ORDER)]
                public string TranslatedName => translatedName;
            }

            public interface IAtk {
                public string TranslatedName { get; }
            }
        }

        public partial class OAP {
            public partial class End_Junk {
                public static ObservableCollection<End_Junk> LoadData(BinaryReader reader, OAP parent) {
                    var list = new ObservableCollection<End_Junk>();
                    var i    = -1;
                    while (reader.BaseStream.Position < reader.BaseStream.Length) {
                        list.Add(new End_Junk {
                            Index   = (ulong) ++i,
                            Unk_raw = reader.ReadByte()
                        });
                    }
                    return list;
                }
            }
        }
    }
}