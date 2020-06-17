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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hardware h;


        public MainWindow()
        {
            InitializeComponent();
            new Get_CPU_Temp5().GetSystemInfo(); 
            this.Left = 0;
            this.Top = 0;
            h = new Hardware();
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(updateForm);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        
        private void updateForm(object sender, EventArgs e)
        {
            Console.WriteLine(1);
            Dispatcher.BeginInvoke(new ThreadStart(delegate
            {

                h.getInfo();
                cpuTempFull.Content = h.cpuTempFull;
                cpuTempMaxFull.Content = h.cpuTempMaxFull;

                gpuTemp.Content = h.gpuTemp;
                gpuTempMax.Content = h.gpuTempMax;
            }));



    }
    }
}
