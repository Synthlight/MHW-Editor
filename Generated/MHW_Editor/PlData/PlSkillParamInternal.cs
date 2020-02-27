using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlSkillParam {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "Speed Eating 1 Drink Motion Speed", "Speed_Eating_1_Drink_Motion_Speed", Bytes, 8),
            };
        }
    }
}