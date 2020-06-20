﻿using System;
using System.Collections.Generic;
using MvvmHelpers;
using SoundCloudClone.Interfaces;
using SoundCloudClone.Models.App;
using Xamarin.Forms;

namespace SoundCloudClone.ViewModels
{
    public class ThemeViewModel : BaseViewModel
    {
        public IList<Theme> Options { get; private set; }
        public Command OptionSelectedCommand { get; private set; }

        public ThemeViewModel(ITheme theme)
        {
            Options = theme.GetOptions();
            OptionSelectedCommand = new Command(OptionSelected);
        }

        private void OptionSelected()
        {
            System.Diagnostics.Debug.WriteLine("INVOCOU O COMANDO");
        }
    }
}
