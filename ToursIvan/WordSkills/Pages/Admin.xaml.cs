using Blagodat;
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
using System.Windows.Threading;
using WordSkills.Classes;

namespace WordSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        DispatcherTimer timer = new DispatcherTimer();//объявление экземпляра класса Timer
        DateTime date = new DateTime(0, 0);//дефолтное значение времени, при переходе в учтеную запись
        public Admin()
        {
            InitializeComponent();
            UserTB.Text = Models.BlagodatLidovskoy195Entities.CurentStaff.Name;//текстблок получает данные из currentStaff(в этом полу получает имя) 
            RoleTB.Text = "(" + Models.BlagodatLidovskoy195Entities.CurentStaff.Role.ID + ")";//текстблок получает данные из currentStaff(в этом полу получает ID роли) 
            var fullFilePath = Models.BlagodatLidovskoy195Entities.CurentStaff.photo;//текстблок получает данные из currentStaff(в этом полу получает фото) 

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            UserPhoto.Source = bitmap;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTick;
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            TimeTB.Text = date.ToString("HH:mm:ss");//определяется время сеанса

            if (TimeTB.Text == "00:00:20")//после 5 минут massage box выводи придупреждении о б оставшемся времени сеанса
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB.Text == "00:00:30")//после 10 минут пользователя или админа выкидывает из учетной записи
            {
                timer.Stop();//остановка таймера
                App.IsGone = true;
                NavigationService.Navigate(new Login());//вывод из учетной записи
            }
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductAgents());
        }
    }
}
