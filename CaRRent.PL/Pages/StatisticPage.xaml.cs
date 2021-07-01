using CaRRent.BLL.Abstracts;
using CaRRent.BLL.DI;
using CaRRent.BLL.DTO;
using CaRRent.BLL.Services;
using Ninject;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaRRent.PL.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
        readonly IKernel _kernel;
        readonly IStatisticService _statisticService;

        public StatisticPage()
        {
            InitializeComponent();

            CarBrandDTO porsche = new CarBrandDTO() { Name = "Porsche" };
            CarBrandDTO audi = new CarBrandDTO() { Name = "Audi" };

            CarDTO cayenne = new CarDTO() { Model = "Cayenne GTS", Brand = porsche };
            CarDTO turbo911 = new CarDTO() { Model = "911 Turbo", Brand = porsche };
            CarDTO rsq8 = new CarDTO() { Model = "RSQ8", Brand = audi };

            int rentCayenneCount = 56;
            int rentTurbo911Count = 19;
            int rentRsq8Count = 32;

            List<KeyValuePair<string, int>> popularityValueList = new List<KeyValuePair<string, int>>();
            popularityValueList.Add(new KeyValuePair<string, int>(cayenne.ToString(), rentCayenneCount));
            popularityValueList.Add(new KeyValuePair<string, int>(turbo911.ToString(), rentTurbo911Count));
            popularityValueList.Add(new KeyValuePair<string, int>(rsq8.ToString(), rentRsq8Count));

            statChart.DataContext = popularityValueList;
        }
    }
}
