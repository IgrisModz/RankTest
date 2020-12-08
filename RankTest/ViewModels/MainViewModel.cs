using IgrisLib;
using IgrisLib.MessageBox;
using IgrisLib.Mvvm;
using RankTest.Core;
using RankTest.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RankTest.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            switch (Settings.Default.API)
            {
                case "TMAPI":
                    PS3 = new PS3API(new TMAPI());
                    break;
                case "CCAPI":
                    PS3 = new PS3API(new CCAPI());
                    break;
                case "PS3MAPI":
                    PS3 = new PS3API(new PS3MAPI());
                    break;
                default:
                    PS3 = new PS3API(new TMAPI());
                    break;
            }
            SelectedClass = new Class();
            TMAPICommand = new DelegateCommand(TMAPI, CanExecuteTMAPI);
            CCAPICommand = new DelegateCommand(CCAPI, CanExecuteCCAPI);
            PS3MAPICommand = new DelegateCommand(PS3MAPI, CanExecutePS3MAPI);
            ConnectCommand = new DelegateCommand(Connect, CanExecuteConnect);
            GetStatsCommand = new DelegateCommand(GetStats, CanExecuteGetStats);
            SetStatsCommand = new DelegateCommand(SetStats, CanExecuteSetStatsEtc);
            HighStatsCommand = new DelegateCommand(HighStats, CanExecuteSetStatsEtc);
            LegitStatsCommand = new DelegateCommand(LegitStats, CanExecuteSetStatsEtc);
            ColorClassesCommand = new DelegateCommand(ColorClasses, CanExecuteSetStatsEtc);
            LogoClassNameCommand = new DelegateCommand(LogoClassName, CanExecuteSetStatsEtc);
            LogoAllClassesNameCommand = new DelegateCommand(LogoAllClassesName, CanExecuteSetStatsEtc);
            SetCustomClassCommand = new DelegateCommand(SetCustomClass, CanExecuteSetStatsEtc);
            StrikePackageChangedCommand = new DelegateCommand(StrikePackageChanged, CanExecuteSetStatsEtc);
            LogoClasses = new List<string>()
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
            CustomsClasses = new List<string>()
            {
                "GODMODE ACR 6.8",
                "GODMODE MP7",
                "AUG HBAR"
            };
            SelectedLogoClass = "cardicon_weed";
            SelectedCustomClass = "GODMODE ACR 6.8";
            Status = "Connected to any ps3!";
        }

        ~MainViewModel()
        {
           Dispose();
        }

        #region CanExecute
        private bool CanExecuteTMAPI()
        {
            return Settings.Default.API != "TMAPI";
        }

        private bool CanExecuteCCAPI()
        {
            return Settings.Default.API != "CCAPI";
        }

        private bool CanExecutePS3MAPI()
        {
            return Settings.Default.API != "PS3MAPI";
        }

        private bool CanExecuteConnect()
        {
            return PS3 != null;
        }

        private bool CanExecuteGetStats()
        {
            return IsAttached && Stats == null;
        }

        private bool CanExecuteSetStatsEtc()
        {
            return IsAttached && Stats != null;
        }
        #endregion

        #region API
        private void TMAPI()
        {
            IsAttached = false;
            PS3.ChangeAPI(new TMAPI());
            Settings.Default.API = "TMAPI";
            Settings.Default.Save();
        }

        private void CCAPI()
        {
            IsAttached = false;
            PS3.ChangeAPI(new CCAPI());
            Settings.Default.API = "CCAPI";
            Settings.Default.Save();
        }

        private void PS3MAPI()
        {
            IsAttached = false;
            PS3.ChangeAPI(new PS3MAPI());
            Settings.Default.API = "PS3MAPI";
            Settings.Default.Save();
        }
        #endregion

        #region Connection
        private void Connect()
        {
            if (PS3.ConnectTarget())
            {
                if (PS3.AttachProcess())
                {
                    if (PS3.GetCurrentGame() == "Modern Warfare® 3")
                    {
                        IgrisMessageBox.Show($"Succesfully attached to \"{PS3.CurrentGame}\".", "Success..", MessageBoxButton.OK, MessageBoxImage.Information);
                        Status = $"Attached to {PS3.CurrentGame}!";
                        IsAttached = true;
                        return;
                    }
                    else
                    {
                        IgrisMessageBox.Show($"The process is \"{PS3.CurrentGame}\".", "Wrong process...", MessageBoxButton.OK, MessageBoxImage.Hand);
                        Status = $"{PS3.CurrentGame} is a wrong process, immediate detachment!";
                        PS3.DetachProcess();
                    }
                }
                else
                {
                    IgrisMessageBox.Show("Unable to attach process.", "Attach failed..", MessageBoxButton.OK, MessageBoxImage.Hand);
                    Status = "Attached to any process!";
                }
            }
            else
            {
                IgrisMessageBox.Show("Unable to connect to PS3.", "Connect failed..", MessageBoxButton.OK, MessageBoxImage.Hand);
                Status = "Connected to any ps3!";
            }
            IsAttached = false;
        }
        #endregion

        private bool GetAttached()
        {
            if (!PS3.GetAttached())
            {
                IsAttached = false;
                Stats = null;
                SelectedClass = null;
                StatsEnabled = false;
                UnlockAll = false;
                GodmodeBool = false;
                Status = !PS3.GetConnected() ? "Connected to any ps3!" : "Attached to any process!";
                return false;
            }
            return true;
        }

        private void GetStats()
        {
            if (!GetAttached())
                return;
            Stats = new Stats(PS3);
            PS3.GetMemory(Addresses.StatsEntry, Stats.Extension.Dump);
            Stats = Stats.GetStats();
            SelectedClass = Stats.Classes.FirstOrDefault();
            StatsEnabled = true;
            Status = "Stats getted!";
        }

        private void SetStats()
        {
            if (!GetAttached())
                return;
            Stats.SetStats(UnlockAll);
            PS3.SetMemory(Addresses.StatsEntry, Stats.Extension.Dump);
            Stats = null;
            SelectedClass = null;
            StatsEnabled = false;
            UnlockAll = false;
            Status = $"Stats setted {(UnlockAll ? "with" : "without")} unlock all!";
        }

        #region Stats
        private void HighStats()
        {
            if (!GetAttached())
                return;
            Random rnd = new Random();
            int prestige = Stats.Prestige;
            int wins = rnd.Next(15000, 20000);
            int losses = rnd.Next(1000, 5000);
            int ties = rnd.Next(10, 40);
            int kills = rnd.Next(200000, 800000);
            int deaths = rnd.Next(60000, 120000);
            int hits = rnd.Next(800000, 1400000);
            int misses = rnd.Next(80000, 300000);
            Stats = new Stats(PS3)
            {
                Prestige = prestige,
                Level = 80,
                Score = rnd.Next(600000000, 1200000000),
                Wins = wins,
                Losses = losses,
                Ties = ties,
                Winstreak = rnd.Next(100, 500),
                Kills = kills,
                Deaths = deaths,
                Headshots = rnd.Next(60000, 140000),
                Assists = rnd.Next(50000, 100000),
                Killstreak = rnd.Next(100, 350),
                TimePlayed = new int[] { rnd.Next(15, 20), rnd.Next(0, 23), rnd.Next(0, 59) },
                DoubleXp = new int[3],
                DoubleWeaponXp = new int[3],
                Hits = hits,
                Misses = misses,
                Tokens = prestige,
                AddClasses = 5,
                MWPrestige = 10,
                WAWPrestige = 10,
                MW2Prestige = 10,
                BOPrestige = 15,
                //KDRatio = Convert.ToSingle(((float)kills / (float)deaths).ToString("0.00")),
                //WLRatio = Convert.ToSingle(((float)wins / (float)losses).ToString("0.00")),
                //Accuracy = $"{((100 * hits) / (hits + misses)):0.00}%",
                //GamePlayed = wins + losses + ties
            };
            Status = "High stats generated!";
        }

        private void LegitStats()
        {
            if (!GetAttached())
                return;
            Random rnd = new Random();
            int prestige = Stats.Prestige;
            int wins = rnd.Next(15000, 20000);
            int losses = rnd.Next(1000, 5000);
            int ties = rnd.Next(10, 40);
            int kills = rnd.Next(200000, 800000);
            int deaths = rnd.Next(60000, 120000);
            int hits = rnd.Next(800000, 1400000);
            int misses = rnd.Next(80000, 300000);
            Stats = new Stats(PS3)
            {
                Prestige = prestige,
                Level = 80,
                Score = rnd.Next(600000000, 1200000000),
                Wins = wins,
                Losses = losses,
                Ties = ties,
                Winstreak = rnd.Next(100, 500),
                Kills = kills,
                Deaths = deaths,
                Headshots = rnd.Next(60000, 140000),
                Assists = rnd.Next(50000, 100000),
                Killstreak = rnd.Next(100, 350),
                TimePlayed = new int[] { rnd.Next(15, 20), rnd.Next(0, 23), rnd.Next(0, 59) },
                DoubleXp = new int[3],
                DoubleWeaponXp = new int[3],
                Hits = hits,
                Misses = misses,
                Tokens = prestige,
                AddClasses = 5,
                MWPrestige = 10,
                WAWPrestige = 10,
                MW2Prestige = 10,
                BOPrestige = 15,
                //KDRatio = Convert.ToSingle(((float)kills / (float)deaths).ToString("0.00")),
                //WLRatio = Convert.ToSingle(((float)wins / (float)losses).ToString("0.00")),
                //Accuracy = $"{((100 * hits) / (hits + misses)):0.00}%",
                //GamePlayed = wins + losses + ties
            };
            Status = "Legit stats generated";
        }
        #endregion

        #region Classes
        private void ColorClasses()
        {
            if (!GetAttached())
                return;
            uint color = 1;
            foreach (var c in Stats.Classes)
            {
                if (c.Name.Length <= 18 && c.Name.Length >= 2)
                {
                    if (!(c.Name.Substring(0, 1).Contains($"^") && c.Name.Substring(1, 1).All(char.IsDigit)))
                    {
                        c.Name = $"^{color}{c.Name}";
                        if (color < 6)
                        {
                            color++;
                            if (color == 4)
                                color++;
                        }
                        else
                            color = 1;
                    }
                }
            }
            Status = "Color of all classes are generated!";
        }

        private void LogoClassName()
        {
            if (!GetAttached())
                return;
            SelectedClass.Name = $"^~~{(char)SelectedLogoClass.Length}{SelectedLogoClass}";
            Status = "Logo of the selected class is generated!";
        }

        private void LogoAllClassesName()
        {
            if (!GetAttached())
                return;
            foreach (var c in Stats.Classes)
            {
                c.Name = $"^~~{(char)SelectedLogoClass.Length}{SelectedLogoClass}";
            }
            Status = "Logo of all classes are generated!";
        }

        private void SetCustomClass()
        {
            if (!GetAttached())
                return;
            try
            {
                if (SelectedClass != null)
                {
                    if (SelectedCustomClass == "GODMODE ACR 6.8")
                    {
                        SelectedClass.Perk1 = Perks1.SLEIGHT_OF_HAND;
                        SelectedClass.Perk2 = Perks2.OVERKILL;
                        SelectedClass.Perk3 = Perks3.STALKER;
                        SelectedClass.PrimaryWeapon = WeaponIndex.BARRETT_50;
                        SelectedClass.PrimaryWeaponProficiency = Proficiencies.NONE;
                        SelectedClass.PrimaryWeaponAttachment1 = Attachments.NONE;
                        SelectedClass.PrimaryWeaponAttachment2 = Attachments.NONE;
                        SelectedClass.PrimaryWeaponReticle = Reticle.NONE;
                        SelectedClass.PrimaryWeaponCamo = Camos.NONE;
                        SelectedClass.SecondaryWeapon = WeaponIndex.ACR_68;
                        SelectedClass.SecondaryWeaponProficiency = Proficiencies.ATTACHMENTS;
                        SelectedClass.SecondaryWeaponAttachment1 = Attachments.EXTENDED_MAGS;
                        SelectedClass.SecondaryWeaponAttachment2 = Attachments.SILENCER;
                        SelectedClass.SecondaryWeaponReticle = Reticle.NONE;
                        SelectedClass.SecondaryWeaponCamo = Camos.GOLD;
                        SelectedClass.Lethal = Lethal.FRAG;
                        SelectedClass.Tactical = Tactical.CONCUSSION_GRENADE;
                        SelectedClass.StrikePackage = StrikePackage.SPECIALIST;
                        SelectedClass.Assault1 = Assault.NONE;
                        SelectedClass.Assault2 = Assault.NONE;
                        SelectedClass.Assault3 = Assault.NONE;
                        SelectedClass.Support1 = Support.NONE;
                        SelectedClass.Support2 = Support.NONE;
                        SelectedClass.Support3 = Support.NONE;
                        SelectedClass.Specialist1 = Specialist.HARDLINE;
                        SelectedClass.Specialist2 = Specialist.SCAVENGER;
                        SelectedClass.Specialist3 = Specialist.STALKER;
                        SelectedClass.Deathstreak = Deathstreaks.NONE;
                        SelectedClass.Godmode = true;
                        Status = "Godmode class with acr 6.8 is generated!";
                    }
                    else if (SelectedCustomClass == "GODMODE MP7")
                    {
                        SelectedClass.Perk1 = Perks1.SLEIGHT_OF_HAND;
                        SelectedClass.Perk2 = Perks2.OVERKILL;
                        SelectedClass.Perk3 = Perks3.STALKER;
                        SelectedClass.PrimaryWeapon = WeaponIndex.BARRETT_50;
                        SelectedClass.PrimaryWeaponProficiency = Proficiencies.NONE;
                        SelectedClass.PrimaryWeaponAttachment1 = Attachments.NONE;
                        SelectedClass.PrimaryWeaponAttachment2 = Attachments.NONE;
                        SelectedClass.PrimaryWeaponReticle = Reticle.NONE;
                        SelectedClass.PrimaryWeaponCamo = Camos.NONE;
                        SelectedClass.SecondaryWeapon = WeaponIndex.MP7;
                        SelectedClass.SecondaryWeaponProficiency = Proficiencies.ATTACHMENTS;
                        SelectedClass.SecondaryWeaponAttachment1 = Attachments.EXTENDED_MAGS;
                        SelectedClass.SecondaryWeaponAttachment2 = Attachments.SILENCER;
                        SelectedClass.SecondaryWeaponReticle = Reticle.NONE;
                        SelectedClass.SecondaryWeaponCamo = Camos.GOLD;
                        SelectedClass.Lethal = Lethal.FRAG;
                        SelectedClass.Tactical = Tactical.CONCUSSION_GRENADE;
                        SelectedClass.StrikePackage = StrikePackage.SPECIALIST;
                        SelectedClass.Assault1 = Assault.NONE;
                        SelectedClass.Assault2 = Assault.NONE;
                        SelectedClass.Assault3 = Assault.NONE;
                        SelectedClass.Support1 = Support.NONE;
                        SelectedClass.Support2 = Support.NONE;
                        SelectedClass.Support3 = Support.NONE;
                        SelectedClass.Specialist1 = Specialist.HARDLINE;
                        SelectedClass.Specialist2 = Specialist.SCAVENGER;
                        SelectedClass.Specialist3 = Specialist.STALKER;
                        SelectedClass.Deathstreak = Deathstreaks.NONE;
                        SelectedClass.Godmode = true;
                        Status = "Godmode class with mp7 is generated!";
                    }
                    else
                    {
                        SelectedClass.Perk1 = Perks1.SLEIGHT_OF_HAND;
                        SelectedClass.Perk2 = Perks2.OVERKILL;
                        SelectedClass.Perk3 = Perks3.STALKER;
                        SelectedClass.PrimaryWeapon = WeaponIndex.AUGH_BAR;
                        SelectedClass.PrimaryWeaponProficiency = Proficiencies.IMPACT;
                        SelectedClass.PrimaryWeaponAttachment1 = Attachments.RAPID_FIRE;
                        SelectedClass.PrimaryWeaponAttachment2 = Attachments.NONE;
                        SelectedClass.PrimaryWeaponReticle = Reticle.NONE;
                        SelectedClass.PrimaryWeaponCamo = Camos.BLUE;
                        SelectedClass.SecondaryWeapon = WeaponIndex.ACR_68;
                        SelectedClass.SecondaryWeaponProficiency = Proficiencies.ATTACHMENTS;
                        SelectedClass.SecondaryWeaponAttachment1 = Attachments.EXTENDED_MAGS;
                        SelectedClass.SecondaryWeaponAttachment2 = Attachments.SILENCER;
                        SelectedClass.SecondaryWeaponReticle = Reticle.NONE;
                        SelectedClass.SecondaryWeaponCamo = Camos.GOLD;
                        SelectedClass.Lethal = Lethal.FRAG;
                        SelectedClass.Tactical = Tactical.CONCUSSION_GRENADE;
                        SelectedClass.StrikePackage = StrikePackage.ASSAULT;
                        SelectedClass.Assault1 = Assault.UAV;
                        SelectedClass.Assault2 = Assault.PAVE_LOW;
                        SelectedClass.Assault3 = Assault.JUGGERNAUT;
                        SelectedClass.Support1 = Support.NONE;
                        SelectedClass.Support2 = Support.NONE;
                        SelectedClass.Support3 = Support.NONE;
                        SelectedClass.Specialist1 = Specialist.NONE;
                        SelectedClass.Specialist2 = Specialist.NONE;
                        SelectedClass.Specialist3 = Specialist.NONE;
                        SelectedClass.Deathstreak = Deathstreaks.HOLLOW_POINTS;
                        SelectedClass.Godmode = false;
                        Status = "Aughbar class is generated!";
                    }
                }
            }
            catch (NullReferenceException)
            {
                IgrisMessageBox.Show("Select class before modify class", "Failed...", MessageBoxButton.OK, MessageBoxImage.Error);
                Status = "Custom class was not generated!";
            }
        }

        private void StrikePackageChanged()
        {
            if (SelectedClass != null && SelectedClass.StrikePackage == StrikePackage.SPECIALIST)
            {
                GodmodeBool = true;
            }
            else if (SelectedClass != null && SelectedClass.StrikePackage != StrikePackage.SPECIALIST)
            {
                GodmodeBool = false;
                SelectedClass.Godmode = false;
            }
            else
            {
                GodmodeBool = false;
            }
        }
        #endregion
    }
}
