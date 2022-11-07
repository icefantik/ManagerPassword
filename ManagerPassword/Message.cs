using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManagerPassword
{
    class Message
    {
        public static string captionWarning = "Warning";
        public static string msgNotChangeElem = "Элемент в таблице не выбран";
        public static string msgUrlError = "Url либо недоступен либо некоректно введён";
        public static string msgEmptyTextBox = "Ошибка, поле или поля пустые";
        public static string msgBadEmail = "Введен некорректный электронный адрис";
        public static string msgBadUsername = "Введен некорректный логин пользователя";
        public static void MessageBoxError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
