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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        dbStrahkomp db;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 frm = new Window5();
            frm.Show();
            this.Hide();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_strah_komp.ItemsSource = db.SK_strahovaya_kompania.ToList();
        }
    }
}
