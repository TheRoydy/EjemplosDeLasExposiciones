using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Ventana_Pizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            txbLog.Text += "¡Tengo Hambre!" + Environment.NewLine;
            Task<Pizza> pizzaTask = OrderPizza();
            WatchTv();
            Pizza pizza = await pizzaTask;
            Eat(pizza);
            txbLog.Text += "¡Satisfecho con mi productividad!" + Environment.NewLine;
        }
        async Task<Pizza> OrderPizza()
        {
            Pizza pizza = new Pizza();
            txbLog.Text += "Pizza: Preparando..." + Environment.NewLine;
            await Task.Delay(5000);
            txbLog.Text += "Pizza: Enviando..." + Environment.NewLine;
            await Task.Delay(5000);
            txbLog.Text += "Pizza: Llegó..." + Environment.NewLine;
            return pizza;
        }

        void WatchTv()
        {
            txbLog.Text += "Viendo TV..." + Environment.NewLine;
        }

        void Eat(Pizza pizza)
        {
            txbLog.Text += "Comiendo..." + Environment.NewLine;
        }

        private class Pizza
        {

        }

    }
}


