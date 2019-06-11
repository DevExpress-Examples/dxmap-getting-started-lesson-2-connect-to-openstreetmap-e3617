using System.Windows;

namespace DXMapLesson2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
        }
        private void OnWebRequest(object sender, DevExpress.Xpf.Map.MapWebRequestEventArgs e) {
            e.UserAgent = "DevExpress OpenStreetMapProvider example";
        }
    }
}
