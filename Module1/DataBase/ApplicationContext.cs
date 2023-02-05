using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module1.Models;

namespace Module1.DataBase
{
    public class ApplicationContext:DbContext
    {
        // коллекция лифтовых шахт
        public DbSet<ElevatorShaft> ElevatorShafts { get; set; }

        // метод создания файла базы данных с данными ElevatorShaft
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=elevatorshaftapp.db");
        }

    }
}
