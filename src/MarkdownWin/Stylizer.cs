using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace MarkdownWin {
    class Stylizer {
        public static string Run(string html, string cssOverridePath = "") {
            const string htmlTemplate = 
                "<!DOCTYPE html><html><head><meta http-equiv=\"content-type\" content=\"text/html;charset=UTF-8\" /><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\"><style type=\"text/css\">{0}</style></head><body>{1}</body></html>";
            
            string stylesheet;

            if (String.IsNullOrEmpty(cssOverridePath)) {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(Stylizer), "markdown.css"))
                using (var reader = new StreamReader(stream)) {
                    stylesheet = reader.ReadToEnd();
                }
            } else {
                stylesheet = File.ReadAllText(cssOverridePath);
            }

            return string.Format(htmlTemplate, stylesheet, html);
        }
    }
}
