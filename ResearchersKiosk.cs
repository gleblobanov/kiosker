using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Kiosker
{
    public class ResearchersKiosk : Kiosk
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
                {"header", new Partial("header")},
                {"researcher", new Partial("researcher")},
                {"researchers", new Partial("researchers")},
                {"table", new Partial("table")},
                {"researcher_details", new Partial("researcher_details")}       
            };

            var pages = new Page[]
            {
                new Page("index")
                {
                        Partial = template.Partials["index"],
                        Back = false
                },

                new Page("table")
                {
                        Partial = template.Partials["table"],
                        Title = "Рейсы &laquo;НИС Витязь&raquo;, 1949&ndash;1979 гг.",
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },

                new Page("researchers")
                {
                        Partial = template.Partials["researchers"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },

                new Page("bruevich")
                {
                        Title = "Семен Владимирович Бруевич",
                        DayBirth = "1894",
                        DayDeath = "1971",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("bruevich_details")
                {
                        Title = "Семен Владимирович Бруевич",
                        DayBirth = "1894",
                        DayDeath = "1971",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "bruevich.html"; })
                },

                new Page("aksenov")
                {
                        Title = "Андрей Аркадьевич Аксенов",
                        DayBirth = "1916",
                        DayDeath = "1999",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("aksenov_details")
                {
                        Title = "Андрей Аркадьевич Аксенов",
                        DayBirth = "1916",
                        DayDeath = "1999",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "aksenov.html"; })
                },

                new Page("alekseev")
                {
                        Title = "А. А. Алексеев",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("alekseev_details")
                {
                        Title = "А. А. Алексеев",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "alekseev.html"; })
                },
                
                new Page("bezrukov")
                {
                        Title = "Пантелеймон Леонидович Безруков",
                        DayBirth = "1909",
                        DayDeath = "1981",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("bezrukov_details")
                {
                        Title = "Пантелеймон Леонидович Безруков",
                        DayBirth = "1909",
                        DayDeath = "1981",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "bezrukov.html"; })
                },
                
                new Page("bogorov")
                {
                        Title = "Вениамин Григорьевич Богоров",
                        DayBirth = "1904",
                        DayDeath = "1971",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("bogorov_details")
                {
                        Title = "Вениамин Григорьевич Богоров",
                        DayBirth = "1904",
                        DayDeath = "1971",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "bogorov.html"; })
                },
                
                new Page("dobrovolsky")
                {
                        Title = "Алексей Дмитриевич Добровольский",
                        DayBirth = "1907",
                        DayDeath = "1991",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("dobrovolsky_details")
                {
                        Title = "Алексей Дмитриевич Добровольский",
                        DayBirth = "1907",
                        DayDeath = "1991",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "dobrovolsky.html"; })
                },
                
                new Page("dubinin")
                {
                        Title = "А. И. Дубинин",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("dubinin_details")
                {
                        Title = "А. И. Дубинин",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "dubinin.html"; })
                },
                
                new Page("filatova")
                {
                        Title = "Зинаида Алексеевна Филатова",
                        DayBirth = "1905",
                        DayDeath = "1984",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("filatova_details")
                {
                        Title = "Зинаида Алексеевна Филатова",
                        DayBirth = "1905",
                        DayDeath = "1984",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "filatova.html"; })
                },
                
                new Page("fomin")
                {
                        Title = "Л. М. Фомин",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("fomin_details")
                {
                        Title = "Л. М. Фомин",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "fomin.html"; })
                },
                
                new Page("ivanovfranzkevich")
                {
                        Title = "Георгий Николаевич Иванов-Францкевич",
                        DayBirth = "1907",
                        DayDeath = "1986",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("ivanovfranzkevich_details")
                {
                        Title = "Георгий Николаевич Иванов-Францкевич",
                        DayBirth = "1907",
                        DayDeath = "1986",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "ivanovfranzkevich.html"; })
                },
                
                new Page("kort")
                {
                        Title = "Владимир Григорьевич Корт",
                        DayBirth = "1913",
                        DayDeath = "1994",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("kort_details")
                {
                        Title = "Владимир Григорьевич Корт",
                        DayBirth = "1913",
                        DayDeath = "1994",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "kort.html"; })
                },
                
                new Page("kovilin")
                {
                        Title = "В. М. Ковылин",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("kovilin_details")
                {
                        Title = "В. М. Ковылин",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "kovilin.html"; })
                },
                
                new Page("minaev")
                {
                        Title = "А. И. Минаев",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("minaev_details")
                {
                        Title = "А. И. Минаев",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "minaev.html"; })
                },
                
                new Page("neprochnov")
                {
                        Title = "Юрий Павлович Непрочнов",
                        DayBirth = "1939",
                        DayDeath = "2010",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("neprochnov_details")
                {
                        Title = "Юрий Павлович Непрочнов",
                        DayBirth = "1939",
                        DayDeath = "2010",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "neprochnov.html"; })
                },
                
                new Page("ostroumov")
                {
                        Title = "Эспер Александрович Остроумов",
                        DayBirth = "1909",
                        DayDeath = "1990",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("ostroumov_details")
                {
                        Title = "Эспер Александрович Остроумов",
                        DayBirth = "1909",
                        DayDeath = "1990",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "ostroumov.html"; })
                },
                
                new Page("ovchinnikov")
                {
                        Title = "Иван Михайлович Овчинников",
                        DayBirth = "1931",
                        DayDeath = "2000",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("ovchinnikov_details")
                {
                        Title = "Иван Михайлович Овчинников",
                        DayBirth = "1931",
                        DayDeath = "2000",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "ovchinnikov.html"; })
                },
                
                new Page("parin")
                {
                        Title = "Николай Васильевич Парин",
                        DayBirth = "1932",
                        DayDeath = "2012",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("parin_details")
                {
                        Title = "Николай Васильевич Парин",
                        DayBirth = "1932",
                        DayDeath = "2012",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "parin.html"; })
                },
                
                new Page("pasternak")
                {
                        Title = "Ф. А. Пастернак",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("pasternak_details")
                {
                        Title = "Ф. А. Пастернак",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "pasternak.html"; })
                },
                
                new Page("petelin")
                {
                        Title = "Вениамин Петрович Петелин",
                        DayBirth = "1912",
                        DayDeath = "1970",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("petelin_details")
                {
                        Title = "Вениамин Петрович Петелин",
                        DayBirth = "1912",
                        DayDeath = "1970",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "petelin.html"; })
                },
                
                new Page("ponomarenko")
                {
                        Title = "Георгий Петрович Пономаренко",
                        DayBirth = "1903",
                        DayDeath = "1984",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("ponomarenko_details")
                {
                        Title = "Георгий Петрович Пономаренко",
                        DayBirth = "1903",
                        DayDeath = "1984",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "ponomarenko.html"; })
                },
                
                new Page("shirey")
                {
                        Title = "В. А. Ширей",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("shirey_details")
                {
                        Title = "В. А. Ширей",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "shirey.html"; })
                },
                
                new Page("sisoev")
                {
                        Title = "Николай Николаевич Сысоев",
                        DayBirth = "1909",
                        DayDeath = "1964",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("sisoev_details")
                {
                        Title = "Николай Николаевич Сысоев",
                        DayBirth = "1909",
                        DayDeath = "1964",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "sisoev.html"; })
                },
                
                new Page("udintsev")
                {
                        Title = "Глеб Борисович Удинцев",
                        DayBirth = "1923",
                        DayDeath = "2017",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("udintsev_details")
                {
                        Title = "Глеб Борисович Удинцев",
                        DayBirth = "1923",
                        DayDeath = "2017",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "udintsev.html"; })
                },
                
                new Page("vasilevsky")
                {
                        Title = "Н. П. Василевский",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("vasilevsky_details")
                {
                        Title = "Н. П. Василевский",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "vasilevsky.html"; })
                },
                
                new Page("vinogradov")
                {
                        Title = "Михаил Евгеньевич Виноградов",
                        DayBirth = "1927",
                        DayDeath = "2007",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("vinogradov_details")
                {
                        Title = "Михаил Евгеньевич Виноградов",
                        DayBirth = "1927",
                        DayDeath = "2007",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "vinogradov.html"; })
                },
                
                new Page("voytov")
                {
                        Title = "В. И. Войтов",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("voytov_details")
                {
                        Title = "В. И. Войтов",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "voytov.html"; })
                },
                
                new Page("yushak")
                {
                        Title = "А. А. Ющак",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("yushak_details")
                {
                        Title = "А. А. Ющак",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "yushak.html"; })
                },
                
                new Page("zenkevich")
                {
                        Title = "Лев Александрович Зенкевич",
                        DayBirth = "1889",
                        DayDeath = "1970",
                        Partial = template.Partials["researcher"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "index.html"; })
                },
                new Page("zenkevich_details")
                {
                        Title = "Лев Александрович Зенкевич",
                        DayBirth = "1889",
                        DayDeath = "1970",
                        Partial = template.Partials["researcher_details"],
                        Back = true,
                        BackUrl = new Func<dynamic, object>((_) => { return "zenkevich.html"; })
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