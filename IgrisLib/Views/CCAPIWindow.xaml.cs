using IgrisLib.ViewModels;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Linq;
using System.Windows;

namespace IgrisLib.Views
{
    /// <summary>
    /// Interaction logic for CCAPIWindow.xaml
    /// </summary>
    public partial class CCAPIWindow : MetroWindow
    {
        public bool Result { get; internal set; }

        public IConnectAPI Api { get; private set; }

        public CCAPIWindow(IConnectAPI api, ResourceDictionary resources)
        {
            Api = api;
            ViewModel = new CCAPIViewModel(this, DialogCoordinator.Instance, api, resources);
            InitializeComponent();
            Resources = resources;
            listView.Focus();
        }

        private CCAPIWindow()
        {
            InitializeComponent();
        }

        internal CCAPIViewModel ViewModel
        {
            get => DataContext as CCAPIViewModel;
            set => DataContext = value;
        }

        internal new bool Show()
        {
            if (ViewModel.Consoles.Count() > 0)
            {
                ShowDialog();
            }
            else
            {

                Result = false;
                Close();
                SendError();
            }
            return Result;
        }

        private async void SendError()
        {
            await this.ShowMessageAsync(Resources["noConsoleTitle"].ToString(), Resources["noConsole"].ToString());
        }
    }
}
