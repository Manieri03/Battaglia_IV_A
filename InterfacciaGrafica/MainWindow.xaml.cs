using LibreriaGioco;
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

namespace InterfacciaGrafica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Personaggio> Personaggi = new List<Personaggio>();
        Razza[] Razze = new Razza[] { new Uomo(), new Elfo(), new Mago(), new Troll(), new Orco(), new Stregone() };

        private void CmbRazzaAtt_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Razza r in Razze)
                cmbRazzaAtt.Items.Add($"{r.GetType().Name} [{r.schieramento}]");
        }

        private void CmbRazzaDif_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Razza r in Razze)
                cmbRazzaDif.Items.Add($"{r.GetType().Name} [{r.schieramento}]");
        }

        private void BtnCreaAtt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNomeAtt.Text == "")
                {
                    throw new Exception("Inserisci un nome per il tuo personaggio");
                }
                if (cmbRazzaAtt.SelectedIndex == -1)
                {
                    throw new Exception("Inserisci una razza per il tuo personaggio");
                }

                int index = cmbRazzaAtt.SelectedIndex;
                Personaggio p = new Personaggio(txtNomeAtt.Text, Razze[index]);

                Personaggi.Add(p);
                lblOutput.Content += "Attaccante creato! ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreaDif_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNomeDif.Text == "")
                {
                    throw new Exception("Inserisci un nome per il tuo personaggio");
                }
                if (cmbRazzaDif.SelectedIndex == -1)
                {
                    throw new Exception("Inserisci una razza per il tuo personaggio");
                }

                int index = cmbRazzaDif.SelectedIndex;
                Personaggio p = new Personaggio(txtNomeDif.Text, Razze[index]);

                Personaggi.Add(p);
                
                lblOutput.Content += "- Difensore creato!            \n";


                //reset
                txtNomeAtt.Text = "";
                cmbRazzaAtt.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Personaggio att = Personaggi[cmbRazzaAtt.SelectedIndex];
                Personaggio dif = Personaggi[cmbRazzaDif.SelectedIndex];
                bool sfida = att.Attacca(dif);

                if (sfida == true)
                {
                    lblOutput.Content += ($"{att} ha vinto la battaglia \n Resoconto Personaggi: {att.Nome}:{att.Vita},{att.Exp}; {dif.Nome}:{dif.Vita},{dif.Exp}");
                }
                else
                {
                    lblOutput.Content += ($"{dif} ha vinto la battaglia \n Resoconto Personaggi: {att.Nome}:{att.Vita},{att.Exp}; {dif.Nome}:{dif.Vita},{dif.Exp}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
