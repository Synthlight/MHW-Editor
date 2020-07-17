using System.Collections.Generic;

namespace MHW_Editor.Models {
    public interface IHasChildren {
        IEnumerable<F> GetAllEnumerableChildrenOfType<F>();
    }
}