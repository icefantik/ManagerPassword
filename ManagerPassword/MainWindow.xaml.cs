using ManagerPassword.Database;
using ManagerPassword.Resources;
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

namespace ManagerPassword
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int idElem;
        public MainWindow()
        {
            InitializeComponent();
            UploadTable();
        }
        private void OpenAddElem(object sender, RoutedEventArgs e)
        {
            AddElemWindow addElemWindow = new AddElemWindow();
            addElemWindow.Owner = this;
            addElemWindow.ShowDialog();
            UploadTable();
        }
        public void UploadTable()
        {
            List<UserData> userDatas = Database.Database.GetListUserData(Query.execGetUserData);
            userData.ItemsSource = userDatas;
        }
        private void Click_RightButton(object sender, RoutedEventArgs e)
        {
            UserData objSelectTable = (UserData)userData.SelectedItem;
            if (objSelectTable != null)
            {
                idElem = objSelectTable.id;
                System.Diagnostics.Debug.WriteLine(idElem);
            }
            else
            {
                MessageBox.Show("Элемент в таблице не выбран", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
