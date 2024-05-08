using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab3_Q2
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        public SignUpWindow()
        {
            InitializeComponent();

            users.Add(new User { Username = "Marjan", Password = "Marjan 123" });
            users.Add(new User { Username = "Shayan", Password = "Shayan 123" });
            users.Add(new User { Username = "Maryam", Password = "Maryam 123" });
            users.Add(new User { Username = "Sana", Password = "Sana 123" });
            users.Add(new User { Username = "Ali", Password = "Ali 123" });
            users.Add(new User { Username = "Ali", Password = "Ali 123" });
            users.Add(new User { Username = "Mari", Password = "Mari 123" });
            users.Add(new User { Username = "Sara", Password = "Sara 123" });
            users.Add(new User { Username = "Hamid", Password = "Hamid 123" });
            users.Add(new User { Username = "Rihana", Password = "Rihana 123" });


            UserList.ItemsSource = users;
        }
    }
}
