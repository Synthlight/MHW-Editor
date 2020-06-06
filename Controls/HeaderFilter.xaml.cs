using System.Windows;
using System.Windows.Controls;

namespace MHW_Editor.Controls {
    public partial class HeaderFilter {
        public static readonly DependencyProperty HeaderTextProperty = DependencyProperty.Register(nameof(HeaderText), typeof(string), typeof(HeaderFilter), new PropertyMetadata(""));

        public string HeaderText {
            get => (string) GetValue(HeaderTextProperty);
            set => SetValue(HeaderTextProperty, value);
        }

        public static readonly DependencyProperty PropertyNameProperty = DependencyProperty.Register(nameof(PropertyName), typeof(string), typeof(HeaderFilter), new PropertyMetadata(""));

        public string PropertyName {
            get => (string) GetValue(PropertyNameProperty);
            set => SetValue(PropertyNameProperty, value);
        }

        public static readonly RoutedEvent OnFilterChangedEvent = EventManager.RegisterRoutedEvent(nameof(OnFilterChanged), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(HeaderFilter));

        public event RoutedEventHandler OnFilterChanged {
            add => AddHandler(OnFilterChangedEvent, value);
            remove => RemoveHandler(OnFilterChangedEvent, value);
        }

        public string FilterText { get; set; }

        public HeaderFilter() {
            InitializeComponent();
        }

        private void OnFilterTextChanged(object sender, TextChangedEventArgs e) {
            var newEventArgs = new RoutedEventArgs(OnFilterChangedEvent);
            RaiseEvent(newEventArgs);
        }
    }
}