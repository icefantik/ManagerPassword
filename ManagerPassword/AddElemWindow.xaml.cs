using ManagerPassword.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddElemWindow.xaml
    /// </summary>
    public partial class AddElemWindow : Window
    {
        private int LengthLetters = 6;
        private char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();
        public AddElemWindow()
        {
            InitializeComponent();
        }
        private void AddElem_Btn(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z](.[a-zA-Z0-9_-]*)$");
            MatchCollection match = regex.Matches(textboxUsername.Text);
            if (CheckData.CheckTextBoxData(textboxTitle.Text, textboxUsername.Text, textboxEmail.Text, textboxUrl.Text, textboxPassword.Text, textboxNote.Text))
            {
                string query = String.Format(Query.execAddElem, textboxTitle.Text, textboxUsername.Text, textboxEmail.Text, textboxUrl.Text, Encryption.EncryptionPwd(textboxPassword.Text), textboxNote.Text);
                Database.Database.AddElemUserData(query);
                Hide();
            }
        }
        private void GenerationPassword_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string password = "";
            for (int index = 1; index <= LengthLetters; ++index)
            {
                int letter_number = rand.Next(0, letters.Length - 1);
                password += letters[letter_number];
            }
            textboxPassword.Text = password;
        }
    }
}
