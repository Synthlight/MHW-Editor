using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp10Param {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Air-Time 1", "Air_Time_1", Bytes, 1153),
                new PlDataItemCustomView(this, "Air-Time 2", "Air_Time_2", Bytes, 1157),
                new PlDataItemCustomView(this, "Air-Time 3", "Air_Time_3", Bytes, 1161),
                new PlDataItemCustomView(this, "Air-Time 4", "Air_Time_4", Bytes, 1165),
            };
        }
    }
}