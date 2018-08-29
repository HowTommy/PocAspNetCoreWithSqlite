using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GuildHost.Models;
using GuildHost.SQLite;
using System.Linq;

namespace GuildHost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using(var db = new BloggingContext())
            {
                //db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                //db.SaveChanges();

                return View(db.Blogs.ToList());
            }
        }

        public IActionResult Blog(int id)
        {
            using (var db = new BloggingContext())
            {
//                for(int i = 0; i < 5; i++)
//                {
//                    db.Posts.Add(new Post()
//                    {
//                        BlogId = id,
//                        Content = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer porttitor tortor vel ex bibendum, id eleifend ligula fermentum. Suspendisse malesuada tortor a elit lobortis, sit amet pharetra enim venenatis. Cras eu magna diam. Nullam in justo quam. Morbi euismod, lacus ac pulvinar tincidunt, urna nibh congue risus, eu venenatis orci tellus quis nisi. Sed at tincidunt ipsum. Duis dignissim feugiat viverra. Nulla eu velit justo. Praesent iaculis urna elit, mattis aliquet quam mollis vel. Suspendisse eget sem at mi varius posuere ut at lectus. Maecenas a placerat mi, eget venenatis erat.

//Cras id pellentesque neque. Curabitur non sollicitudin elit. Maecenas et enim enim. Fusce feugiat, urna ultricies cursus ultrices, tortor nisi pharetra odio, eget interdum metus nulla lacinia leo. Vivamus bibendum lacus vitae venenatis dictum. Morbi vitae odio tortor. Cras sed porttitor diam. Phasellus accumsan mollis urna a imperdiet. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi pellentesque orci tincidunt, blandit arcu eget, cursus turpis. In fringilla mauris eros, aliquam posuere tellus ultricies a. Ut sed ligula lacinia, sagittis ante nec, lacinia felis.

//Aliquam erat volutpat. Praesent blandit diam eu consequat rhoncus. Maecenas at erat sapien. Phasellus porta dapibus nisl, in fringilla ligula ullamcorper at. Proin molestie tempus elementum. Morbi nec odio volutpat, pellentesque enim sed, tincidunt quam. Interdum et malesuada fames ac ante ipsum primis in faucibus.",
//                        Title = "Post " + i
//                    });
//                }
//                db.SaveChanges();

                return View(db.Posts.Where(p => p.BlogId == id).OrderByDescending(p => p.PostId).ToList());
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
