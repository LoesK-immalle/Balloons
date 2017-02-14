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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Balloon> balloons = new List<Balloon>();
        static Random rndGen = new Random();

        public MainWindow()
        {
            InitializeComponent();

            for(var i = 0; i<666; i++)
            {
                Balloon newBalloon = new Balloon(canvas, rndGen.Next(1,50), rndGen.Next(300), rndGen.Next(300));
                balloons.Add(newBalloon);
                newBalloon.Text = "Happy Valentine's Day";
                if (i % 3 == 0)
                {
                    newBalloon.Colour = Brushes.Black;
                }
            }
        }

        public void InitializeBalloons()
        {
            canvas.Children.Clear();
            for (var i = 0; i < 666; i++)
            {
                Balloon newBalloon = new Balloon(canvas, rndGen.Next(1, 50), rndGen.Next(300), rndGen.Next(300));
                balloons.Add(newBalloon);
                if (i % 3 == 0)
                {
                    newBalloon.Colour = Brushes.Black;
                }
            }
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var b in balloons)
            {
                b.Grow();
            }
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var b in balloons)
            {
                b.Move();
            }
        }

        private void initButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeBalloons();
        }
    }
}
