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
using System.Windows.Shapes;

namespace ManagerPassword
{
    /// <summary>
    /// Логика взаимодействия для EditElemWindow.xaml
    /// </summary>
    public partial class EditElemWindow : Window
    {
        private static int contentId;
        public EditElemWindow(int id, string title, string username, string email, string url, string password, string note)
        {
            InitializeComponent();
            contentId = id;
            textboxTitle.Text = title;
            textboxUsername.Text = username;
            textboxEmail.Text = email;
            textboxUrl.Text = url;
            textboxPassword.Text = password;
            textboxNote.Text = note;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            Database.Database.FillDataAdapter(String.Format(Database.Query.execUpdateUserData, contentId, textboxTitle.Text, textboxUsername.Text, textboxEmail.Text,
                textboxUrl.Text, Encryption.EncryptionPwd(textboxPassword.Text), textboxNote.Text));
            Hide();
        }
    }
}
