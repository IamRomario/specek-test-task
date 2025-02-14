using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specek_test_task.Exceptions
{
    internal class NullDataException:Exception
    {
        public NullDataException(string message="Получена пустая строка"): base(message)
        {   

        }
    }
}
