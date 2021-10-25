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
using HeroFabric;
using GameCore.Class;

namespace DiabloByKarpov.View
{
    /// <summary>
    /// Логика взаимодействия для MagePage.xaml
    /// </summary>
    public partial class MagePage : Page
    {
        HeroMakerDefult hmd;

        public MagePage()
        {
            InitializeComponent();

            hmd = new HeroMakerDefult();
            gridHero.ItemsSource = hmd.GetMageLst();
        }
    }
}
