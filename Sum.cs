using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class Sum : IPlugin
    {
        public string PluginName { get; } = "Sum";

        public string Version { get; } = "v1.0";

        public Image Image { get; } = new Bitmap(100, 100);

        public string Description { get; } = "Сумма двух чисел";

        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
