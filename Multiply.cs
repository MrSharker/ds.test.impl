using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ds.test.impl
{
    class Multiply : IPlugin
    {
        public string PluginName { get; } = "Multiply";

        public string Version { get; } = "v1.0";

        public Image Image { get; } = new Bitmap(100, 100);

        public string Description { get; } = "Перемножение двух чисел";

        public int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
