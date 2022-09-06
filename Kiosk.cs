using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Kiosker
{
    public interface Kiosk
    {
        string PartialsDirectoryPath { get; set; }
        string OutputDirectoryPath { get; set; }

        void Generate();

    }
}