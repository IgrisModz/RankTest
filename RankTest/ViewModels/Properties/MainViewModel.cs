using IgrisLib;
using IgrisLib.Mvvm;
using RankTest.Core;
using System.Collections.Generic;

namespace RankTest.ViewModels
{
    public partial class MainViewModel
    {
        private Class selectedClass;

        public PS3API PS3 { get; }

        public string Status { get => GetValue(() => Status); set => SetValue(() => Status, value); }

        public Stats Stats { get => GetValue(() => Stats); set => SetValue(() => Stats, value); }

        public Class SelectedClass { get => selectedClass; set => SetProperty(ref selectedClass, value); }

        public List<string> LogoClasses { get => GetValue(() => LogoClasses); set => SetValue(() => LogoClasses, value); }

        public List<string> CustomsClasses { get => GetValue(() => CustomsClasses); set => SetValue(() => CustomsClasses, value); }

        public string SelectedLogoClass { get => GetValue(() => SelectedLogoClass); set => SetValue(() => SelectedLogoClass, value); }

        public string SelectedCustomClass { get => GetValue(() => SelectedCustomClass); set => SetValue(() => SelectedCustomClass, value); }

        public bool IsAttached { get => GetValue(() => IsAttached); set => SetValue(() => IsAttached, value); }

        public bool StatsEnabled { get => GetValue(() => StatsEnabled); set => SetValue(() => StatsEnabled, value); }

        public bool UnlockAll { get => GetValue(() => UnlockAll); set => SetValue(() => UnlockAll, value); }

        public bool GodmodeBool { get => GetValue(() => GodmodeBool); set => SetValue(() => GodmodeBool, value); }

        public DelegateCommand TMAPICommand { get; }

        public DelegateCommand CCAPICommand { get; }

        public DelegateCommand PS3MAPICommand { get; }

        public DelegateCommand ConnectCommand { get; }

        public DelegateCommand GetStatsCommand { get; }

        public DelegateCommand SetStatsCommand { get; }

        public DelegateCommand HighStatsCommand { get; }

        public DelegateCommand LegitStatsCommand { get; }

        public DelegateCommand ColorClassesCommand { get; }

        public DelegateCommand LogoClassNameCommand { get; }

        public DelegateCommand LogoAllClassesNameCommand { get; }

        public DelegateCommand SetCustomClassCommand { get; }

        public DelegateCommand StrikePackageChangedCommand { get; }
    }
}
