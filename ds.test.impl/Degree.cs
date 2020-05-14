using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class Degree : IPlugin
    {
        public string PluginName { get; } = "Degree";

        public string Version { get; } = "v1.0";

        public Image Image { get; } = new Bitmap(100, 100);

        public string Description { get; } = "Возведение первого числа в степень второго числа";

        public int Run(int input1, int input2)
        {
            if (input2 == 0) return 1;
            else if (input2 == 1) return input1;
            else return input1 * Run(input1, input2 - 1);
        }
    }
}
