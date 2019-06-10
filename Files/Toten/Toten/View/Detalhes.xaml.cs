using System;
using System.Collections.Generic;
using System.IO;
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
using Toten.Model;
using Toten.Services;

namespace Toten.View
{
    /// <summary>
    /// Lógica interna para Detalhes.xaml
    /// </summary>
    public partial class Detalhes : Window
    {
        MainWindow _window;
        private readonly ServiceModel _service = new ServiceModel();

        public Detalhes(MainWindow window)
        {

            InitializeComponent();
            _window = window;
            imgDetails.Source = _window.imagem;
            FillInfoImg();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLike_Click(object sender, RoutedEventArgs e)
        {
            Icon1.Kind = MaterialDesignThemes.Wpf.PackIconKind.Like;
            Icon2.Kind = MaterialDesignThemes.Wpf.PackIconKind.DislikeOutline;

            Comentarios comentario = new Comentarios();
            comentario.comentario = txtComentarios.Text;
            comentario.id_imagem = _window.idImg;

            int? cont = 0;
            using (DB_Connection con = new DB_Connection())
            {
                cont = con.Imagens.Where(x => x.id == _window.idImg).Max(x => x.like_positivo);
                if(cont == null)
                {
                    cont = 0;
                }
            }

            Imagens imagem = new Imagens();
            imagem.like_positivo = cont + 1;
            imagem.id = _window.idImg;

            _service.UpdateTable(comentario);
            ExecuteUpdate(cont + 1, imagem.id, "like_positivo");

            ClearField();
            EnableFields();
            btnDesLike.IsEnabled = false;
        }

        private void BtnDesLike_Click(object sender, RoutedEventArgs e)
        {
            Icon1.Kind = MaterialDesignThemes.Wpf.PackIconKind.LikeOutline;
            Icon2.Kind = MaterialDesignThemes.Wpf.PackIconKind.Dislike;

            Comentarios comentario = new Comentarios();
            comentario.comentario = txtComentarios.Text;
            comentario.id_imagem = _window.idImg;

            int? cont = 0;
            using (DB_Connection con = new DB_Connection())
            {
                cont = con.Imagens.Where(x => x.id == _window.idImg).Max(x => x.like_negativo);
                if (cont == null)
                {
                    cont = 0;
                }
            }

            Imagens imagem = new Imagens();
            imagem.like_negativo = cont + 1;
            imagem.id = _window.idImg;

            _service.UpdateTable(comentario);
            ExecuteUpdate(cont + 1, imagem.id, "like_negativo");

            ClearField();
            EnableFields();

            btnLike.IsEnabled = false;
        }

        private void FillInfoImg()
        {
            using(DB_Connection con = new DB_Connection())
            {
                var img = con.Imagens.Where(x => x.imagem != null).ToList();
                foreach (var item in img)
                {
                    if(_window.idImg == item.id)
                    {
                        lblLocal.Content = _service.GetAddressImg(item.id);
                        lblRegion.Content = _service.GetRegionImg(item.id);
                    }
                }
            }
        }

        private void ClearField()
        {
            txtComentarios.Clear();
        }

        private void EnableFields()
        {
            txtComentarios.IsReadOnly = true;
        }

        private void ExecuteUpdate(int? valor, int id, string field)
        {
            using(DB_Connection con = new DB_Connection())
            {
                con.Database.ExecuteSqlCommand($"UPDATE Imagens SET {field} = {valor} WHERE id = {id}");
            }
        }
    }
}

