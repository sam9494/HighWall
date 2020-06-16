using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HighWall.DB.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<MerchantPaymentUnit> MerchantPaymentUnits { get; set; }
    }

    public class MerchantPaymentUnit
    {
        public int Id { get; set; }
        public string PaymentUnitCode { get; set; }
        public string MerchantCode { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
