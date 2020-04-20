using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace MHW_Editor.Models {
    public interface IOnPropertyChanged {
        [NotifyPropertyChangedInvocator]
        void OnPropertyChanged([CallerMemberName] string propertyName = null);

        void OnPropertyChanged(IEnumerable<string> propertyName);

        void OnPropertyChanged(params string[] propertyName);
    }
}