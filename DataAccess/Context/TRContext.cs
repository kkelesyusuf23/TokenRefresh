using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TRContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public TRContext(DbContextOptions<TRContext> options) : base(options)
        {
        }

        // OnConfiguring metodunu kaldırıyoruz, çünkü DI ile ayarlayacağız
    }

}
