using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp___Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new PhotoProcess();
            var filters = new Filters();
            PhotoProcess.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyes;

            photo.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
