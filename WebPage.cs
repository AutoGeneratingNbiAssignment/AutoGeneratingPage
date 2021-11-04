

namespace AutoGeneratingPage
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    internal class WebPage
    {
        public List<WebPageSection> Sections { get; set; }
        public WebPage()
        {
            Sections = new();
            Sections.AddRange(
                new WebPageSection[]
                {
                    new WebPageSection{WebPageSectionType=WebPageSectionType.Main, Name="Landing page"},
                    new WebPageSection{WebPageSectionType=WebPageSectionType.Footer, Name="Footer"},
                    new WebPageSection{WebPageSectionType=WebPageSectionType.NotDefined, Name="Section1"},
                    new WebPageSection{WebPageSectionType=WebPageSectionType.NotDefined, Name="Section2"},
                    new WebPageSection{WebPageSectionType=WebPageSectionType.NotDefined, Name="Section3"},
                });
        }

        internal void Generate(string filePath)
        {
            var html = new StringBuilder();
            var css = new StringBuilder();
            html.AppendLine("<html lang=\"sv\">");
            foreach (var item in Sections)
            {
                switch (item.WebPageSectionType)
                {
                    case WebPageSectionType.Main:
                        html.AppendLine("<head>");
                        html.AppendLine("<title>" + item.Name + "</title>");
                        html.AppendLine("<meta charset=\"utf-8\"/>");
                        html.AppendLine("</head>");
                        html.AppendLine("<body>");
                        break;
                    case WebPageSectionType.Footer:
                        html.AppendLine("<footer>");
                        html.AppendLine(item.Text);
                        html.AppendLine("</footer>");
                        break;
                    case WebPageSectionType.NotDefined:
                        html.AppendLine("<p>");
                        html.AppendLine(item.Text);
                        html.AppendLine("</p>");
                        break;
                    case WebPageSectionType.ScrollingBanner:
                        break;
                    case WebPageSectionType.CallToAction:
                        break;
                    case WebPageSectionType.Text:
                        break;
                    case WebPageSectionType.TextWithImageRight:
                        break;
                    case WebPageSectionType.TextWithImageLeft:
                        break;
                    case WebPageSectionType.TextAndButton:
                        break;
                    case WebPageSectionType.ContactForm:
                        break;
                    default:
                        break;
                }
            }
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            var htmlFile = SaveHTMLFile(filePath, html);
            SaveCSSFile(filePath, css);

            OpenWebpage(htmlFile);

        }

        private static void SaveCSSFile(string filePath, StringBuilder css)
        {
            var cssFile = Path.Combine(filePath, "style.css");
            File.WriteAllText(cssFile, css.ToString());
        }

        private static string SaveHTMLFile(string filePath, StringBuilder html)
        {
            var htmlFile = Path.Combine(filePath, "index.html");
            File.WriteAllText(htmlFile, html.ToString());
            return htmlFile;
        }

        private static void OpenWebpage(string htmlFile)
        {
            // Snatched from https://stackoverflow.com/a/4580317
            Process myProcess = new Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = htmlFile;
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
