using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using MHW_Editor.Windows.Models;

namespace MHW_Editor.Controls {
    public class AutoFilteredComboBox : ComboBox {
        // https://stackoverflow.com/a/55190176

        private          string           CurrentFilter = string.Empty;
        private          bool             TextBoxFrozen;
        public           TextBox          EditableTextBox => GetTemplateChild("PART_EditableTextBox") as TextBox;
        private readonly UserChange<bool> IsDropDownOpenUC;

        public AutoFilteredComboBox() {
            IsDropDownOpenUC =  new UserChange<bool>(v => IsDropDownOpen = v);
            DropDownOpened   += FilteredComboBox_DropDownOpened;

            Loaded += (s, e) => {
                if (EditableTextBox != null) {
                    EditableTextBox.TrackUserChange().UserTextChanged += FilteredComboBox_UserTextChange;
                }
            };
        }

        public void ClearFilter() {
            if (string.IsNullOrEmpty(CurrentFilter)) return;
            CurrentFilter = "";
            CollectionViewSource.GetDefaultView(ItemsSource).Refresh();
        }

        private void FilteredComboBox_DropDownOpened(object sender, EventArgs e) {
            //if user opens the drop down show all items
            if (IsDropDownOpenUC.IsUserChange) ClearFilter();
        }

        private void FilteredComboBox_UserTextChange(object sender, EventArgs e) {
            if (TextBoxFrozen) return;
            var tb = EditableTextBox;
            if (tb.SelectionStart + tb.SelectionLength == tb.Text.Length) {
                CurrentFilter = tb.Text.Substring(0, tb.SelectionStart).ToLower();
            } else {
                CurrentFilter = tb.Text.ToLower();
            }

            RefreshFilter();
        }

        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue) {
            if (newValue != null) {
                var view = CollectionViewSource.GetDefaultView(newValue);
                view.Filter += FilterItem;
            }

            if (oldValue != null) {
                var view                      = CollectionViewSource.GetDefaultView(oldValue);
                if (view != null) view.Filter -= FilterItem;
            }

            base.OnItemsSourceChanged(oldValue, newValue);
        }

        private void RefreshFilter() {
            if (ItemsSource == null) return;

            var view = CollectionViewSource.GetDefaultView(ItemsSource);
            FreezeTextBoxState(() => {
                var isDropDownOpen = IsDropDownOpen;
                //always hide because showing it enables the user to pick with up and down keys, otherwise it's not working because of the glitch in view.Refresh()
                IsDropDownOpenUC.Set(false);
                view.Refresh();

                if (!string.IsNullOrEmpty(CurrentFilter) || isDropDownOpen) IsDropDownOpenUC.Set(true);

                if (SelectedItem == null) {
                    foreach (var itm in ItemsSource) {
                        if (itm.ToString() == Text) {
                            SelectedItem = itm;
                            break;
                        }
                    }
                }
            });
        }

        private void FreezeTextBoxState(Action action) {
            TextBoxFrozen = true;
            var tb       = EditableTextBox;
            var text     = Text;
            var selStart = tb.SelectionStart;
            var selLen   = tb.SelectionLength;
            action();
            Text               = text;
            tb.SelectionStart  = selStart;
            tb.SelectionLength = selLen;
            TextBoxFrozen      = false;
        }

        private bool FilterItem(object value) {
            if (value == null) return false;
            if (CurrentFilter.Length == 0) return true;

            if (value is KeyValuePair<ushort, IdNamePair<ushort>>
                || value is KeyValuePair<short, IdNamePair<short>>
                || value is KeyValuePair<uint, IdNamePair<uint>>
                || value is KeyValuePair<int, IdNamePair<int>>
                || value is KeyValuePair<byte, IdNamePair<byte>>
                || value is KeyValuePair<sbyte, IdNamePair<sbyte>>) {
                dynamic obj = value;
                return obj.Value.name.ToLower().Contains(CurrentFilter) || obj.Value.id.ToString().ToLower().Contains(CurrentFilter);
            }

            return value.ToString().ToLower().Contains(CurrentFilter);
        }
    }

    public class TextBoxBaseUserChangeTracker {
        private bool IsTextInput { get; set; }

        public           TextBoxBase TextBox { get; set; }
        private readonly List<Key>   PressedKeys = new List<Key>();
        public event EventHandler    UserTextChanged;
        private string               LastText;

        public TextBoxBaseUserChangeTracker(TextBoxBase textBox) {
            TextBox  = textBox;
            LastText = TextBox.ToString();

            textBox.PreviewTextInput += (s, e) => { IsTextInput = true; };

            textBox.TextChanged += (s, e) => {
                var isUserChange = PressedKeys.Count > 0 || IsTextInput || LastText == TextBox.ToString();
                IsTextInput = false;
                LastText    = TextBox.ToString();
                if (isUserChange) UserTextChanged?.Invoke(this, e);
            };

            textBox.PreviewKeyDown += (s, e) => {
                // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
                switch (e.Key) {
                    case Key.Back:
                    case Key.Space:
                    case Key.Delete:
                        if (!PressedKeys.Contains(e.Key)) PressedKeys.Add(e.Key);
                        break;
                }
            };

            textBox.PreviewKeyUp += (s, e) => {
                if (PressedKeys.Contains(e.Key)) PressedKeys.Remove(e.Key);
            };

            textBox.LostFocus += (s, e) => {
                PressedKeys.Clear();
                IsTextInput = false;
            };
        }
    }

    public static class ExtensionMethods {
        #region DependencyObject

        public static T FindParent<T>(this DependencyObject child) where T : DependencyObject {
            while (true) {
                //get parent item
                var parentObject = VisualTreeHelper.GetParent(child);

                //we've reached the end of the tree
                if (parentObject == null) return null;

                //check if the parent matches the type we're looking for
                if (parentObject is T parent) return parent;
                child = parentObject;
            }
        }

        #endregion

        #region TextBoxBase

        public static TextBoxBaseUserChangeTracker TrackUserChange(this TextBoxBase textBox) {
            return new TextBoxBaseUserChangeTracker(textBox);
        }

        #endregion
    }

    public class UserChange<T> {
        private readonly Action<T> action;

        public bool IsUserChange { get; private set; } = true;

        public UserChange(Action<T> action) {
            this.action = action;
        }

        public void Set(T val) {
            try {
                IsUserChange = false;
                action(val);
            } finally {
                IsUserChange = true;
            }
        }
    }
}