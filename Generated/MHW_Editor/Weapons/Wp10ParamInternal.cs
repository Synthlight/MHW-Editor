using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp10Param {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Red Extract Duration", "Red_Extract_Duration", Bytes, 1153),
                new PlDataItemCustomView(this, "White Extract Duration", "White_Extract_Duration", Bytes, 1157),
                new PlDataItemCustomView(this, "Orange Extract Duration", "Orange_Extract_Duration", Bytes, 1161),
                new PlDataItemCustomView(this, "Triple Extract Duration", "Triple_Extract_Duration", Bytes, 1165),
            };
        }
    }
}