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

namespace AnimalSimsUp.windowsAnimal
{
    /// <summary>
    /// Interaktionslogik für gameOverScreen.xaml
    /// </summary>
    public partial class gameOverScreen : UserControl
    {
        public gameOverScreen()
        {
            InitializeComponent();
        }

        private void closeGameButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.Close();
        }
    }
}
