/* Name: Zigmyal Wangchuk
 * Class: CSI 335
 * Assignment: Zip Validator
 * Due Date: 02/13/2014
 * Purpose: Allows the user to enter a Zipcode and writes it to a file depending on the Zipcode entered [US/CANADA/UK]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zippy
{
    class Program
    {
        static void Main(string[] args)
        { 
            ZipCodeValidator Validation;
            List<string> holdZip = new List<string>();
            string txtZIP = "zipCode.txt";

            string region = System.Globalization.RegionInfo.CurrentRegion.EnglishName;

            ReadingFile toRead = new ReadingFile();
            holdZip = toRead.readFromTextFile(txtZIP);

            if (txtZIP != null)
            {
                switch (region)
                {
                    case "United States":
                        Validation = new USZip();
                        Validation.init();
                        Validation.IsZipCode(holdZip);
                        break;

                    case "United Kingdom":
                        Validation = new UKZip();
                        Validation.init();
                        Validation.IsZipCode(holdZip);
                        break;

                    case "Canada":
                        Validation = new CAZip();
                        Validation.init();
                        Validation.IsZipCode(holdZip);
                        break;
                    default:
                        Console.WriteLine("Country Not Found!");
                        break;
                }
            }
            else
                Console.WriteLine("No Data Found!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
