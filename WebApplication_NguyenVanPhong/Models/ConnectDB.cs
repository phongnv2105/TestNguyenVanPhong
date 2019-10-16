using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_NguyenVanPhong.Models
{
    public class ConnectDB: DbContext
    {
        public ConnectDB() : base("name=ConnectDB")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}