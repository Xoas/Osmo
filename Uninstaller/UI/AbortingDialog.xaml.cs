﻿using Uninstaller.ViewModel;
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

namespace Uninstaller.UI
{
    /// <summary>
    /// Interaction logic for AbortingDialog.xaml
    /// </summary>
    public partial class AbortingDialog : DockPanel
    {
        public AbortingDialog()
        {
            InitializeComponent();
            DataContext = AbortingViewModel.Instance;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
