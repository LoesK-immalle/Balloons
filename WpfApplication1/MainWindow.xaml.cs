﻿using System;
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

        public MainWindow()
        {
            InitializeComponent();

            for(var i = 0; i<666; i++)
            {
                Balloon newBalloon = new Balloon(canvas, 20);
                balloons.Add(newBalloon);
            }
        }

        public void InitializeBalloons()
        {
            canvas.Children.Clear();
            for (var i = 0; i < 666; i++)
            {
                Balloon newBalloon = new Balloon(canvas, 20);
                balloons.Add(newBalloon);
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
