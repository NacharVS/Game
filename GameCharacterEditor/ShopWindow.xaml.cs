using GameCharacterEditor.Item;
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
using System.Windows.Shapes;

namespace GameCharacterEditor
{
    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public ShopWindow()
        {
            InitializeComponent();
        }

        private void HelmetsLV_Loaded(object sender, RoutedEventArgs e)
        {
            List<Weapon> weaponsList = new List<Weapon>();

            weaponsList.Add(new Weapon()
            {
                ImgSource = "Images/Sabr.png",
                Name = "Relict sabr",
                Description = "Incredibly lightweight and durable.Its blade cuts equally easily through the air, small trees and... flesh",
                RequiredLVL = 8,
                Required_str = 70,
                Required_dex = 0,
                Required_const = 50,
                Required_int = 0,
                Damage = 100,
                CritChance = 0.15,
                DamageBoost = 2
            });

            weaponsList.Add(new Weapon()
            {
                ImgSource = "Images/Axe.png",
                Name = "Axe of the dwart",
                Description = "Is it so easy to take something away from a dwarf? Those who tried to take this ancient artifact from its owner are not able to answer",
                RequiredLVL = 8,
                Required_str = 100,
                Required_dex = 0,
                Required_const = 80,
                Required_int = 0,
                Damage = 130,
                CritChance = 0.05,
                DamageBoost = 4
            });

            weaponsList.Add(new Weapon()
            {
                ImgSource = "Images/Scepter.png",
                Name = "Scepter of the Rebel",
                Description = "The weapon of true master. Powerful arrows fly so fast and silently that enemy will not have time to undestand that he died. A very humane weapon",
                RequiredLVL = 8,
                Required_str = 0,
                Required_dex = 0,
                Required_const = 0,
                Required_int = 100,
                Damage = 90,
                CritChance = 0.12,
                DamageBoost = 3
            });

            WeaponsLV.ItemsSource = weaponsList;
        }
    }
}
