using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace YoutubeMusicLoader
{
    public partial class MainWindow : Window
    {
        private const string ToolsFolder = @".\Tools";
        private const string MusicFolder = @".\Music";

        public MainWindow()
        {
            InitializeComponent();

            Loaded += (s, e) => textBoxLink.Focus();

            textBoxLink.KeyDown += (s, e) =>
            {
                if (e.Key == System.Windows.Input.Key.Enter)
                {
                    buttonDownload.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                }
            };

            buttonDownload.Click += async (s, e) =>
            {
                textBlockStatusBar.Text = "Processing...";

                var link = textBoxLink.Text.Trim();

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = $"{ToolsFolder}\\youtube-dl.exe",
                    Arguments = $"--extract-audio --audio-format mp3 -o {MusicFolder}\\%(title)s.%(ext)s {link}",
                    CreateNoWindow = true,
                };

                await Task.Run(() => Process.Start(processStartInfo).WaitForExit());

                textBlockStatusBar.Text = "Finished.";
            };
        }
    }
}
