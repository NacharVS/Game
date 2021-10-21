using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameCharacterEditor.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page warrior = new WarriorPage();
        private Page mage = new MagePage();
        private Page rogue = new RoguePage();
        private Page s77 = new s77Page();

        private Page _CurPage = new WarriorPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenWrPage
        {
            get
            {
                return new RelayCommand(() => CurPage = warrior);
            }
        }

        public ICommand OpenMgPage
        {
            get
            {
                return new RelayCommand(() => CurPage = mage);
            }
        }

        public ICommand OpenRgPage
        {
            get
            {
                return new RelayCommand(() => CurPage = rogue);
            }
        }

        public ICommand Open77Page
        {
            get
            {
                return new RelayCommand(() => CurPage = s77);
            }
        }
    }
}
