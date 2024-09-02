using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson7TaskContinuetionAsyncawaitkeyword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoSomething()
        {
            Thread.Sleep(3000);
            Dispatcher.Invoke(() => { Title = "Salam"; });
        }

        private async Task<string> DoSomethingAsync()
        {
            await Task.Delay(5000);
            return "Salam";
        }

        private async Task<string> DoSomething1Async()
        {
            HttpClient client = new();
            var result = await client.GetStringAsync("https://google.com");
            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(DoSomething);
            thread.Start();
        }

        private async Task Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = await DoSomething1Async();
            txt.Text = a;
        }
    }
}