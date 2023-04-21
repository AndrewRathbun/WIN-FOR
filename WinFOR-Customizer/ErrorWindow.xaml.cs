﻿using System.Windows;
using System.Text;

namespace WinFOR_Customizer
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        public ErrorWindow(StringBuilder errors)
        {
            InitializeComponent();
            ErrorsTextBox.Text = errors.ToString();
        }
    }
}
