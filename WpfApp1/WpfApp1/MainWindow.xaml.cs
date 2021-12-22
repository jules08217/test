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

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var buttonDelete = (Button)sender;
            var agent = (agents)buttonDelete.DataContext;

            App.DB.agents.Remove(agent);
            App.DB.SaveChanges();
            MessageBox.Show($"{agent.FirstName} {agent.MiddleName} удален!");
            Update();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            var buttonDelete = (Button)sender;
            var agent = (agents)buttonDelete.DataContext;
            fNameTextBox.Text = agent.FirstName;
            mNameTextBox.Text = agent.MiddleName;
            lNameTextBox.Text = agent.LastName;
            dShareTextBox.Text = Convert.ToString(agent.DealShare);
            App.change_agent = agent;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var ch_agent = App.DB.agents.Where(p => p.Id == App.change_agent.Id).FirstOrDefault();
            ch_agent.FirstName = fNameTextBox.Text;
            ch_agent.MiddleName = mNameTextBox.Text;
            ch_agent.LastName = lNameTextBox.Text;
            ch_agent.DealShare = Convert.ToInt32(dShareTextBox.Text);

            App.DB.SaveChanges();
            MessageBox.Show("Данные изменены");
            Update();
        }
    }
}
