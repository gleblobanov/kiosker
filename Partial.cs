using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Stubble.Core.Builders;
using Stubble.Core.Settings;

namespace Kiosker
{
    public class Partial
    {
        private string name;

        public static string PartialsDirectoryPath { get; set; }

        public string Name
        { 
            get
            {
                return name;
            }
            private set
            {
                name = value;
                var partialPath = Path.Combine(PartialsDirectoryPath, name + ".mustache");

                try
                {
                    using (StreamReader sr = new StreamReader(partialPath, Encoding.UTF8))
                    {
                        Source = sr.ReadToEnd();
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Template's file {partialPath} could not be read.");
                    Console.WriteLine(e.Message);
                }
            }
        }
        public string Source { get; private set; }

        public Partial(string name)
        {
            Name = name;
        }
        
    }
}