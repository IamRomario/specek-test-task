using specek_test_task.Commands;
using specek_test_task.Exceptions;
using specek_test_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace specek_test_task.ViewModels
{
    internal class SomeViewModel: ViewModelBase
    {
        private string _data;
        private bool _isActive = false;
        public SomeViewModel() { 
        }
        public string Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }
        public ICommand GetDataCommand
        {
            get => new RelayCommand(async (obj) =>
            {
                if (!_isActive)
                {
                    _isActive = true;
                    var ds = new SomeSource();
                    Data = await ds.GetData() ?? Data;
                    _isActive = false;
                }
            });
        }

    }
}
