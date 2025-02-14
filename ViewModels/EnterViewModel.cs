using specek_test_task.Commands;
using specek_test_task.Events;
using specek_test_task.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace specek_test_task.ViewModels
{
    internal class EnterViewModel:ViewModelBase
    {
        private string _enterData;
        public EnterViewModel()
        {
            
        }
        public string EnterData
        {
            get => _enterData;
            set
            {
                _enterData = value;
                OnPropertyChanged();
            }
        }
        public event EventHandler<SetDataEventArgs> SetData;
        public virtual void OnSetData(object sender, SetDataEventArgs args)
        {
            SetData?.Invoke(sender, args);
        }
        public ICommand SetDataCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (String.IsNullOrEmpty(_enterData))
                        throw new NullDataException();
                    OnSetData(this,new SetDataEventArgs(_enterData));
                });
            }
        }
    }
}
