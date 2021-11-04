using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mahulet_Andreea_Lab5.Models
{
    public class ExpenseContext : DbContext
    {

        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }


    }
}
