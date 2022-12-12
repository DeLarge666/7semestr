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
using WordSkills.Classes;
using WordSkills.Models;

namespace WordSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Random _random = new Random();//объявляем метод Random(нужен для создания псевдослучайных значений)
        public Login()
        {
            InitializeComponent();
            UpdateCaptcha();
            ConnectDBClass.modelDB = new Models.BlagodatLidovskoy195Entities();//подключение бд
        }

        private void UpdateCaptcha()
        {
            symbols = "";//при обновлении капчи удаляются данные, внесенные в переменную symbols  с помощью метода Generate symbols
            SPanelSymbols.Children.Clear();//Очистка изображения капчи
            CanvasNoise.Children.Clear();//очистка поляввода капчи



            GenerateSymbols(4);//метод генерирует 4 сивола на капче
            GenerateNoise(30);//метод генерирует 30 палочек и кружочков на капче
        }
        public string symbols;//объявляется переменная sybmols, в которую заносятся сиволы капчи
        private void GenerateSymbols(int count)//метод, рандомно выбирающий 4 или цифры буквы из английского алфавита
        {
            string alphabet = "WERPASFHKXVBM234578";//переменная, в которой хранятся буквы алфавита
            for (int i = 0; i < count; i++)//цикл проходит 4 раза, и выбирает 4 рандомные буквы или цифры
            {
                string symbol = alphabet.ElementAt(_random.Next(0, alphabet.Length)).ToString();
                TextBlock lbl = new TextBlock();//вызывается экзмемляр класса Textblock 



                lbl.Text = symbol;//данные заносятся в текстблок капчи, в которой отображаются символы
                lbl.FontSize = _random.Next(40, 80);//рандомный размер шрифта в капче
                lbl.RenderTransform = new RotateTransform(_random.Next(-45, 45));//крутим буквы для условжнения капчи
                lbl.Margin = new Thickness(10, 0, 10, 0);
                SPanelSymbols.Children.Add(lbl);
                symbols = symbols + symbol;//в переменную вносится по одному символу, нужно для дальнейшего сравнения сиволов, введенных пользователем и символов на капче 
            }
        }



        private void GenerateNoise(int volumeNoise)//генерация шума(кружочки и палочки)
        {
            volumeNoise = 10;//создаем 10 палочек
            for (int i = 0; i < volumeNoise; i++)
            {
                Border border = new Border();//создания экземляра бордер, его и будем использовать как палку
                border.Background = new SolidColorBrush(Color.FromArgb((byte)_random.Next(100, 200),//Определение цвета, путем использования метода random
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256)));
                border.Height = _random.Next(2, 5);//рандомная ширина
                border.Width = _random.Next(10, 50);//рандомная высота



                border.RenderTransform = new RotateTransform(_random.Next(0, 360));//рандомный поворот под углом






                CanvasNoise.Children.Add(border);
                Canvas.SetLeft(border, _random.Next(40, 300));//разброс палочек по ширине
                Canvas.SetTop(border, _random.Next(10, 100));//разброс палочек по высоте















                Ellipse ellipse = new Ellipse();
                ellipse.Fill = new SolidColorBrush(Color.FromArgb((byte)_random.Next(100, 200),//случайный выбор цветов
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256)));
                ellipse.Height = ellipse.Width = _random.Next(20, 40);



                CanvasNoise.Children.Add(ellipse);
                Canvas.SetLeft(ellipse, _random.Next(0, 300));//разбросс кружков по ширине
                Canvas.SetTop(ellipse, _random.Next(10, 50));//разбросс кружков по высоте
            }
        }
        private void BtnUpdateCaptcha_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaptcha();
        }
        private void LoginButton(object sender, RoutedEventArgs e)
        {
            try
            {
                // обратиться к таблице User, чтобы извлечь логин  пароль
                // var - общий тип переменной
                // userObj - имя объектаБ которого вы задаете сами. Информация об агенте - agentObj
                //Сравнить данные из таблицы и назвыния столбцов
                var userObj = ConnectDBClass.modelDB.User.FirstOrDefault(x =>
                x.Name == textboxLogin.Text && x.Password == PassBox.Password);//проверка условия, если данные и капча правильные, то программа определяет роль пользователя и открывает нужную страницу
                if (userObj != null && (CaptchaGet.Text == symbols))
                {

                    BlagodatLidovskoy195Entities.CurentStaff = userObj;
                    switch (userObj.RoleID)//проверка роли
                    {
                        case 1://роль админ
                            NavigationService.Navigate(new Admin());//открываем страницу админа
                            break;
                        case 2://роль пользователь
                            NavigationService.Navigate(new User());//открываем страницу юзера
                            break;
                        case 3://роль админ
                            NavigationService.Navigate(new Admin());//открываем страницу админа
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление",//программа не нашла подходящую роль и невпустила пользователя
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
                else
                {

                    MessageBox.Show("Такого пользователя нет или капча введена некорректно!", "Ошибка при авторизации",//пользовательввел неправильные данные, вывелось окно ошибки
                   MessageBoxButton.OK, MessageBoxImage.Error);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Критическая работа приложения",//непредвиденная ошибка(в большинстве случаев связана с нарушением работы бд, её отсутсвие, некорректными связями или действиями, приведшими к сбою программы)
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TbxShowPass_MouseDown(object sender, MouseButtonEventArgs e)//скрываем пароль при нажатии
        {
            TxbPassword.Width = PassBox.Width;
            TxbPassword.Visibility = Visibility.Visible;
            PassBox.Visibility = Visibility.Collapsed;
            TxbPassword.Text = PassBox.Password;
        }

        private void TbxShowPass_MouseUp(object sender, MouseButtonEventArgs e)//показываем пароль при нажатии
        {
            TxbPassword.Visibility = Visibility.Collapsed;//параметр visibility отвечает за сокрытие пароля или же наоброо демонстврацию данных в поле
            PassBox.Visibility = Visibility.Visible;
        }
    }
}
