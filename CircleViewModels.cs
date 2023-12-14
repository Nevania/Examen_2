using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace ExamenProga_2.ViewModels
{
    internal class CircleViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
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

        public CircleViewModels()
        {
            CalculateAreaCommand = new Command(CalculateArea, ValidateInput);
        }

        private void CalculateArea()
        {
            Area = Math.PI * Radius * Radius;
        }

        private bool ValidateInput()
        {
            return Radius > 0;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

    

