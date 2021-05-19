using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingFactory
    {
        public static ASort Create(string s)
        {
            try
            {
                var type = Type.GetType($"SortingApplication.{s}");
                ASort o = (ASort)Activator.CreateInstance(type);
                return o;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
