using specek_test_task.Events;
using specek_test_task.Exceptions;
using specek_test_task.ViewModels;
using specek_test_task.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace specek_test_task.Models
{
    internal class SomeSource
    {
        public SomeSource()
        {
            
        }
        public async Task<string> GetData()
        {            
            string data = string.Empty;
            var cts = new CancellationTokenSource();

            var datacontext = new EnterViewModel();
            var enterwindow = new EnterView(datacontext);

            datacontext.SetData += (s, e) => {
                enterwindow.Close();
                data = e.Data;
                cts.Cancel();
            };

            enterwindow.Closed += (s, e) => {
                data = null;
                cts.Cancel();
            };

            enterwindow.Show();

            await Task.Factory.StartNew(() => {
                while (!cts.Token.IsCancellationRequested) { }
            });

            return data;
        }
    }
}
