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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Modtext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Modtext();
            db.people.Load();
            Peopls.ItemsSource = db.people.Local.ToBindingList();


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void DelteB_Click(object sender, RoutedEventArgs e)
        {
            if (Peopls.SelectedItems.Count > 0)
            {
                for (int i = 0; i < Peopls.SelectedItems.Count; i++)
                {
                    People phone = Peopls.SelectedItems[i] as People;
                    if (phone != null)
                    {
                        db.people.Remove(phone);
                    }

                }
            }
            db.SaveChanges();

        }
    }
}
