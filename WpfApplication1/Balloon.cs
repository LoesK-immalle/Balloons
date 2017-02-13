using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 100;
        private int y = 100;
        private int diameter = 10;
        private int fontSize = 1;

        private Brush BackgroundBrush = new SolidColorBrush(Colors.Aquamarine);

        Ellipse ellipse = new Ellipse();
        TextBlock TxtBlck = new TextBlock();


        public Balloon(Canvas canvas)
        {
            UpdateEllipse();
            canvas.Children.Add(ellipse);
            canvas.Children.Add(TxtBlck);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;

            UpdateEllipse();
            canvas.Children.Add(ellipse);
            canvas.Children.Add(TxtBlck);
        }

        public Balloon(Canvas canvas, int diameter, int yCoord, int xCoord)
        {
            this.diameter = diameter;
            y = yCoord;
            x = xCoord;

            UpdateEllipse();
            canvas.Children.Add(ellipse);
            canvas.Children.Add(TxtBlck);
        }

        void UpdateEllipse()
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.DeepPink);
            ellipse.Fill = BackgroundBrush;

            TxtBlck.Text = "Happy Birthday!";
            TxtBlck.Height = diameter;
            TxtBlck.Width = diameter;
            TxtBlck.Margin = new Thickness(x + diameter / 4, y + diameter / 2, 0, 0);
            TxtBlck.FontSize = fontSize;
            TxtBlck.FontFamily = new FontFamily("Broadway");

        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;

            fontSize = fontSize + 2;
            TxtBlck.Width = diameter;
            TxtBlck.Height = diameter;
            TxtBlck.FontSize = fontSize;
            TxtBlck.Margin = new Thickness(x , y + diameter / 2, 0, 0);
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);

            TxtBlck.Margin = new Thickness(x, y + diameter / 2, 0, 0);
        }
        public Brush Colour
        {
            get
            {
                return BackgroundBrush;
            }
            set
            {
                BackgroundBrush = value;
                UpdateEllipse();
            }
        }

    }
}
