using System.Windows;

namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();

        }


    }
}
