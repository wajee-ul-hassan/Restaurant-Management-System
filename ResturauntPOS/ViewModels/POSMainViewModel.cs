using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RestaurantPOS.Commands;
using RestaurantPOS.Views;

namespace RestaurantPOS.ViewModels
{
    public class POSMainViewModel : INotifyPropertyChanged
    {
        private UserControl _currentView;

        public UserControl CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateTakeawayCommand { get; }
        public ICommand NavigateDineInCommand { get; }
        public ICommand NavigateDeliveryCommand { get; }

        public POSMainViewModel()
        {
            NavigateTakeawayCommand = new RelayCommand(_ => LoadTakeawayView());
            NavigateDineInCommand = new RelayCommand(_ => LoadDineInView());
            NavigateDeliveryCommand = new RelayCommand(_ => LoadDeliveryView());

            LoadTakeawayView(); // Default view
        }

        private void LoadTakeawayView()
        {
            CurrentView = new RestaurantPOS.Views.TakeawayView();
        }

        private void LoadDineInView()
        {
            CurrentView = new RestaurantPOS.Views.DineInView();
        }

        private void LoadDeliveryView()
        {
            CurrentView = new RestaurantPOS.Views.DeliveryView();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
