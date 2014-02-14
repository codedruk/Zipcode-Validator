using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace zippy
{
    public abstract class ZipCodeValidator
    {
        public string pattern = null;
        public abstract void init();

        public virtual void IsZipCode(List<string> UserZipList)
        {
            Console.WriteLine("Invalid Zip Codes!");
            foreach(string zipCode in UserZipList.Where(zipCode => !Regex.IsMatch(zipCode, pattern)))
            {
                Console.WriteLine(zipCode);
            }

        }
    }
}
