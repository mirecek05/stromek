using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace stromek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,0,500);
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int cislo = random.Next(1, 5);
            if (cislo == 1)
            {
                cervena1.Source = (ImageSource)FindResource("yellow");
                cervena2.Source = (ImageSource)FindResource("yellow");
                zlata1.Source = (ImageSource)FindResource("red");
                zlata2.Source = (ImageSource)FindResource("red");
                zluta1.Source = (ImageSource)FindResource("blue");
                zluta2.Source = (ImageSource)FindResource("blue");
                modra1.Source = (ImageSource)FindResource("gold");
                modra2.Source = (ImageSource)FindResource("gold");


            }
            else if (cislo == 2)
            {
                cervena1.Source = (ImageSource)FindResource("gold");
                cervena2.Source = (ImageSource)FindResource("gold");
                zlata1.Source = (ImageSource)FindResource("yellow");
                zlata2.Source = (ImageSource)FindResource("yellow");
                zluta1.Source = (ImageSource)FindResource("red");
                zluta2.Source = (ImageSource)FindResource("red");
                modra1.Source = (ImageSource)FindResource("blue");
                modra2.Source = (ImageSource)FindResource("blue");

            }
            else if (cislo == 3)
            {
                cervena1.Source = (ImageSource)FindResource("blue");
                cervena2.Source = (ImageSource)FindResource("blue");
                zlata1.Source = (ImageSource)FindResource("gold");
                zlata2.Source = (ImageSource)FindResource("gold");
                zluta1.Source = (ImageSource)FindResource("yellow");
                zluta2.Source = (ImageSource)FindResource("yellow");
                modra1.Source = (ImageSource)FindResource("red");
                modra2.Source = (ImageSource)FindResource("red");
            }
            else if (cislo ==4)
            {
                cervena1.Source = (ImageSource)FindResource("red");
                cervena2.Source = (ImageSource)FindResource("red");
                zlata1.Source = (ImageSource)FindResource("blue");
                zlata2.Source = (ImageSource)FindResource("blue");
                zluta1.Source = (ImageSource)FindResource("gold");
                zluta2.Source = (ImageSource)FindResource("gold");
                modra1.Source = (ImageSource)FindResource("yellow");
                modra2.Source = (ImageSource)FindResource("yellow");
            }









        }
    }
}
