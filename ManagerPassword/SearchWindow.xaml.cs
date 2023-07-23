using ManagerPassword.Database;
using ManagerPassword.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace ManagerPassword
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private const string title = "Title";
        private const string login = "Login";
        private const string email = "Email";
        private const string url = "Url";

        public SearchWindow()
        {
            InitializeComponent();
            whatSearch.ItemsSource = new ComboData[]
            {
                new ComboData { Name = title },
                new ComboData { Name = login },
                new ComboData { Name = email },
                new ComboData { Name = url }
            };
            whatSearch.SelectedIndex = 0;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            List<UserData> dataTable;
            if (whatSearch.SelectedItem is ComboData userData)
            {
                switch (userData.Name)
                {
                    case title: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchTitle, searchTextBox.Text)); break;
                    case login: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchLogin, searchTextBox.Text)); break;
                    case email: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchEmail, searchTextBox.Text)); break;
                    case url: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchUrl, searchTextBox.Text)); break;
                }
            }
            //var s = dataTable;
            this.Close();
        }

        private void whatSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //whatSearch.SelectedItem;
        }
    }
    class ComboData
    {
        public string Name { get; set; }
        public override string ToString() => $"{Name}";
    }
}
