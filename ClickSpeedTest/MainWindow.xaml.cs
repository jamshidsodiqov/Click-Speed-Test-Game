using System;
using System.Media;
using System.Windows;
using System.Windows.Threading;

namespace ClickSpeedTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DispatcherTimer dt = new DispatcherTimer();
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
    
        }

        float count = 0;
        float interval = 0;
        float time;
        bool check = false;

        public void dtTicker(object sender, EventArgs e)
        {
            interval--;
            timetxt.Text = interval.ToString();
            if (interval == 0)
            {
                dt.Stop();
                
                MessageBox.Show(count / time + " clicks per second");
                Startbtn.Content = "Click anywhere to begin".ToString();
                clicktxt.Text = "".ToString();
                timetxt.Text = "".ToString();
                check = false;
                btn1.IsEnabled = true;
                btn5.IsEnabled = true;
                btn10.IsEnabled = true;
                btn20.IsEnabled = true;
                btn30.IsEnabled = true;
                btn60.IsEnabled = true;
                count = 0;
            }

        }

        public void Startbtn_Click(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                count++;
                dt.Start();
                clicktxt.Text = count.ToString();
                Startbtn.Content = "".ToString();
            }
            else MessageBox.Show("Please select time");

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\MouseTrapQuickCli PE1057112.wav");
            player.Load();
            player.Play();
        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 1;
            time = interval;
            btn5.IsEnabled = false;
            btn10.IsEnabled = false;
            btn20.IsEnabled = false;
            btn30.IsEnabled = false;
            btn60.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void btn5_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 5;
            time = interval;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            btn20.IsEnabled = false;
            btn30.IsEnabled = false;
            btn60.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void btn10_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 10;
            time = interval;
            btn1.IsEnabled = false;
            btn5.IsEnabled = false;
            btn20.IsEnabled = false;
            btn30.IsEnabled = false;
            btn60.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void btn20_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 20;
            time = interval;
            btn1.IsEnabled = false;
            btn5.IsEnabled = false;
            btn10.IsEnabled = false;
            btn30.IsEnabled = false;
            btn60.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void btn30_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 30;
            time = interval;
            btn5.IsEnabled = false;
            btn10.IsEnabled = false;
            btn20.IsEnabled = false;
            btn1.IsEnabled = false;
            btn60.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void btn60_click(object sender, RoutedEventArgs e)
        {
            check = true;
            interval = 60;
            time = interval;
            btn5.IsEnabled = false;
            btn10.IsEnabled = false;
            btn20.IsEnabled = false;
            btn30.IsEnabled = false;
            btn1.IsEnabled = false;

            SoundPlayer player = new SoundPlayer(@"D:\DOT-NET\WPF\ClickSpeedTest\ClickSpeedTest\sound\ButtonSolidCompute SE040304.wav");
            player.Load();
            player.Play();
        }

        private void exitbtn_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
