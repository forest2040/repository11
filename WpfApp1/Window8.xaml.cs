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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window8 : Window
    {

        dbStrahkomp db;
        public Window8()
        {
            InitializeComponent();
        }

        //Добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SK_Klient klient = new SK_Klient();
            klient.familiya = famil.Text;
            klient.imya = im.Text;
            klient.otchestvo = otchestv.Text;
            klient.nomer_telephona = nomertel.Text;
            db.SK_Klient.Add(klient);
            db.SaveChanges();
            DG_klient.ItemsSource = db.SK_Klient.ToList();
        }
        //Удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var dRow = db.SK_Klient.Where(w => w.kod_klienta == num).FirstOrDefault();
            db.SK_Klient.Remove(dRow);
            db.SaveChanges();
            DG_klient.ItemsSource = db.SK_Klient.ToList();
        }
        //Изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var uRow = db.SK_Klient.Where(w => w.kod_klienta == num).FirstOrDefault();
            uRow.familiya = famil.Text;
            uRow.imya = im.Text;
            uRow.otchestvo = otchestv.Text;
            uRow.nomer_telephona = nomertel.Text;
            db.SaveChanges();
            DG_klient.ItemsSource = db.SK_Klient.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_klient.ItemsSource = db.SK_Klient.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
            this.Hide();
        }
    }
}
