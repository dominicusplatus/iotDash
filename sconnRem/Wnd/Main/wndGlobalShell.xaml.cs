﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
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
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using sconnRem.Model.Global;

namespace sconnRem.Wnd.Main
{
    /// <summary>
    /// Interaction logic for wndGlobalShell.xaml
    /// </summary>

    public static class GlobalViewRegionNames
    {
        public const String MainGridContentRegion = "MainViewGridRegion";
        public const String RNavigationRegion = "RightSideToolbarRegion";
        public const String LNavigationRegion = "LeftSideMenuRegion";
        public const String RopNavigationRegion = "TopToolbarRegion";
    }



    [Export]
    public partial class WndGlobalShell : Window    //, IPartImportsSatisfiedNotification
    {

        //private const string StartModuleName = "AlarmAuthConfigModule";
        //private static Uri _startViewUri = new Uri("/View/Config/AlarmSystem/AuthConfig", UriKind.Relative);

        //public WndGlobalShell()
        //{
        //    InitializeComponent();
        //}

        //[Import(AllowRecomposition = false)]
        //public IModuleManager ModuleManager;

        //[Import(AllowRecomposition = false)]
        //public IRegionManager RegionManager;

        //public void OnImportsSatisfied()
        //{
        //    this.ModuleManager.LoadModuleCompleted +=
        //        (s, e) =>
        //        {

        //            if (e.ModuleInfo.ModuleName == StartModuleName)
        //            {
        //                this.RegionManager.RequestNavigate(
        //                    Config.RegionNames.MainContentRegion,
        //                    _startViewUri);
        //            }
        //        };
        //}

        public WndGlobalShell()
        {
            InitializeComponent();
        }

        //[Import]
        //GlobalShellViewModel ViewModel
        //{
        //    set
        //    {
        //        this.DataContext = value;
        //    }
        //}


    }

}
