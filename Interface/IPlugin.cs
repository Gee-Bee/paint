using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPlugin
    {
        Bitmap processImage(Bitmap bmp);
    }
}
