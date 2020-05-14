using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class Sub : IPlugin
    {
        public string PluginName { get; } = "Subtraction";

        public string Version { get; } = "v1.0";

        public Image Image { get; } = new Bitmap(100, 100);

        public string Description { get; } = "Вычитание второго числа из первого числа";

        public int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
