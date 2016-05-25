using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
    public abstract class CategoryElement
    {
        public string Title { get; private set; }

        public CategoryElement(string title)
        {
            Title = title;
        }

        public static string GetHtmlListString(IEnumerable<CategoryElement> elements)
        {
            string output = ReadElement(elements);
            return output;
        }

        private static string ReadElement(IEnumerable<CategoryElement> elements)
        {
            string output = "";
            foreach (CategoryElement element in elements)
            {
                output += "<li>";

                if (element is Category)
                {
                    output += element.Title;
                    output += "<ul>";
                    output += ReadElement(((Category)element).Elements);
                    output += "</ul>";
                }
                else if (element is Topic)
                {
                    output += element.Title;
                }

                output += "</li>";
            }

            return output;
        }
    }
}