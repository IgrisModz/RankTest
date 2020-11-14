using IgrisLib;
using IgrisLib.MessageBox;
using IgrisLib.Mvvm;
using RankTest.Models;
using RankTest.Modz;
using RankTest.Properties;
using System;
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
            Functions = new Functions(PS3);
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
        }

        ~MainViewModel()
        {
            base.Dispose();
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
            return Settings.Default.API != "PS3API";
        }

        private bool CanExecuteConnect()
        {
            return PS3 != null;
        }

        private bool CanExecuteGetStats()
        {
            return IsAttached && Stats == null && Classes == null;
        }

        private bool CanExecuteSetStatsEtc()
        {
            return IsAttached && Stats != null && Classes != null;
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
                        IsAttached = true;
                        return;
                    }
                    else
                    {
                        IgrisMessageBox.Show($"The process is \"{PS3.CurrentGame}\".", "Wrong process...", MessageBoxButton.OK, MessageBoxImage.Hand);
                        PS3.DetachProcess();
                    }
                }
                else
                {
                    IgrisMessageBox.Show("Unable to attach process.", "Attach failed..", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
            }
            else
            {
                IgrisMessageBox.Show("Unable to connect to PS3.", "Connect failed..", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            IsAttached = false;
        }
        #endregion

        private void GetStats()
        {
            PS3.GetMemory(Addresses.StatsEntry, Functions.Extension.Dump);
            Stats = Functions.GetStats();
            Classes = Functions.GetClasses();
            SelectedClass = Classes.FirstOrDefault();
            StatsEnabled = true;
            ClassesEnabled = true;
        }

        private void SetStats()
        {
            Functions.SetStats(Stats, UnlockAll);
            Functions.SetClasses(Classes);
            PS3.SetMemory(Addresses.StatsEntry, Functions.Extension.Dump);
            Stats = null;
            Classes = null;
            SelectedClass = null;
            StatsEnabled = false;
            ClassesEnabled = false;
            UnlockAll = false;
        }

        #region Stats
        private void HighStats()
        {
            Random rnd = new Random();
            int prestige = Stats.Prestige;
            int wins = rnd.Next(15000, 20000);
            int losses = rnd.Next(1000, 5000);
            int ties = rnd.Next(10, 40);
            int kills = rnd.Next(200000, 800000);
            int deaths = rnd.Next(60000, 120000);
            int hits = rnd.Next(800000, 1400000);
            int misses = rnd.Next(80000, 300000);
            Stats = new Stats()
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
        }

        private void LegitStats()
        {
            Random rnd = new Random();
            int prestige = Stats.Prestige;
            int wins = rnd.Next(15000, 20000);
            int losses = rnd.Next(1000, 5000);
            int ties = rnd.Next(10, 40);
            int kills = rnd.Next(200000, 800000);
            int deaths = rnd.Next(60000, 120000);
            int hits = rnd.Next(800000, 1400000);
            int misses = rnd.Next(80000, 300000);
            Stats = new Stats()
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
        }
        #endregion

        #region Classes
        private void ColorClasses()
        {
            uint color = 1;
            foreach (var c in Classes)
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
        }

        private void LogoClassName()
        {
            SelectedClass.Name = $"^~~{(char)SelectedLogoClass.Length}{SelectedLogoClass}";
        }

        private void LogoAllClassesName()
        {
            foreach (var c in Classes)
            {
                c.Name = $"^~~{(char)SelectedLogoClass.Length}{SelectedLogoClass}";
            }
        }

        private void SetCustomClass()
        {
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
                        SelectedClass.Deathstreak = Deathstreaks.HOLLOW_POINT;
                        SelectedClass.Godmode = false;
                    }
                }
            }
            catch (NullReferenceException)
            {
                IgrisMessageBox.Show("Select class before modify class", "Failed...", MessageBoxButton.OK, MessageBoxImage.Error);
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
