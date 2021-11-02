using GalaSoft.MvvmLight.Command;
using CharacterEditor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CharacterEditor.ViewPages
{
    internal class MainViewPages : PagesFoundation
    {
        private Page Warrior = new WPage();
        private Page Archer = new APage();
        private Page Outlaw = new OPage();
        private Page Mage = new MPage();
        private Page _CurPage = new WPage();


        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenWPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Warrior);
            }
        }       

    public ICommand OpenAPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Archer);
            }
        }
        public ICommand OpenOPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Outlaw);
            }
        }
        public ICommand OpenMPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Mage);
            }
        }
    }
}
