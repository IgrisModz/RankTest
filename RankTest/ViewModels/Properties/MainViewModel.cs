using IgrisLib;
using IgrisLib.Mvvm;
using RankTest.Models;
using RankTest.Modz;
using System.Collections.Generic;

namespace RankTest.ViewModels
{
    public partial class MainViewModel
    {
        private List<string> logoClasses = new List<string>()
        {
            "cardicon_weed",
            "facebook",
            "ps3network",
            "xp",
            "gxp",
            "clanlvl_0",
            "clanlvl_1",
            "clanlvl_2",
            "clanlvl_3",
            "clanlvl_4",
            "clanlvl_5",
            "clanlvl_6",
            "clanlvl_7",
            "clanlvl_8",
            "clanlvl_9",
            "killicondied",
            "killiconcrush",
            "killiconfalling",
            "killiconsuicide",
            "killiconheadshot",
            "killiconmelee",
            "killiconimpact",
            "weapon_c4",
            "weapon_claymore",
            "weapon_rpg7",
            "weapon_ak47",
            "weapon_aks74u",
            "weapon_aw50",
            "weapon_cheytac",
            "weapon_colt_45",
            "weapon_mp412",
            "weapon_g36",
            "weapon_gp25",
            "weapon_kriss",
            "weapon_m14ebr",
            "weapon_m16a4",
            "weapon_m203",
            "weapon_m249saw",
            "weapon_m40a3",
            "weapon_mini_uzi",
            "weapon_mp44",
            "weapon_mp5",
            "weapon_p90",
            "weapon_ranger",
            "weapon_striker",
            "weapon_skorpion",
            "weapon_usp_45",
            "weapon_ump45",
            "weapon_fn2000",
            "weapon_acr",
            "weapon_type95",
            "weapon_glock",
            "weapon_mk14",
            "weapon_scar_h",
            "weapon_usas12",
            "weapon_pp2000",
            "weapon_tavor",
            "weapon_tmp",
            "weapon_m4_short",
            "weapon_aa12",
            "weapon_javelin",
            "weapon_smaw",
            "weapon_stinger",
            "weapon_m320",
            "weapon_mp5k",
            "weapon_wa2000",
            "weapon_spas12",
            "weapon_xm25",
            "weapon_mp7",
            "weapon_msr",
            "weapon_p99",
            "weapon_m60e4",
            "weapon_mk46",
            "weapon_sa80",
            "weapon_pp90m1",
            "weapon_fad",
            "weapon_rsass",
            "weapon_barrett",
            "weapon_dragunov",
            "weapon_as50",
            "weapon_ksg",
            "weapon_magnum",
            "weapon_mp9",
            "weapon_fmg9",
            "weapon_cm901",
            "weapon_mg36",
            "weapon_l96a1"
        };
        private List<string> customsClasses = new List<string>()
        {
            "GODMODE ACR 6.8",
            "GODMODE MP7",
            "AUG HBAR"
        };
        private Stats stats;
        private List<Class> classes;
        private Class selectedClass;
        private string selectedLogoClass = "cardicon_weed";
        private string selectedCustomClass = "GODMODE ACR 6.8";
        private bool isAttached;
        private bool statsEnabled;
        private bool classesEnabled;
        private bool unlockAll;
        private bool godmodeBool;

        public PS3API PS3 { get; }

        public Functions Functions { get; }

        public Stats Stats { get => stats; set => SetProperty(ref stats, value); }

        public List<Class> Classes { get => classes; set => SetProperty(ref classes, value); }

        public Class SelectedClass { get => selectedClass; set => SetProperty(ref selectedClass, value); }

        public List<string> LogoClasses { get => logoClasses; set => SetProperty(ref logoClasses, value); }

        public List<string> CustomsClasses { get => customsClasses; set => SetProperty(ref customsClasses, value); }

        public string SelectedLogoClass { get => selectedLogoClass; set => SetProperty(ref selectedLogoClass, value); }

        public string SelectedCustomClass { get => selectedCustomClass; set => SetProperty(ref selectedCustomClass, value); }

        public bool IsAttached { get => isAttached; set => SetProperty(ref isAttached, value); }

        public bool StatsEnabled { get => statsEnabled; set => SetProperty(ref statsEnabled, value); }

        public bool ClassesEnabled { get => classesEnabled; set => SetProperty(ref classesEnabled, value); }

        public bool UnlockAll { get => unlockAll; set => SetProperty(ref unlockAll, value); }

        public bool GodmodeBool { get => godmodeBool; set => SetProperty(ref godmodeBool, value); }

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
