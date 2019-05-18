using Cards.Models;
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

namespace CardsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = firstName.Text;
            string surname = secondName.Text;
            string groupsName = groups.Text;
            
            using(var context = new Cards.DataAccess.ContextCards())
            {
                Students student = new Students
                {
                    FirstName = name,
                    SecondName = surname,
                    Group = groupsName
                };
                context.Student.Add(student);
                context.SaveChanges();
            }
        }
    }
}
