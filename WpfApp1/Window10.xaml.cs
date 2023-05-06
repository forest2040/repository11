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
    public partial class Window10 : Window
    {

        dbStrahkomp db;
        public Window10()
        {
            InitializeComponent();
        }

        //Добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SK_filial_kompanii filialkomp = new SK_filial_kompanii();
            filialkomp.nazvanie = nazvan.Text;
            filialkomp.adres = adr.Text;
            filialkomp.telefon = telef.Text;
            db.SK_filial_kompanii.Add(filialkomp);
            db.SaveChanges();
            DG_filial.ItemsSource = db.SK_filial_kompanii.ToList();
        }
        //Удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var dRow = db.SK_filial_kompanii.Where(w => w.kod_filiala_kompanii == num).FirstOrDefault();
            db.SK_filial_kompanii.Remove(dRow);
            db.SaveChanges();
            DG_filial.ItemsSource = db.SK_filial_kompanii.ToList();
        }
        //Изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var uRow = db.SK_filial_kompanii.Where(w => w.kod_filiala_kompanii == num).FirstOrDefault();
            uRow.nazvanie = nazvan.Text;
            uRow.adres = adr.Text;
            uRow.telefon = telef.Text;
            db.SaveChanges();
            DG_filial.ItemsSource = db.SK_filial_kompanii.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_filial.ItemsSource = db.SK_filial_kompanii.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
            this.Hide();
        }
    }
}
