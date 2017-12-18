using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp___Delegates
{
    class Filters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Done bright.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Done contrast.");
        }
        public void Resize(Photo photo)
        {

            Console.WriteLine("Done size.");
        }
    }
}
