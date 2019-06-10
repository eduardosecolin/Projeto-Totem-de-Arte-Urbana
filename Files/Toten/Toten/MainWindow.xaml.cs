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
using Toten.Model;
using Toten.View;
using System.Drawing;
using System.IO;

namespace Toten
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private  readonly DB_Connection _connection = new DB_Connection();

        public ImageSource imagem = null;

        public int idImg = 0;

        public MainWindow()
        {
            InitializeComponent();
            FillImages();
        }

        private void Img1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img1.Source;
            idImg = 1;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img2.Source;
            idImg = 2;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img3.Source;
            idImg = 3;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img4.Source;
            idImg = 4;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img5.Source;
            idImg = 5;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img6.Source;
            idImg = 6;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img7.Source;
            idImg = 7;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img8.Source;
            idImg = 8;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img9_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img9.Source;
            idImg = 9;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img10_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img10.Source;
            idImg = 10;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img11.Source;
            idImg = 11;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img12_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img12.Source;
            idImg = 12;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img13_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img13.Source;
            idImg = 13;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img14_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img14.Source;
            idImg = 14;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img15_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img15.Source;
            idImg = 15;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img16_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img16.Source;
            idImg = 16;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img17_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img17.Source;
            idImg = 17;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img18_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img18.Source;
            idImg = 18;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img19_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img19.Source;
            idImg = 19;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void Img20_MouseUp(object sender, MouseButtonEventArgs e)
        {
            imagem = img20.Source;
            idImg = 20;
            Detalhes window = new Detalhes(this);
            window.Show();
        }

        private void FillImages()
        {
            var listImg = _connection.Imagens.Where(x => x.imagem != null).ToList();
            foreach (var item in listImg)
            {
                MemoryStream ms = new MemoryStream(item.imagem);
                var tempImg = new BitmapImage();
                tempImg.BeginInit();
                tempImg.StreamSource = ms;
                tempImg.EndInit();
                if (img1.Source == null)
                {
                    img1.Source = tempImg;
                    continue;
                }
                if (img2.Source == null)
                {
                    img2.Source = tempImg;
                    continue;
                }
                if (img3.Source == null)
                {
                    img3.Source = tempImg;
                    continue;
                }
                if (img4.Source == null)
                {
                    img4.Source = tempImg;
                    continue;
                }
                if (img5.Source == null)
                {
                    img5.Source = tempImg;
                    continue;
                }
                if (img6.Source == null)
                {
                    img6.Source = tempImg;
                    continue;
                }
                if (img7.Source == null)
                {
                    img7.Source = tempImg;
                    continue;
                }
                if (img8.Source == null)
                {
                    img8.Source = tempImg;
                    continue;
                }
                if (img9.Source == null)
                {
                    img9.Source = tempImg;
                    continue;
                }
                if (img10.Source == null)
                {
                    img10.Source = tempImg;
                    continue;
                }
                if (img11.Source == null)
                {
                    img11.Source = tempImg;
                    continue;
                }
                if (img12.Source == null)
                {
                    img12.Source = tempImg;
                    continue;
                }
                if (img13.Source == null)
                {
                    img13.Source = tempImg;
                    continue;
                }
                if (img14.Source == null)
                {
                    img14.Source = tempImg;
                    continue;
                }
                if (img15.Source == null)
                {
                    img15.Source = tempImg;
                    continue;
                }
                if (img16.Source == null)
                {
                    img16.Source = tempImg;
                    continue;
                }
                if (img17.Source == null)
                {
                    img17.Source = tempImg;
                    continue;
                }
                if (img18.Source == null)
                {
                    img18.Source = tempImg;
                    continue;
                }
                if (img19.Source == null)
                {
                    img19.Source = tempImg;
                    continue;
                }
                if (img20.Source == null)
                {
                    img20.Source = tempImg;
                    continue;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
