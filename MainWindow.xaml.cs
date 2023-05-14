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

namespace Menu_BKJN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }
        public void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[6];
            //string gaucamolePrice;
            
            for (int i = 0; i<menuItems.Length; i++)
            {
                menuItems[i]=new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Bred = new string[] { "zwykły rogal", "rogal cebulowy", "rogal z pumpernikla", "rogal z wszystkim" };

                    
                }
                menuItems[i].Generate();
            }
            
            for(int i = 0;i<menuItems.Length;i++)
            {
                string nameD = "item" + i;
                string nameP = "price" + i;
                foreach (TextBlock item in mainWinow.Children.OfType<TextBlock>())//this.Children.OfType<TextBox>()
                {
                    if (item.Name == nameD) item.Text = menuItems[i].description;
                    if (item.Name == nameP) item.Text = menuItems[i].Price;

                }
            }
            MenuItem guacamoleItem = new MenuItem();
            guacamoleItem.Generate();
            glacmole.Text = "Dodaj gaucamole za: "+ guacamoleItem.Price;
        }
    }  
}
