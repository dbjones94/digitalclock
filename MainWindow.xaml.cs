using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Digital_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Clock
        {
            public string clockformat;
        }




        public MainWindow()
        {
            
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Clock clock = new Clock() { clockformat = DateTime.Now.ToString("hh:mm.ss tt") };
            Clock oppclock = new Clock() { clockformat = DateTime.Now.ToString("HH:mm.ss") };
            dateBlock.Text = DateTime.Now.ToString("MMMM dd yyyy");
            timeBlock.Text = clock.clockformat;
            timeBlock_Copy.Text = oppclock.clockformat;
            
        }

        private void TimeButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            timeBlock.Visibility = Visibility.Collapsed;
            TimeButton.Visibility = Visibility.Collapsed;
            TimeButton_Copy.Visibility = Visibility.Visible;
            timeBlock_Copy.Visibility = Visibility.Visible;

        }

        private void TimeButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            timeBlock_Copy.Visibility = Visibility.Collapsed;
            TimeButton_Copy.Visibility = Visibility.Collapsed;
            TimeButton.Visibility = Visibility.Visible;
            timeBlock.Visibility = Visibility.Visible;
        }
    }
}
