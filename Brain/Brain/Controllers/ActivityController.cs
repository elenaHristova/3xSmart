using Brain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Brain.Controllers
{

    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult AddActivity()
        {
            Category currentCategory = new Category("root", null);
            int nestedDepth = 0;

            using (StreamReader sr = new StreamReader(Server.MapPath(@"~/App_Data/Categories.xml")))
            {
                using (XmlReader reader = XmlReader.Create(sr))
                {
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    while (reader.NodeType != XmlNodeType.EndElement || reader.Name != "Categories")
                    {
                        if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Category")
                        {
                            nestedDepth--;
                            currentCategory = currentCategory.ParentElement;
                        }

                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Category")
                        {
                            nestedDepth++;

                            Category category = new Category(reader.GetAttribute("Name"), currentCategory);
                            currentCategory.AddElement(category);
                            currentCategory = category;
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Topic")
                        {
                            reader.Read();
                            if (reader.NodeType == XmlNodeType.Text)
                            {
                                Topic topic = new Topic(reader.Value);
                                currentCategory.AddElement(topic);
                            }
                        }

                        reader.Read();
                    }
                }
            }


            return View(currentCategory.Elements);
        }
    }
}