﻿using DealDouble.Entity;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        AuctionService service = new AuctionService();
        // GET: Auctions
        [HttpGet]
        public ActionResult Index()
        {
            var auctions = service.GetAllAuction();
            if (Request.IsAjaxRequest())
            {
                return PartialView(auctions);
            }
            else
            {
                return View(auctions);
            }
           
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            service.SaveAuction(auction);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var auction = service.GetAuctionById(ID);
            return PartialView(auction);
        }
        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            service.UpdateAuction(auction);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var auction = service.GetAuctionById(ID);
            return View(auction);
        }
        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            service.DeleteAuction(auction);
            return RedirectToAction("Index");
        }
    }
}