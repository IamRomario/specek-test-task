using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specek_test_task.Events
{
    internal class SetDataEventArgs: EventArgs
    {
        private readonly string _data;
        public SetDataEventArgs(string data)
        {
            _data = data;
        }
        public string Data { get { return _data; } }
    }
}
