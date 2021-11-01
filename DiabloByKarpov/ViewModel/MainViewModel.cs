using GalaSoft.MvvmLight.Command;
using DiabloByKarpov.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DiabloByKarpov.ViewModel
{
    internal class MainViewModel : ViewModedBase
    {
        private Page Wr = new WarriorPage();
        private Page Mg = new MagePage();
        private Page Rg = new RoguePage();
        private Page s77 = new s77Page();

        private Page dung = new DungeonPage();
        private Page shop = new ShopPage();
        private Page heroMaker = new HeroMaker();

        private Page _CurPage = new WarriorPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }
        public ICommand OpenWarriorPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Wr);
            }
        }
        public ICommand OpenMagePage
        {
            get
            {
                return new RelayCommand(() => CurPage = Mg);
            }
        }
        public ICommand OpenRoguePage
        {
            get
            {
                return new RelayCommand(() => CurPage = Rg);
            }
        }
        public ICommand Opens77Page
        {
            get
            {
                return new RelayCommand(() => CurPage = s77);
            }
        }
        public ICommand OpenDungeonPage
        {
            get
            {
                return new RelayCommand(() => CurPage = dung);
            }
        }
        public ICommand OpenShopPage
        {
            get
            {
                return new RelayCommand(() => CurPage = shop);
            }
        }
        public ICommand OpenHeroMakerPage
        {
            get
            {
                return new RelayCommand(() => CurPage = heroMaker);
            }
        }
    }
}
