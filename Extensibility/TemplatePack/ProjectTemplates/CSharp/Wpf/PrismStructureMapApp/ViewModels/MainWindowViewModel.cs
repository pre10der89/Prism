﻿using Prism.Mvvm;

namespace $safeprojectname$.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism StructureMap Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
