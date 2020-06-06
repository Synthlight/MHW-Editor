using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MHW_Editor.Models {
    public class GroupFilter {
        private readonly Dictionary<PropertyInfo, string> filterMap = new Dictionary<PropertyInfo, string>();

        public Predicate<object> MergedFilters { get; }

        public GroupFilter() {
            MergedFilters = InternalFilter;
        }

        private bool InternalFilter(object obj) {
            foreach (var filter in filterMap) {
                var filterText = filter.Value;
                if (filterText == null) continue;

                var propertyInfo = filter.Key;
                var value        = propertyInfo.GetGetMethod().Invoke(obj, null).ToString();
                if (!value.ToLower().Contains(filterText.ToLower())) {
                    return false;
                }
            }

            return true;
        }

        public void AddFilter(PropertyInfo propertyInfo) {
            filterMap.Add(propertyInfo, null);
        }

        public void RemoveFilter(PropertyInfo propertyInfo) {
            if (filterMap.ContainsKey(propertyInfo)) {
                filterMap.Remove(propertyInfo);
            }
        }

        public void SetFilterValue(PropertyInfo propertyInfo, string newValue) {
            if (filterMap.ContainsKey(propertyInfo)) {
                filterMap[propertyInfo] = newValue;
            }
        }

        public void SetFilterValue(string propertyName, string newValue) {
            if (newValue == "") newValue = null;

            foreach (var propertyInfo in filterMap.Keys.ToList()) {
                if (propertyInfo.Name == propertyName) {
                    filterMap[propertyInfo] = newValue;
                }
            }
        }
    }
}