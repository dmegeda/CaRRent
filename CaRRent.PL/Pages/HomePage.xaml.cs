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
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            CarDTO car = new CarDTO()
            {
                Id = 1,
                Brand = new CarBrandDTO() { Id = 1, Name = "Porsche" },
                Model = "Cayenne",
                IsAvailable = true,
                Price = 120000,
                RentPrice = 1000
            };
            carsDataGrid.ItemsSource = new List<CarDTO>() { car };       
        }

        public void RentCar(int Id)
        {
            MessageBox.Show("" + Id);
        }

        private void RentCarBtn_Click(object sender, RoutedEventArgs e)
        {
            CarDTO car = (CarDTO)((Button)e.Source).DataContext;
            MessageBox.Show($"Your car: {car.Brand.Name} {car.Model}");
        }
    }
}
