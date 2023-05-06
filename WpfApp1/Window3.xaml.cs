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
    public partial class Window3 : Window
    {

        dbStrahkomp db;
        public Window3()
        {
            InitializeComponent();
        }

        //Добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SK_dogovor dogovor = new SK_dogovor();
            dogovor.data_zakluchenya_dogovora = data.Text;
            dogovor.srok_deystvia = srok.Text;
            dogovor.strahovaya_summa = summa.Text;
            dogovor.vid_srahovania = vid.Text;
            dogovor.tarifnaya_stavka = stavka.Text;
            db.SK_dogovor.Add(dogovor);
            db.SaveChanges();
            DG_dogovor.ItemsSource = db.SK_dogovor.ToList();
        }
        //Удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var dRow = db.SK_dogovor.Where(w => w.kod_dogovora == num).FirstOrDefault();
            db.SK_dogovor.Remove(dRow);
            db.SaveChanges();
            DG_dogovor.ItemsSource = db.SK_dogovor.ToList();
        }
        //Изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var uRow = db.SK_dogovor.Where(w => w.kod_dogovora == num).FirstOrDefault();
            uRow.data_zakluchenya_dogovora = data.Text;
            uRow.srok_deystvia = srok.Text;
            uRow.strahovaya_summa = summa.Text;
            uRow.vid_srahovania = vid.Text;
            uRow.tarifnaya_stavka = stavka.Text;
            db.SaveChanges();
            DG_dogovor.ItemsSource = db.SK_dogovor.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_dogovor.ItemsSource = db.SK_dogovor.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
            this.Hide();
        }
    }
}
