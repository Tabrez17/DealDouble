using DealDouble.Services;
using DealDouble.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Controllers
{
    public class HomeController : Controller
    {

        AuctionService service = new AuctionService();
        public ActionResult Index()
        {
            AuctionViewModel vmodel = new AuctionViewModel();

            vmodel.PageTitle = "Home Page";
            vmodel.PageDescription = "This is Home Page";

            vmodel.AllAuction  = service.GetAllAuction();

            vmodel.PromotedAuction = service.GetPromotedAuction();

            return View(vmodel);
        }
    }
}