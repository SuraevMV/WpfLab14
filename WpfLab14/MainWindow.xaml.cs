using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfLab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Хлеб",
                Price = 25.55,
                Image = "Data/1.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Картошка",
                Price = 42.80,
                Image = "Data/2.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Тостер",
                Price = 1999.90,
                Image = "Data/3.jpg",
                ProductCategory = ProductCategories.HomeAppliances
            });
            products.Add(new Product()
            {
                Name = "Сахар",
                Price = 55.10,
                Image = "Data/4.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Микроволновка",
                Price = 2500.00,
                Image = "Data/5.jpg",
                ProductCategory = ProductCategories.HomeAppliances
            });
            listBox.ItemsSource = products;
        }
    }
}
