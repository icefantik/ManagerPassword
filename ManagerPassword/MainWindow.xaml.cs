using ManagerPassword.Database;
using ManagerPassword.Resources;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Threading;
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
        private class ComboData
        {
            public string Name { get; set; }
            public override string ToString() => $"{Name}";
        }
        public MainWindow()
        {
            InitializeComponent();
            UploadTable();
            whatSearch.ItemsSource = new ComboData[]
            {
                new ComboData { Name = title },
                new ComboData { Name = login },
                new ComboData { Name = email },
                new ComboData { Name = url }
            };
            whatSearch.SelectedIndex = 0;
        }
        private const string title = "Title";
        private const string login = "Login";
        private const string email = "Email";
        private const string url = "Url";
        private void OpenAddWindow_Click(object sender, RoutedEventArgs e)
        {
            AddElemWindow addElemWindow = new AddElemWindow();
            addElemWindow.Owner = this;
            addElemWindow.ShowDialog();
            UploadTable();
        }
        private void OpenEditWindow_Click(object sender, RoutedEventArgs e)
        {
            if (elemUserData != null)
            {
                EditElemWindow editElemWindow = new EditElemWindow(elemUserData.id, elemUserData.title, elemUserData.username, elemUserData.email, elemUserData.url, elemUserData.password, elemUserData.note);
                editElemWindow.Owner = this;
                editElemWindow.ShowDialog();
                UploadTable();
            }
        }
        private void ShowHiddenPassword_Click(object sender, RoutedEventArgs e)
        {
            if (MenuItemShowHiddenPwd.IsChecked)
            {
                EnterPasswordWindow pwdWindow = new EnterPasswordWindow();
                pwdWindow.Owner = this;
                pwdWindow.ShowDialog();
            }
        }
        private void OpenSettingWindow_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow settingWindow = new SettingWindow();
            settingWindow.Owner = this;
            settingWindow.ShowDialog();
        }
        private void OpenHelpWindow_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Owner = this;
            helpWindow.ShowDialog();
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
                MessageBox.Show(Message.msgNotChangeElem, Message.captionWarning, MessageBoxButton.OK, MessageBoxImage.Warning);
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
        private void FolowUrl_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Process.Start(elemUserData.url);
            }
            catch
            {
                MessageBox.Show(Message.msgUrlError, Message.captionWarning, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ShowOrHiddenPwd_Click(object sender, RoutedEventArgs e)
        {
            var mainText = ((sender as Button).Content as Image).Source.ToString();

            //cut name image
            int parse = userData.SelectedIndex;

            //var v = userData.SelectedCells;
            int index_start_name = mainText.Length - 1;
            for (; mainText[index_start_name] != '/' && index_start_name >= 0; --index_start_name)
                ;
            //check password hiden or not
            if (mainText.Substring(index_start_name + 1) == "closed_eye.png")
            {
                (sender as Button).Content = new Image
                {
                    Source = new BitmapImage(new Uri(@"/Images/open_eye.png", UriKind.Relative))
                };
                try
                {
                    DataGridRow row = (DataGridRow)userData.ItemContainerGenerator.ContainerFromIndex(parse);
                    //var r = row.DataContext;
                    //var s = userData.Items[parse];
                    //var t = row.Item;
                    var q = e.Source;

                    //var p = e.Row.

                    //var s = t.password;
                    var tmp = userData.Columns[4].Visibility;
                    var x = userData.Columns[4].GetCellContent(userData.Items[parse]) as TextBlock;

                    //x.Visibility = Visibility.Collapsed;
                }
                catch (System.IndexOutOfRangeException)
                {

                }

                //userData.Columns[0].Visibility = Visibility.Collapsed;
                
                //for (int i = 0; i < userData.Items.Count; i++)
                //{
                //    DataGridRow row = (DataGridRow)userData.ItemContainerGenerator
                //                                               .ContainerFromIndex(i);
                //    row.Visibility = Visibility.Collapsed;
                //}

                textBoxPwd.Visibility = Visibility.Visible;
                VisiblePassword.Visibility = Visibility.Collapsed;

                //var tmp = userData.Items;
                //var t = e.Source;
                //userData.ItemsSource = userData.Items;
            }
            else
            {
                (sender as Button).Content = new Image
                {
                    Source = new BitmapImage(new Uri(@"/Images/closed_eye.png", UriKind.Relative))
                };
                textBoxPwd.Visibility = Visibility.Collapsed;
                VisiblePassword.Visibility = Visibility.Visible;
            }
        }

        private void textBoxPwd_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void userData_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var p = e.Row.Item;
        }

        private void OpenSearchWindow_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Owner = this;
            searchWindow.Show();
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            List<UserData> dataTable = new List<UserData>();
            if (whatSearch.SelectedItem is ComboData userData && searchTextBox.Text != "")
            {
                switch (userData.Name)
                {
                    case title: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchTitle, searchTextBox.Text)); break;
                    case login: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchLogin, searchTextBox.Text)); break;
                    case email: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchEmail, searchTextBox.Text)); break;
                    case url: dataTable = Database.Database.GetListUserData(String.Format(Query.execSearchUrl, searchTextBox.Text)); break;
                }
            }
            UploadSearchResult(dataTable);
        }
        private void UploadSearchResult(List<UserData> dataTable)
        {
            userData.ItemsSource = dataTable;
        }

        private void ShowAllElem_Click(object sender, RoutedEventArgs e)
        {
            UploadTable();
        }
    }
}
