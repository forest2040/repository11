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
    public partial class Window9 : Window
    {

        dbStrahkomp db;
        public Window9()
        {
            InitializeComponent();
        }

        //Добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SK_strahovaya_kompania komp = new SK_strahovaya_kompania();
            komp.nazvane = nazvan.Text;
            komp.adres = adr.Text;
            komp.telefon = telef.Text;
            komp.elektronnaya_pochta = email.Text;
            db.SK_strahovaya_kompania.Add(komp);
            db.SaveChanges();
            DG_strah_komp.ItemsSource = db.SK_strahovaya_kompania.ToList();
        }
        //Удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var dRow = db.SK_strahovaya_kompania.Where(w => w.kod_kompanii == num).FirstOrDefault();
            db.SK_strahovaya_kompania.Remove(dRow);
            db.SaveChanges();
            DG_strah_komp.ItemsSource = db.SK_strahovaya_kompania.ToList();
        }
        //Изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var uRow = db.SK_strahovaya_kompania.Where(w => w.kod_kompanii == num).FirstOrDefault();
            uRow.nazvane = nazvan.Text;
            uRow.adres = adr.Text;
            uRow.telefon = telef.Text;
            uRow.elektronnaya_pochta = email.Text;
            db.SaveChanges();
            DG_strah_komp.ItemsSource = db.SK_strahovaya_kompania.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_strah_komp.ItemsSource = db.SK_strahovaya_kompania.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
            this.Hide();
        }
    }
}
