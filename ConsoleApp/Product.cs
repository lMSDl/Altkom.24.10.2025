using System;
using System.ComponentModel;

namespace ConsoleApp
{
    internal class Product : INotifyPropertyChanged
    {
        private string _name;
        private decimal _price;
        private string _description;
        private string _category;
        private string _categoryName;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                    _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                    _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                    _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public string Category
        {
            get => _category;
            set
            {
                if (_category != value)
                    _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }
        public string CategoryName
        {
            get => _categoryName;
            set
            {
                if (_categoryName != value)
                    _categoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
         => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
