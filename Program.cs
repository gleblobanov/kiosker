using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace Kiosker
{
    class Program
    {
        static void Main(string[] args)
        {
            var balticKiosk = new BalticKiosk();
            balticKiosk.PartialsDirectoryPath = @"C:\Workshop\kiosker\partials\balticKiosk";
            balticKiosk.OutputDirectoryPath = @"C:\Workshop\kiosker\output\balticKiosk";

            var researchersKiosk = new ResearchersKiosk();
            researchersKiosk.PartialsDirectoryPath = @"C:\Workshop\kiosker\partials\researchersKiosk";    
            researchersKiosk.OutputDirectoryPath = @"C:\Workshop\kiosker\output\researchersKiosk";

            Kiosk [] kiosks = { researchersKiosk/* , balticKiosk */ };
            foreach (var k in kiosks)
            {
                k.Generate();
            }
        }
    }
}
