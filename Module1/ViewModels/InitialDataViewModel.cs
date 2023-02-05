using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using Module1.DataBase;
using Module1.Infrastructure.Commands;
using Module1.Models;
using Module1.ViewModels.Base;
using Module1.Views.Window;

namespace Module1.ViewModels
{
   public class InitialDataViewModel: ViewModel
   {
       private ApplicationContext db = new ApplicationContext();
       public ObservableCollection<ElevatorShaft> ElevatorShafts { get; set; }

       public InitialDataViewModel()
       {
           db.Database.EnsureCreated();
           db.ElevatorShafts.Load();
           ElevatorShafts = db.ElevatorShafts.Local.ToObservableCollection();

           StartTableFloorWindow=new LambdaCommand(OnStarTableFloorWindow, CanStarTableFloorWindow);

       }


       public ICommand StartTableFloorWindow { get; }

        private void OnStarTableFloorWindow(object p)
        {
            TableFloorWindow tableFloorWindow = new TableFloorWindow(new ElevatorShaft());
            if (tableFloorWindow.ShowDialog() == true)
            {
                ElevatorShaft elevatorShaft = tableFloorWindow.ElevatorShaft;
                db.ElevatorShafts.Add(elevatorShaft);
                db.SaveChanges();
            }


        }

        private bool CanStarTableFloorWindow(object p)
        {
            return true;
        }

    }
}
