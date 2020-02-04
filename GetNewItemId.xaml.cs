using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using Application = System.Windows.Application;

namespace MHW_Editor {
    public partial class GetNewItemId {
        public ushort currentItem { get; set; }
        public bool cancelled { get; private set; }

        // ReSharper disable once MemberCanBeMadeStatic.Global
        public Dictionary<ushort, IdNamePair> itemDataProxy => DataHelper.itemData[MainWindow.locale];

        public GetNewItemId(ushort currentItem) {
            this.currentItem = currentItem;

            InitializeComponent();

            var transform = PresentationSource.FromVisual(Application.Current.MainWindow).CompositionTarget.TransformFromDevice;
            var mouse = transform.Transform(GetMousePosition());
            Left = mouse.X - Width / 2;
            Top = mouse.Y - 10;

            btn_ok.Click += Btn_ok_Click;
            btn_cancel.Click += Btn_cancel_Click;
        }

        public static Point GetMousePosition() {
            var point = Control.MousePosition;
            return new Point(point.X, point.Y);
        }

        private void Btn_ok_Click(object sender, RoutedEventArgs e) {
            cancelled = false;
            Close();
        }

        private void Btn_cancel_Click(object sender, RoutedEventArgs e) {
            cancelled = true;
            Close();
        }
    }
}