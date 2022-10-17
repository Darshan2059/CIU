using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CIU.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIU.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CIUContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CIUContext>>()))
            {
                if (context.Soap.Any())
                {
                    return;
                }

                context.Soap.AddRange(
                    new Soap
                    {
                        Title = "CIU Hand Soap",
                        ReleaseDate= DateTime.Parse("2022-06-20"),
                        LotteryTicket = "2 per Pack",
                        Membership_Discount ="Yes",
                        Normal_Price = 4.99M,
                        Members_Price = 3.99M  ,
                        Rating = 4M
                        },
 new Soap
                    {
                        Title = "CIU Toilet Soaps",
                        ReleaseDate= DateTime.Parse("2000-1-1"),
                        LotteryTicket = "2 per Pack",
                        Membership_Discount ="Yes",
                        Normal_Price = 4.99M,
                        Members_Price = 3.99M  ,
                        Rating = 3.8M
                        },
  new Soap
  {
      Title = "CIU Laundary Soaps",
      ReleaseDate = DateTime.Parse("2001-05-23"),
      LotteryTicket = "1 per Pack",
      Membership_Discount = "Yes",
      Normal_Price = 6.99M,
      Members_Price = 5.99M,
      Rating = 3.7M
  },
   new Soap
   {
       Title = "CIU Body Soap VIP",
       ReleaseDate = DateTime.Parse("2021-09-02"),
       LotteryTicket = "5 per Pack",
       Membership_Discount = "No",
       Normal_Price = 20.99M,
       Members_Price = 20.99M,
       Rating = 4.65M
   },
    new Soap
    {
        Title = "CIU Toilet Cleaner",
        ReleaseDate = DateTime.Parse("2021-04-12"),
        LotteryTicket = "2 per Pack",
        Membership_Discount = "Yes",
        Normal_Price = 20.99M,
        Members_Price = 19.99M,
        Rating = 3.68M
    },
     new Soap
     {
         Title = "CIU WindShield Cleaner",
         ReleaseDate = DateTime.Parse("1999-06-23"),
         LotteryTicket = "3 per Pack",
         Membership_Discount = "Yes",
         Normal_Price = 20.99M,
         Members_Price = 16.99M,
         Rating = 3.4M
     },
      new Soap
      {
          Title = "CIU Baby Soap",
          ReleaseDate = DateTime.Parse("2021-02-22"),
          LotteryTicket = "2 per Pack",
          Membership_Discount = "Yes",
          Normal_Price = 2.99M,
          Members_Price = 1.99M,
          Rating = 4M
      },
       new Soap
       {
           Title = "CIU Baby Soap",
           ReleaseDate = DateTime.Parse("2004-12-23"),
           LotteryTicket = "5 per Pack",
           Membership_Discount = "Yes",
           Normal_Price = 26.99M,
           Members_Price = 21.99M,
           Rating = 4M
       },
        new Soap
        {
            Title = "CIU Hair Soap",
            ReleaseDate = DateTime.Parse("2008-04-04"),
            LotteryTicket = "4 per Pack",
            Membership_Discount = "Yes",
            Normal_Price = 20.99M,
            Members_Price = 18.99M,
            Rating = 4.8M

        },
         new Soap
         {
             Title = "CIU Dog soap",
             ReleaseDate = DateTime.Parse("2005-05-05"),
             LotteryTicket = "Yes",
             Membership_Discount = "No",
             Normal_Price = 30.99M,
             Members_Price = 30.99M,
             Rating = 4M
         }
                );
                context.SaveChanges();
            }
        }
    }
}
