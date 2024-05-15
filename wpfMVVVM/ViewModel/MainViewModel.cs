using System.ComponentModel;
using System.Windows;
using wpfMVVVM.Command;
using wpfMVVVM.View;

namespace wpfMVVVM.ViewModel
{
    public class MainViewModell : INotifyPropertyChanged
    {
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentView"));
            }
        }

        private GreenView greenView;
        private YellowView yellowView;
        private PurpleView purpleView;

        public event PropertyChangedEventHandler? PropertyChanged;

        //protected void OnPropertyChanged()
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentView"));
        //}

        public RelayCommand YellowViewCommand { get; }
        public RelayCommand GreenViewCommand { get; }
        public RelayCommand PurpleViewCommand { get; }
        public RelayCommand KilepesEbbolACsodabol { get; }

        public MainViewModell()
        {
            yellowView = new YellowView();
            greenView = new GreenView();
            purpleView = new PurpleView();
            CurrentView = greenView;

            YellowViewCommand = new RelayCommand(setYellow);
            GreenViewCommand = new RelayCommand(x => CurrentView = greenView);
            PurpleViewCommand = new RelayCommand(x => CurrentView = purpleView);
            KilepesEbbolACsodabol = new RelayCommand(exitApp);

        }

        private void setYellow(object v)
        {
            CurrentView = yellowView;
        }

        private void exitApp(object v)
        {
            Application.Current.Shutdown();
        }

    }
}
