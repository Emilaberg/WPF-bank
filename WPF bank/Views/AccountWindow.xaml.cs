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
using System.Windows.Shapes;
using WPF_bank.Controllers;
using WPF_bank.Managers;

namespace WPF_bank.Views
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        
        public AccountWindow()
        {
            InitializeComponent();
            
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            ViewsController.adminPanel().Show();
            Close();
        }
    }
}
