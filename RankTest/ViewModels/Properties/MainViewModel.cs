using IgrisLib;
using IgrisLib.Mvvm;
using MahApps.Metro.Controls.Dialogs;
using RankTest.Core;
using System.Collections.Generic;

namespace RankTest.ViewModels
{
    /// <summary>
    /// All properties of MainViewModel
    /// </summary>
    public partial class MainViewModel
    {
        /// <summary>
        /// Property for contact with the ps3
        /// </summary>
        public PS3API PS3 { get; }

        /// <summary>
        /// Dialog for ShowMessageDialog MahApps.Metro
        /// </summary>
        public IDialogCoordinator Dialog { get; }

        /// <summary>
        /// Property of local Read/Write memory
        /// </summary>
        public FunctionsExtension Extension { get; }

        /// <summary>
        /// Last function used
        /// </summary>
        public string Status { get => GetValue(() => Status); set => SetValue(() => Status, value); }

        /// <summary>
        /// Info of the current stats
        /// </summary>
        public Stats Stats { get => GetValue(() => Stats); set => SetValue(() => Stats, value); }

        /// <summary>
        /// Info of the current selected class
        /// </summary>
        public Class SelectedClass { get => GetValue(() => SelectedClass); set => SetValue(() => SelectedClass, value); }

        /// <summary>
        /// Logo list for the classes
        /// </summary>
        public List<string> LogoClasses { get => GetValue(() => LogoClasses); set => SetValue(() => LogoClasses, value); }

        /// <summary>
        /// List of custom classes
        /// </summary>
        public List<string> CustomsClasses { get => GetValue(() => CustomsClasses); set => SetValue(() => CustomsClasses, value); }

        /// <summary>
        /// Selected text to logo list
        /// </summary>
        public string SelectedLogoClass { get => GetValue(() => SelectedLogoClass); set => SetValue(() => SelectedLogoClass, value); }

        /// <summary>
        /// Selected class to custom classes list
        /// </summary>
        public string SelectedCustomClass { get => GetValue(() => SelectedCustomClass); set => SetValue(() => SelectedCustomClass, value); }

        /// <summary>
        /// Check if this tool is attached to the game
        /// </summary>
        public bool IsAttached { get => GetValue(() => IsAttached); set => SetValue(() => IsAttached, value); }

        /// <summary>
        /// Enum for all stats type
        /// </summary>
        public StatsType StatsType { get => GetValue(() => StatsType); set => SetValue(() => StatsType, value); }

        /// <summary>
        /// Bool for active stats type
        /// </summary>
        public bool StatsTypeEnabled { get => GetValue(() => StatsTypeEnabled); set => SetValue(() => StatsTypeEnabled, value); }

        /// <summary>
        /// Check if stats is getted
        /// </summary>
        public bool StatsEnabled { get => GetValue(() => StatsEnabled); set => SetValue(() => StatsEnabled, value); }

        /// <summary>
        /// Check if you want enable unlock all in set stats
        /// </summary>
        public bool UnlockAll { get => GetValue(() => UnlockAll); set => SetValue(() => UnlockAll, value); }

        /// <summary>
        /// Check if godmode is possibly to enabled
        /// </summary>
        public bool GodmodeBool { get => GetValue(() => GodmodeBool); set => SetValue(() => GodmodeBool, value); }

        /// <summary>
        /// Command for use target manager api
        /// </summary>
        public DelegateCommand TMAPICommand { get; }

        /// <summary>
        /// Command for use control console api
        /// </summary>
        public DelegateCommand CCAPICommand { get; }

        /// <summary>
        /// Command for use ps3 manager api
        /// </summary>
        public DelegateCommand PS3MAPICommand { get; }

        /// <summary>
        /// Command for use connection to the selected ps3
        /// </summary>
        public DelegateCommand ConnectCommand { get; }

        /// <summary>
        /// Command for Get stats (local/split screen) 
        /// </summary>
        public DelegateCommand GetStatsCommand { get; }

        /// <summary>
        /// Command for Set stats (local/split screen)
        /// </summary>
        public DelegateCommand SetStatsCommand { get; }

        /// <summary>
        /// Command for generate high stats
        /// </summary>
        public DelegateCommand HighStatsCommand { get; }

        /// <summary>
        /// Command for generate legit stats
        /// </summary>
        public DelegateCommand LegitStatsCommand { get; }

        /// <summary>
        /// Command for generate color to all classes
        /// </summary>
        public DelegateCommand ColorClassesCommand { get; }

        /// <summary>
        /// Command for generate the logo to name of selected class
        /// </summary>
        public DelegateCommand LogoClassNameCommand { get; }

        /// <summary>
        /// Command for generate the logo to name of all classes
        /// </summary>
        public DelegateCommand LogoAllClassesNameCommand { get; }

        /// <summary>
        /// Command for generate the custom class to the selected class
        /// </summary>
        public DelegateCommand SetCustomClassCommand { get; }

        /// <summary>
        /// Command for check if godmode class is possibly enabled
        /// </summary>
        public DelegateCommand StrikePackageChangedCommand { get; }
    }
}
