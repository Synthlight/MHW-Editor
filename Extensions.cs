using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace MHW_Editor {
    public static class Extensions {
        public static DataGridColumn FindColumn(this IEnumerable<DataGridColumn> list, string name) {
            return list.FirstOrDefault(x => x.Header.ToString() == name);
        }
    }
}