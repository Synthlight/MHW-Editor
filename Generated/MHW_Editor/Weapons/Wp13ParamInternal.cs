using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp13Param {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Shield 1 Small", "Shield_1_Small", Bytes, 2238),
                new PlDataItemCustomView(this, "Shield 1 Medium", "Shield_1_Medium", Bytes, 2239),
                new PlDataItemCustomView(this, "Shield 1 Large", "Shield_1_Large", Bytes, 2240),
                new PlDataItemCustomView(this, "-------------------------------------------------------------------------------------------", "__200", Bytes, 3),
                new PlDataItemCustomView(this, "Shield 2 Small", "Shield_2_Small", Bytes, 2241),
                new PlDataItemCustomView(this, "Shield 2 Medium", "Shield_2_Medium", Bytes, 2242),
                new PlDataItemCustomView(this, "Shield 2 Large", "Shield_2_Large", Bytes, 2243),
                new PlDataItemCustomView(this, "-------------------------------------------------------------------------------------------", "__400", Bytes, 3),
                new PlDataItemCustomView(this, "Shield 3 Small", "Shield_3_Small", Bytes, 2244),
                new PlDataItemCustomView(this, "Shield 3 Medium", "Shield_3_Medium", Bytes, 2245),
                new PlDataItemCustomView(this, "Shield 3 Large", "Shield_3_Large", Bytes, 2246),
                new PlDataItemCustomView(this, "-------------------------------------------------------------------------------------------", "__600", Bytes, 3),
                new PlDataItemCustomView(this, "Shield 4 Small", "Shield_4_Small", Bytes, 2247),
                new PlDataItemCustomView(this, "Shield 4 Medium", "Shield_4_Medium", Bytes, 2248),
                new PlDataItemCustomView(this, "Shield 4 Large", "Shield_4_Large", Bytes, 2249),
            };
        }
    }
}