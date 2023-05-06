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
    public partial class Window4 : Window
    {

        dbStrahkomp db;
        public Window4()
        {
            InitializeComponent();
        }

        //Добавить
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SK_vid_dogovora dogovor = new SK_vid_dogovora();
            dogovor.vid_dogovora = vid.Text;
            db.SK_vid_dogovora.Add(dogovor);
            db.SaveChanges();
            DG_vid_dogovora.ItemsSource = db.SK_vid_dogovora.ToList();
        }
        //Удалить
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var dRow = db.SK_vid_dogovora.Where(w => w.kod_vida_dogovora == num).FirstOrDefault();
            db.SK_vid_dogovora.Remove(dRow);
            db.SaveChanges();
            DG_vid_dogovora.ItemsSource = db.SK_vid_dogovora.ToList();
        }
        //Изменить
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(txtId.Text);
            var uRow = db.SK_vid_dogovora.Where(w => w.kod_vida_dogovora == num).FirstOrDefault();
            uRow.vid_dogovora = vid.Text;
            db.SaveChanges();
            DG_vid_dogovora.ItemsSource = db.SK_vid_dogovora.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new dbStrahkomp();
            DG_vid_dogovora.ItemsSource = db.SK_vid_dogovora.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
            this.Hide();
        }
    }
}
