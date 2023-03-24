using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreScanner;

namespace ZebraScannerConsoleApp
{
    class Program
    {
        static CCoreScannerClass cCoreScannerClass;
        static void Main(string[] args)
        {
            cCoreScannerClass = new CoreScanner.CCoreScannerClass();

            //Call Open API
            short[] scannerTypes = new short[1]; // Scanner Types you are interested in
            scannerTypes[0] = 1; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);
            if (status == 0)
            {
                Console.WriteLine("CoreScanner API: Open Successful");
            }
            else
            {
                Console.WriteLine("CoreScanner API: Open Failed");
            }
        }
    }
}
