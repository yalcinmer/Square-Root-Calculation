using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_ICommand2.Models
{
    public class SqrtModel
    {
        public double Number { get; set; }
        public double Result { get; private set; }

        public void Sqrt()
        {
            Result = Math.Sqrt(Number);
        }

    }
}
