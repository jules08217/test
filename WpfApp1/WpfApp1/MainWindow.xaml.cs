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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        public void Update()
        {
            var list = App.DB.agents.ToList();
            listView.ItemsSource = list;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            agents agent = new agents
            {
                FirstName = fNameTextBox.Text,
                MiddleName = mNameTextBox.Text,
                LastName = lNameTextBox.Text,
                DealShare = Convert.ToInt32(dShareTextBox.Text),
            };
            App.DB.agents.Add(agent);
            App.DB.SaveChanges();
            MessageBox.Show("Данные добавлены");
            Update();

        }
    }
}
