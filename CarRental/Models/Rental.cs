using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Rental
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("BookingID")]
        public string BookingId { get; set; }

        [BsonElement("SSN")]
        public string CustomerSSN { get; set; }

        [BsonElement("Type")]
        public string CarType { get; set; }

        [BsonElement("RegistrationNumber")]
        public string RegistrationNumber { get; set; }

        [BsonElement("BookingDate")]
        public DateTime BookingDate { get; set; }

        [BsonElement("TravelledDistance")]
        public int TravelledDistance { get; set; }
    }
}
