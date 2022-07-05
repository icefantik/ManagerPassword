using ManagerPassword.Database;
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
            if (!(textboxTitle.Text == "" || textboxUsername.Text == "" || textboxEmail.Text == "" || textboxUrl.Text == "" || textboxPassword.Text == "" || textboxNote.Text == ""))
            {
                string query = String.Format(Query.execAddElem, textboxTitle.Text, textboxUsername.Text, textboxEmail.Text, textboxUrl.Text, textboxPassword.Text, textboxNote.Text);
                Database.Database.AddElemUserData(query);
                Hide();
            }
            else
            {
                MessageBox.Show("Незаполненое поле или поля", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void GenerationPassword_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string word = "";
            for (int index = 1; index <= LengthLetters; ++index)
            {
                int letter_number = rand.Next(0, letters.Length - 1);
                word += letters[letter_number];
            }
            textboxPassword.Text = word;
        }
    }
}
