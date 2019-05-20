using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class RentalService
    {
        private readonly IMongoCollection<Rental> rentals;

        public RentalService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("CarRentalDB"));
            var database = client.GetDatabase("CarRentalDB");
            rentals = database.GetCollection<Rental>("Rentals");
        }

        public List<Rental> Get()
        {
            return rentals.Find(r => true).ToList();
        }

        public Rental Get(string bookingId)
        {
            return rentals.Find(r => r.BookingId == bookingId).FirstOrDefault();
        }

        public Rental Create(Rental rental)
        {
            rentals.InsertOne(rental);
            return rental;
        }

        public void Update(string id, Rental rentalIn)
        {
            rentals.ReplaceOne(rental => rental.BookingId == id, rentalIn);
        }

        public void Remove(Rental rentalIn)
        {
            rentals.DeleteOne(rental => rental.BookingId == rentalIn.BookingId);
        }

        public void Remove(string id)
        {
            rentals.DeleteOne(rental => rental.BookingId == id);
        }
    }
}
