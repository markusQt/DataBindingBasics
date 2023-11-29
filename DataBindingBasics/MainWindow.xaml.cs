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

namespace DataBindingBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _Person = new Person()
        {
            Name = "Markus Wildner",
            Email = "markus-72@gmx.de",
            Address = "95683 Ebnath Sonnenstrasse 6",
            Number = 12345
        };
        public MainWindow()
        {
            InitializeComponent();
          

            this.DataContext = _Person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{_Person.Name}");
        }
    }

    class Person {

        public Person()
        {
                
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }

    }
}
