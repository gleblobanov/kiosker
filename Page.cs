using System;

namespace Kiosker
{
    class Page
    {

        public string Name { get; private set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string DayBirth { get; set; }
        public string DayDeath { get; set; }

        public bool Back { get; set; }
        public string Text
        {
            get
            {
                return System.IO.File.ReadAllText(@"C:\Workshop\Kiosker\partials\researchersKiosk\" + Name + ".mustache");
            }
        }

        public string TextDetails
        {
            get
            {
                var path = @"C:\Workshop\Kiosker\partials\researchersKiosk\" + Name + "_details" + ".mustache";
                if (System.IO.File.Exists(path))
                {
                    return System.IO.File.ReadAllText(path);
                }
                else
                {
                    return "";
                }
                
            }
        }

        public string Photo
        {
            get
            {
                return @"./photos/" + Name + ".jpg";
            }
        }
        
        public Func<dynamic,object> BackUrl { get; set; }

        public Partial Partial { get; set; }

        public Page(string name)
        {
            Name = name;
        }

        
        public static string GeneratePageSource(Page page, Template template)
        {
            var data = new
            {
                DayBirth = page.DayBirth,
                DayDeath = page.DayDeath,
                Title = page.Title,
                Back  = page.Back,
                BackUrl  = page.BackUrl,
                Text = page.Text,
                TextDetails = page.TextDetails,
                Photo = page.Photo
            };

            template.Partials["content"] = page.Partial;
            string mainTemplateSource = "";
            try
            {
                mainTemplateSource = template.Partials["main"]?.Source ?? "The \"main\" template is empty";
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return template.RenderTemplate(mainTemplateSource, data);
        }
    }       
}
