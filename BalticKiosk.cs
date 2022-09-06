using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Kiosker
{
    public class BalticKiosk : Kiosk
    {
        public string PartialsDirectoryPath { get; set; }
        public string OutputDirectoryPath { get; set; }

        public void Generate()
        {

            Template template = new Template();
            Partial.PartialsDirectoryPath = PartialsDirectoryPath;
            template.Partials = new Dictionary<string, Partial>()
            {
                {"main", new Partial("main")},
                {"index", new Partial("index")},
                {"1", new Partial("1")},
                {"1_1", new Partial("1_1")},
                {"1_2", new Partial("1_2")},
                {"2", new Partial("2")},
                {"3", new Partial("3")},
                {"4", new Partial("4")},
                {"header", new Partial("header")}
            };

            var pages = new Page[]
            {
                new Page("index")
                {
                        Title = "Море, рожденное ледником",
                        Partial = template.Partials["index"],
                        Back = false
                },
                new Page("1")
                {
                        Title = "История развития моря",
                        Partial = template.Partials["1"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("1_1")
                {
                        Title = "Мультфильм &laquo;Море, рожденное ледником&raquo;",
                        Partial = template.Partials["1_1"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "1.html"; })
                },
                new Page("1_2")
                {
                        Title = "Хочу знать больше!",
                        Partial = template.Partials["1_2"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "1.html"; })
                },
                new Page("2")
                {
                        Title = "Такие разные берега",
                        Partial = template.Partials["2"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("3")
                {
                        Title = "Это интересно!",
                        Partial = template.Partials["3"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("4")
                {
                        Title = "Кто изучает?",
                        Partial = template.Partials["4"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                }
            };

            foreach(var page in pages)
            {
                page.Source = Page.GeneratePageSource(page, template);

                string path = Path.Combine(OutputDirectoryPath, page.Name + ".html");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(page.Source);
                }
            }
        }

    }
}