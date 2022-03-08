using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list.Models
{
    internal class ApplicationDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source =C:\Users\Glavi\source\repos\to-do-list\DB\ToDoListDB.db");
        }

        public DbSet<Task> Tasks { get; set;}
    }
}
