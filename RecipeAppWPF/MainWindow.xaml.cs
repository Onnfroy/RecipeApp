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

namespace RecipeAppWPF
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
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new AddRecipePage();
        }

        private void ViewRecipes_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ViewRecipesPage();
        }

        private void CreateMenu_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CreateMenuPage();
        }
    }
}
