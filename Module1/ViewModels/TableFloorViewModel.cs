using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Module1.DataBase;
using Module1.Models;
using Module1.ViewModels.Base;

namespace Module1.ViewModels
{
    public class TableFloorViewModel: ViewModel
    {
        private ApplicationContext db = new ApplicationContext();
        public ObservableCollection<ElevatorShaft> ElevatorShafts { get; set; }

        public TableFloorViewModel()
        {
            db.Database.EnsureCreated();
            db.ElevatorShafts.Load();
            ElevatorShafts = db.ElevatorShafts.Local.ToObservableCollection();
        }

    }
}
