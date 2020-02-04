using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using MHW_Editor.Models;
using Application = System.Windows.Application;
using Control = System.Windows.Forms.Control;

namespace MHW_Editor {
    public partial class GetNewItemId {
        public ushort currentItem { get; set; }
        public bool cancelled { get; private set; }

        // ReSharper disable once MemberCanBeMadeStatic.Global
        public Dictionary<ushort, IdNamePair> dataProxy { get; }

        public GetNewItemId(ushort currentItem, Dictionary<ushort, IdNamePair> data) {
            this.currentItem = currentItem;
            dataProxy = data;

            InitializeComponent();

            // Center on cursor.
            var transform = PresentationSource.FromVisual(Application.Current.MainWindow).CompositionTarget.TransformFromDevice;
            var mouse = transform.Transform(GetMousePosition());
            Left = mouse.X - Width / 2;
            Top = mouse.Y - 10;

            cbx_current_item.KeyUp += Cbx_current_item_KeyUp;
            cbx_current_item.Loaded += (sender, args) => cbx_current_item.EditableTextBox.Focus(); // Focus & highlight the text.
            btn_ok.Click += (sender, args) => Ok();
            btn_cancel.Click += (sender, args) => Cancel();
        }

        private void Cbx_current_item_KeyUp(object sender, KeyEventArgs e) {
            if (cbx_current_item.IsDropDownOpen) return;

            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (e.Key) {
                case Key.Enter:
                    Ok();
                    break;
                case Key.Escape:
                    Cancel();
                    break;
            }
        }

        private void Ok() {
            cancelled = false;
            Close();
        }

        private void Cancel() {
            cancelled = true;
            Close();
        }

        public static Point GetMousePosition() {
            var point = Control.MousePosition;
            return new Point(point.X, point.Y);
        }
    }
}