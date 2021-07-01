using CaRRent.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaRRent.PL.Pages
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            CarBrandDTO porsche = new CarBrandDTO() { Name = "Porsche" };
            CarBrandDTO audi = new CarBrandDTO() { Name = "Audi" };

            CarDTO cayenne = new CarDTO() { Id = 1, Model = "Cayenne GTS", Brand = porsche, 
                RentPrice = 1500, IsAvailable = true };
            CarDTO turbo911 = new CarDTO() { Id = 2, Model = "911 Turbo", Brand = porsche, 
                RentPrice = 2200, IsAvailable = false };
            CarDTO rsq8 = new CarDTO() { Id = 3, Model = "RSQ8", Brand = audi, 
                RentPrice = 1300, IsAvailable = true
            };

            carsDataGrid.ItemsSource = new List<CarDTO>() { cayenne, turbo911, rsq8 };       
        }

        private void RentCarBtn_Click(object sender, RoutedEventArgs e)
        {
            CarDTO car = (CarDTO)((Button)e.Source).DataContext;
            if (car.IsAvailable)
            {
                MessageBox.Show($"Your car: {car.Brand.Name} {car.Model}");
            }
            else
            {
                MessageBox.Show("Sorry, this car is unavailable(");
            }
        }
    }
}
