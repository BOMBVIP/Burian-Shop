using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BurianShop.MVVM.ViewModel
{
    public class RoleViewModel : INotifyPropertyChanged
    {
        private string name;
        private int id;

        public int Id { get => id;  set { id = value; OnPropertyChanged(); } }
        public string Name { get => name;  set { name = value; OnPropertyChanged(); } }
        //public ICollection<UserViewModel> Users { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}