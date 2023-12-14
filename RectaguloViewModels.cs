using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenProga_2.ViewModels
{
    internal class RectaguloViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _base;
        public double Base
        {
            get { return _base; }
            set
            {

                _base = value;
                OnPropertyChanged();
                CalculateAreaCommand.ChangeCanExecute();
            }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged();
                CalculateAreaCommand.ChangeCanExecute();
            }
        }

        private double _area;
        public double Area
        {
            get { return _area; }
            set
            {
                _area = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateAreaCommand { get; }

        public RectaguloViewModels()
        {
            CalculateAreaCommand = new Command(CalculateArea, ValidateInput);
        }

        private void CalculateArea()
        {
            Area = Base * Height;
        }

        private bool ValidateInput()
        {
            return Base > 0 && Height > 0;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

    

