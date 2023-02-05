using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Module1.Models;

namespace Module1.Views.Window
{
    /// <summary>
    /// Логика взаимодействия для TableFloorWindow.xaml
    /// </summary>
    public partial class TableFloorWindow : System.Windows.Window
    {
        public ElevatorShaft ElevatorShaft { get; private set; }


        public TableFloorWindow(ElevatorShaft elevatorShaft)
        {
            InitializeComponent();
            ElevatorShaft = elevatorShaft;
            DataContext = ElevatorShaft;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
