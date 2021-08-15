using DealDouble.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDouble.ViewModels
{
    public class AuctionListingViewModel : PageViewModel
    {
        public List<Auction> Auction { get; set; }
    }

    public class AuctionViewModel : PageViewModel
    {
        public List<Auction> AllAuction { get; set; }

        public List<Auction> PromotedAuction { get; set; }
    }
}