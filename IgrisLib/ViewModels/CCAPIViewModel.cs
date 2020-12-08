using IgrisLib.MessageBox;
using IgrisLib.Mvvm;
using IgrisLib.Views;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace IgrisLib.ViewModels
{
    public class CCAPIViewModel : ViewModelBase
    {
        private IDialogCoordinator dialogCoordinator;
        private readonly ResourceDictionary Resources;
        private readonly CCAPIWindow Win;
        private Consoles selectedConsole;

        public IConnectAPI Api { get; set; }

        public Consoles SelectedConsole
        {
            get => selectedConsole;
            set
            {
                SetProperty(ref selectedConsole, value);
                ConnectEnabled = value != null;
            }
        }

        public List<Consoles> Consoles { get => GetValue(() => Consoles); set => SetValue(() => Consoles, value); }

        public bool ConnectEnabled { get => GetValue(() => ConnectEnabled); set => SetValue(() => ConnectEnabled, value); }

        public DelegateCommand ConnectCommand { get; }

        public DelegateCommand RefreshCommand { get; }

        public CCAPIViewModel(CCAPIWindow win, IDialogCoordinator instance, IConnectAPI api, ResourceDictionary resources)
        {
            Win = win ?? throw new ArgumentNullException(nameof(win));
            dialogCoordinator = instance ?? throw new ArgumentNullException(nameof(instance));
            Api = api ?? throw new ArgumentNullException(nameof(api));
            Resources = resources ?? throw new ArgumentNullException(nameof(resources));
            ConnectCommand = new DelegateCommand(Connect, CanExecuteConnect);
            RefreshCommand = new DelegateCommand(Refresh, CanExecuteRefresh);
            Refresh();
        }

        private CCAPIViewModel()
        {

        }

        private bool CanExecuteConnect()
        {
            return Api != null && SelectedConsole != null;
        }

        private bool CanExecuteRefresh()
        {
            return Api != null;
        }

        private List<Consoles> GetConsoles()
        {

            List<Consoles> list = new List<Consoles>();
            foreach (CCAPI.ConsoleInfo consoleInfo in Api.GetConsoleList())
            {
                list.Add(new Consoles() { Text = $"{consoleInfo.name} : {consoleInfo.ip}", Name = consoleInfo.name, Ip = consoleInfo.ip });
            }
            return list;
        }

        private async void Connect()
        {
            if (SelectedConsole != null)
            {
                if (Api.ConnectTarget(SelectedConsole.Ip))
                {
                    Win.Result = true;
                }
                else
                    Win.Result = false;
                Win.Close();
                return;
            }
            else
                await dialogCoordinator.ShowMessageAsync(this, Resources["errorSelectTitle"].ToString(), Resources["errorSelect"].ToString());
        }

        private void Refresh()
        {
            Consoles = GetConsoles();
            SelectedConsole = Consoles.FirstOrDefault();
        }
    }
}
