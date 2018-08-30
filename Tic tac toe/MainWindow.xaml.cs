using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Tic_tac_toe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] p = new char[9];
        char who = 'x';

        public MainWindow()
        {
            InitializeComponent();
  
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = 'n';
            }
            
            Img1.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img2.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img3.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img4.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img5.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img6.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img7.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img8.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));
            Img9.Source = new BitmapImage(new Uri(@"Resources/nothing.bmp", UriKind.RelativeOrAbsolute));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Img1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(p[0] == 'n')
            {
                if(who == 'x')
                    ChangePlayer_X(Img1, 0);
                else if (who == 'o')
                    ChangePlayer_O(Img1, 0);

                Img1.IsEnabled = false;
            }
        }

        private void Img2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[1] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img2, 1);
                else if (who == 'o')
                    ChangePlayer_O(Img2, 1);

                Img2.IsEnabled = false;
            }
        }

        private void Img3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[2] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img3, 2);
                else if (who == 'o')
                    ChangePlayer_O(Img3, 2);

                Img3.IsEnabled = false;
            }
        }

        private void Img4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[3] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img4, 3);
                else if (who == 'o')
                    ChangePlayer_O(Img4, 3);

                Img4.IsEnabled = false;
            }
        }

        private void Img5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[4] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img5, 4);
                else if (who == 'o')
                    ChangePlayer_O(Img5, 4);

                Img5.IsEnabled = false;
            }
        }

        private void Img6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[5] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img6, 5);
                else if (who == 'o')
                    ChangePlayer_O(Img6, 5);

                Img6.IsEnabled = false;
            }
        }

        private void Img7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[6] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img7, 6);
                else if (who == 'o')
                    ChangePlayer_O(Img7, 6);

                Img7.IsEnabled = false;
            }
        }

        private void Img8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[7] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img8, 7);
                else if (who == 'o')
                    ChangePlayer_O(Img8, 7);

                Img8.IsEnabled = false;
            }
        }

        private void Img9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (p[8] == 'n')
            {
                if (who == 'x')
                    ChangePlayer_X(Img9, 8);
                else if (who == 'o')
                    ChangePlayer_O(Img9, 8);

                Img9.IsEnabled = false;
            }
        }

        void ChangePlayer_X(Image image, int i)
        {
            image.Source = new BitmapImage(new Uri(@"Resources/x.bmp", UriKind.RelativeOrAbsolute));
            p[i] = 'x';
            Img_who.Source = new BitmapImage(new Uri(@"Resources/o.bmp", UriKind.RelativeOrAbsolute));
            Check();
            who = 'o';
        }
        void ChangePlayer_O(Image image, int i)
        {
            image.Source = new BitmapImage(new Uri(@"Resources/o.bmp", UriKind.RelativeOrAbsolute));
            p[i] = 'o';
            Img_who.Source = new BitmapImage(new Uri(@"Resources/x.bmp", UriKind.RelativeOrAbsolute));
            Check();
            who = 'x';
        }
        void Check()
        {
            if ((p[0] == p[1] && p[1] == p[2] && p[0] != 'n') ||
               (p[3] == p[4] && p[4] == p[5] && p[3] != 'n') ||
               (p[6] == p[7] && p[7] == p[8] && p[6] != 'n') ||
               (p[0] == p[3] && p[3] == p[6] && p[0] != 'n') ||
               (p[1] == p[4] && p[4] == p[7] && p[1] != 'n') ||
               (p[2] == p[5] && p[5] == p[8] && p[2] != 'n') ||
               (p[0] == p[4] && p[4] == p[8] && p[0] != 'n') ||
               (p[2] == p[4] && p[4] == p[6] && p[2] != 'n') )
            {
                MessageBoxResult messageBox = MessageBox.Show("Woooon, player " + who);
            }
        }
    }
}
