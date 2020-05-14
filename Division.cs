using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ds.test.impl
{
    class Division : IPlugin
    {
        public string PluginName { get; } = "Division";

        public string Version { get; } = "v1.0";

        public Image Image { get; } = new Bitmap(100, 100);

        public string Description { get; } = "Деление первого числа на второе";

        public int Run(int input1, int input2)
        {
            if (input2 == 0) throw new DivideByZeroException();
            else return input1 / input2;
        }
    }
}
