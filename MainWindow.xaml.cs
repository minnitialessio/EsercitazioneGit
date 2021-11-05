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

namespace EsercitazioneGit
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cd = new CD("Doom", "Nayt");
            Brano brano = new Brano("Doom", "Nayt", 180);
            lbx_brani.Items.Add(brano);
            cd.AggiungiBrano(brano);

            MessageBox.Show("Brani:\n" + cd);

            lbl_durataTot.Content = cd.DurataTot;

        }

        CD cd;

        private void btn_aggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano b = new Brano(tbx_titolo.Text, tbx_autore.Text, int.Parse(tbx_brano.Text));
                cd.AggiungiBrano(b);

                lbx_brani.Items.Add(b);

                lbl_durataTot.Content = cd.DurataTot;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btn_tempoBranoMinoreDi_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                if (lbx_brani.SelectedItem == null) 
                {
                    throw new Exception("Seleziona un brano");
                }

                Brano brano = lbx_brani.SelectedItem as Brano;

                if (brano.ShortSong(tbx_tempoBranoMinoreDi.Text) == true) 
                {
                    MessageBox.Show("La durata del brano è maggiore");
                }
                else
                {
                    MessageBox.Show("La durata del brano è minore o uguale");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
    }
}
