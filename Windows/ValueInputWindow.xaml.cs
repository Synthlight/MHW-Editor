using System.Windows;

namespace MHW_Editor.Windows {
    public partial class ValueInputWindow : Window {
        public string Value { get; private set; }

        public ValueInputWindow(string title, string message, string okText, string cancelText, string defaultValue = "") {
            InitializeComponent();
            Title = title;
            lbl_message.Text = message;
            btn_ok.Content = okText;
            btn_cancel.Content = cancelText;
            txt_value.Text = defaultValue;
            txt_value.Focus();
            txt_value.SelectAll();
        }

        private void Btn_ok_Click(object sender, RoutedEventArgs e) {
            Value = txt_value.Text;
            DialogResult = true;
            Close();
        }

        private void Btn_cancel_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
    }
}
