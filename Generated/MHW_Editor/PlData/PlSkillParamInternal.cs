using System.Collections.ObjectModel;
using MHW_Editor.Models;

namespace MHW_Editor.PlData {
    public partial class PlSkillParam {
        public ObservableCollection<PlDataItemCustomView> GetCustomView() {
            return new ObservableCollection<PlDataItemCustomView> {
                new PlDataItemCustomView(this, "A", "A", Bytes, 8),
            };
        }
    }
}