using DealDouble.Database;
using DealDouble.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
    public class AuctionService
    {
        public void SaveAuction(Auction auction)
        {
            using (DealDoubleContext db = new DealDoubleContext())
            {
                db.Auctions.Add(auction);
                db.SaveChanges();
            }
            
        }
        public void UpdateAuction(Auction auction)
        {
            using (DealDoubleContext db = new DealDoubleContext())
            {
                db.Entry(auction).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void DeleteAuction(Auction auction)
        {
            using (DealDoubleContext db = new DealDoubleContext())
            {
                db.Entry(auction).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }

        }
        public List<Auction> GetAllAuction()
        {
            using (DealDoubleContext db = new DealDoubleContext())
            {
                return db.Auctions.ToList();
            }

        }
        public Auction GetAuctionById(int ID)
        {
            using (DealDoubleContext db = new DealDoubleContext())
            {
                return db.Auctions.Find(ID);
            }

        }
    }
}
