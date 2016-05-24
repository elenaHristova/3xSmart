using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
    public class Category : CategoryElement
    {
        public Category ParentElement { get; private set; }
        public List<CategoryElement> Elements { get; set; }

        public Category(string title, Category parent) : base(title)
        {
            Elements = new List<CategoryElement>();
            ParentElement = parent;
        }


        public void AddElement(CategoryElement element)
        {
            Elements.Add(element);
        }
    }
}