﻿using CalcTrainer.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalcTrainer.Core.Views
{
    /// <summary>
    /// Interaction logic for AvaitingView.xaml
    /// </summary>
    public partial class AvaitingView : UserControl
    {



        public AvaitingView(BaseViewModel avaitingViewModel)
        {
            InitializeComponent();
            this.DataContext = avaitingViewModel;
        }
    }
}
