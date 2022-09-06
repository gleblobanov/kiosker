using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Stubble.Core.Builders;
using Stubble.Core.Settings;


namespace Kiosker
{
    public class Template
    {

        private readonly RenderSettings renderSettings;
        public Dictionary<string, Partial> Partials { get; set; } 

        public Template()
        {
            renderSettings = new RenderSettings() { SkipHtmlEncoding = true };
        }


        public string RenderTemplate(string templateSource, object data)
        {
            var stubble = new StubbleBuilder().Build();
            var partials = Partials.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Source);
            return stubble.Render(templateSource, data, partials, renderSettings);
        }

    }
    
}