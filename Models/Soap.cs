using System;
using System.ComponentModel.DataAnnotations;

namespace CIU.Models
{
    public class Soap
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string LotteryTicket { get; set; }
        public string Membership_Discount { get; set; }
        public decimal Normal_Price { get; set; }
        public decimal Members_Price { get; set; }
        public decimal Rating { get; set; }


    }
}
