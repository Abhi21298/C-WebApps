using Booking.Core.Entities;
using Booking.Web.Data;
using Booking.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vonage;
using Vonage.Request;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using Syncfusion.Pdf.Grid;

namespace Booking.Web.Controllers
{
    
    [Authorize]
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly OrderHistory1DbContext _context1;
        private readonly UserManager<IdentityUser> _userManager;
        
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly UserManager<ApplicationUser> _userManager;

        //var username = HttpContext.Current.User.Identity.Name;

        public BookingsController(ApplicationDbContext context,OrderHistory1DbContext context1, UserManager<IdentityUser> userManager) //, IHttpContextAccessor httpContextAccessor
        {
            _context = context;
            //_httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _context1 = context1;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
            
            //ViewBag.cart = cart;
            //ViewBag.total = cart.Sum(x => x.Product.UnitPrice * x.Quantity);
            return View(cart);
        }
        
        public IActionResult OrderHistory()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            IdentityUser user = _userManager.FindByIdAsync(userid).Result;
            if(user.Email.ToString() == "admin@gmail.com")
            {
                var prod = _context1.OrderHistory.OrderByDescending(p=>p.BookingTime);
                return View(prod);
            }
            else
            {
                var prod = _context1.OrderHistory.Where(p => p.UserName == user.Email).OrderByDescending(p => p.BookingTime);
                return View(prod);
            }
            
        }
        public IActionResult pdfConvert(string id)
        {
            var prod = _context1.OrderHistory.Where(p => p.BookingID == id).Select(p => new { p.BookingID, p.UserName, p.BookingTime, p.MovieName, p.Datetime, p.Quantity, p.TotalPrice }) ;
            
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            //Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();
            //Add values to list
            List<object> data = new List<object>();
            var row1 = prod;
            //Object row2 = new { ID = "E02", Name = "Thomas" };
            //Object row3 = new { ID = "E03", Name = "Andrew" };
            //Object row4 = new { ID = "E04", Name = "Paul" };
            //Object row5 = new { ID = "E05", Name = "Gray" };
            foreach(var item in row1)
            {
                data.Add(item);
            }
            

            //Add list to IEnumerable
            IEnumerable<object> dataTable = data;
            //Assign data source.
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document.
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 10));
            //Save the PDF document to stream
            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            //If the position is not set to '0' then the PDF will be empty.
            stream.Position = 0;
            //Close the document.
            doc.Close(true);
            //Defining the ContentType for pdf file.
            string contentType = "application/pdf";
            //Define the file name.
            string fileName = id+".pdf";
            //Creates a FileContentResult object by using the file contents, content type, and file name.
            return File(stream, contentType, fileName);
        }
       

        public IActionResult MovieHistory()
        {
                var prod = _context.Movie;
                return View(prod);
        }

        public IActionResult Confirm()
        {
            var credentials = Credentials.FromApiKeyAndSecret(
                                 "23db0eec",
                                   "vSMAvKil1oWV5GFX"
                                    );

            var VonageClient = new VonageClient(credentials);
            OrderHistory O = new OrderHistory();
            var cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
            if(cart!=null && cart[0].BookingTime < cart[0].Movie.Datetime)
            {
                O.BookingID = cart[0].BookingID;
                O.UserName = cart[0].UserName;
                O.BookingTime = cart[0].BookingTime;
                O.MovieName = cart[0].Movie.MovieName;
                O.ImageFile = cart[0].Movie.ImageFile;
                O.Datetime = cart[0].Movie.Datetime;
                O.Quantity = cart[0].Quantity;
                O.TotalPrice = cart[0].TotalPrice;
                _context1.OrderHistory.Add(O);
                _context1.SaveChanges();
                HttpContext.Session.Remove("cart");

                var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
                {
                    To = "918189901155",
                    From = "Booking.Web",
                    Text = "\nBooking ID:" + O.BookingID.ToString()  + "\nMovie Name:" +  O.MovieName.ToString() + "\nShow:" + O.Datetime.ToString() + "\n Seats:" + O.Quantity + "\n"
                });
                // O.Datetime 
            }

            return RedirectToAction("Index", "Movies");
        }

        private int isExist(int id)
        {
            List<BookingItem> cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
            // var prod = await _context.Product.FirstOrDefault(i => i.Id == id);


            for (int i = 0; i < cart.Count; i++)
            {
                // var prod = _context.Product.Find(id);
                if (cart[i].Movie.Id == id)
                {
                    return i;
                }

            }



            return -1;

        }
        public IActionResult Buy(int id)
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            IdentityUser user = _userManager.FindByIdAsync(userid).Result;
            if (SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart") == null)
            {
                List<BookingItem> cart = new List<BookingItem>();
                var prod = _context.Movie.Find(id);
                BookingItem B = new BookingItem();
                if(prod!=null && prod.SeatsAvailable >= 1)
                {
                    B.Quantity = 1;
                    prod.SeatsAvailable -= 1;
                    _context.Movie.Update(prod);
                    _context.SaveChangesAsync();
                    B.TotalPrice = B.Quantity * 150;
                    B.BookingID = System.Guid.NewGuid().ToString();
                    B.BookingTime = DateTime.Now;
                    B.UserName = user.Email.ToString();
                    B.Movie = prod;
                    cart.Add(B);
                }
                if (prod.Datetime < DateTime.Now)
                {
                    cart.RemoveAt(0);
                    HttpContext.Session.Remove("cart");
                    return RedirectToAction("Index","Movies");
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            else
            {
                List<BookingItem> cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                var prod = _context.Movie.Find(id);
                if (index != -1 && (prod!=null) && prod.SeatsAvailable >= 1)
                {
                    cart[index].Quantity++;
                    cart[index].TotalPrice = cart[index].Quantity * 150;
                    prod.SeatsAvailable -= 1;
                    _context.Movie.Update(prod);
                    _context.SaveChangesAsync();
                   
                }
                 if (prod.Datetime < DateTime.Now)
                {
                    cart.RemoveAt(0);
                    HttpContext.Session.Remove("cart");
                    return RedirectToAction("Index", "Movies");
                }
                else
                {
                    //var prod = _context.Movie.Find(id);
                    //cart.Add(new BookingItem { BookingID = prod.Id, Product = prod, Quantity = 1 });
                }

                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<BookingItem> cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            var prod = _context.Movie.Find(id);
            //if (cart[index].Quantity == 1)
            //{
            prod.SeatsAvailable += cart[index].Quantity;
            _context.Movie.Update(prod);
            _context.SaveChangesAsync();
            cart.RemoveAt(index);

                //return RedirectToAction("Index");
           // }
            //else
            //{
            //    cart[index].Quantity--;
            //}

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index", "Movies");



        }

        public IActionResult RemoveSeat(int id)
        {
            List<BookingItem> cart = SessionHelper.GetObjectFromJson<List<BookingItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            var prod = _context.Movie.Find(id);
            //if (cart[index].Quantity == 1)
            //{
            cart[0].Quantity -= 1;
            cart[0].TotalPrice -= 150;
            prod.SeatsAvailable += 1;
            _context.Movie.Update(prod);
            _context.SaveChangesAsync();
            
            //cart.RemoveAt(index);

            //return RedirectToAction("Index");
            // }
            //else
            //{
            //    cart[index].Quantity--;
            //}

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");



        }

    }
}
