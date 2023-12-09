using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Patron_MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int count;

        // La anotacion agrega internamente SumarCommand
        [RelayCommand]
        public void Sumar()
        {
            Count++;
        }
    }
}
