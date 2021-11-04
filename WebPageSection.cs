using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratingPage
{
	class WebPageSection
	{
        public WebPageSectionType WebPageSectionType { get; set; }
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Title { get; set; } 
        public string FontStyle { get; set; }
        public string FontSize { get; set; }
        public string FontColor { get; set; }
        public string BackgroundColor { get; set; }
        public string Text { get; set; }
        public List<string> Images { get; set; }
       
    }
}
