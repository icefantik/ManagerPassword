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
        private UserData elemUserData;
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
        private void OpenSetting_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow settingWindow = new SettingWindow();
            settingWindow.Owner = this;
            settingWindow.ShowDialog();
        }
        private void OpenEdit_Click(object sender, RoutedEventArgs e)
        {
            EditElemWindow editElemWindow = new EditElemWindow(elemUserData.id, elemUserData.title, elemUserData.username, elemUserData.email, elemUserData.url, elemUserData.password, elemUserData.note);
            editElemWindow.Owner = this;
            editElemWindow.ShowDialog();
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
                elemUserData = objSelectTable;
                System.Diagnostics.Debug.WriteLine(elemUserData);
            }
            else
            {
                MessageBox.Show("Элемент в таблице не выбран", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Database.Database.FillDataAdapter(String.Format(Query.execDeteleUser, elemUserData.id));
            UploadTable();
        }
        private static void CopyClipboard(string data)
        {
            Clipboard.SetData(DataFormats.Text, (Object)data);
        }
        private void CopyUsernameMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CopyClipboard(elemUserData.username);
        }
        private void CopyEmailMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CopyClipboard(elemUserData.email);
        }
        private void CopyPasswordMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CopyClipboard(elemUserData.password);
        }
        private void CopyUrlMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CopyClipboard(elemUserData.url);
        }
    }
}
