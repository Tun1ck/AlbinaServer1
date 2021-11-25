using Albina.DataAccess.Core.Interfaces;
using Albina.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccess.DbContexts
{
    public class AlbinaContext : Microsoft.EntityFrameworkCore.DbContext, IContext
    {
        public AlbinaContext (DbContextOptions<AlbinaContext> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<AcceptExpenseRto> AcceptsExpenses { get; set ; }
        public DbSet<VirtualExpenseRto> VirtualExpenses { get ; set ; }
        public DbSet<RejectExpenseRto> RejectExpenses { get ; set; }
    }
}
