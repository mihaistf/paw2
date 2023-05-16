using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPartea1
{
    public partial class MainForm : Form
    {
        private List<Clienti> listaClienti;
        private List<Aparate> listaAparate;
        private double[] vect = new double[100];
        private int nrElem = 0;
        private bool vb = false;
        private int marg = 10;
        private Color culoare = Color.Blue;
        private Graphics gr;

        public MainForm()
        {
            InitializeComponent();
            listaClienti = new List<Clienti>();
            listaAparate = new List<Aparate>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Introduceti numele");
            }
            else if (tbPrenume.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbPrenume, "Introduceti prenumele");
            }
            else if (tbTelefon.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbTelefon, "Introduceti telefonul");
            }
            else if (tbEmail.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbEmail, "Introduceti emailul");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume = tbNume.Text;
                    string prenume = tbPrenume.Text;
                    string telefon = tbTelefon.Text;
                    string adresa = tbAdresa.Text;
                    string email = tbEmail.Text;
                    string denumire = tbDenumire.Text;
                    DateTime dtRez = dtpRezervare.Value;
                    Clienti c = new Clienti(nume, prenume, telefon, adresa, email, dtRez);
                    listaClienti.Add(c);
                    MessageBox.Show("Rezervare adaugata cu succes!");

                    // Salvare datelor în fișier
                    SaveDataToFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Restaurare datelor din fișier la încărcarea formularului
            RestoreDataFromFile();

            cbTimp.Items.Add("1 ora");
            cbTimp.Items.Add("2 ore");
            cbTimp.Items.Add("3 ore");
            cbTimp.Items.Add("4 ore");
            cbTimp.Items.Add("5 ore");
        }

        private void SaveDataToFile()
        {
            string filePath = "data.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Clienti client in listaClienti)
                    {
                        // Salvare datelor în fișier pe linii separate
                        writer.WriteLine($"{client.Nume},{client.Prenume},{client.Telefon},{client.Adresa},{client.Email},{client.DataRezervare}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea datelor: " + ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cbTimp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RestoreDataFromFile()
        {
            string filePath = "data.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Restaurare datelor din fișier și adăugare în lista de clienți
                            string[] data = line.Split(',');
                            if (data.Length >= 6)
                            {
                                string nume = data[0];
                                string prenume = data[1];
                                string telefon = data[2];
                                string adresa = data[3];
                                string email = data[4];
                                DateTime dataRezervare;
                                if (DateTime.TryParse(data[5], out dataRezervare))
                                {
                                    Clienti c = new Clienti(nume, prenume, telefon, adresa, email, dataRezervare);
                                    listaClienti.Add(c);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la restaurarea datelor: " + ex.Message);
            }
        }
        private void salveazaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creează un dialog pentru a permite utilizatorului să aleagă locația și numele fișierului
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
            saveFileDialog.Title = "Salvează date";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Salvare date clienti
                        foreach (Clienti client in listaClienti)
                        {
                            // Salvare datelor clientilor in fisier pe linii separate
                            writer.WriteLine($"{client.Nume},{client.Prenume},{client.Telefon},{client.Adresa},{client.Email},{client.DataRezervare}");
                        }

                        // Salvare date aparate
                        foreach (Aparate aparat in listaAparate)
                        {
                            // Salvare datelor aparatelor in fisier pe linii separate
                            writer.WriteLine($"{aparat.Denumire},{aparat.NrAparate}");
                        }
                    }

                    MessageBox.Show("Datele au fost salvate cu succes în fișier!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvarea datelor: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Introduceți numele");
            }
            else if (tbPrenume.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbPrenume, "Introduceți prenumele");
            }
            else if (tbTelefon.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbTelefon, "Introduceți telefonul");
            }
            else if (tbEmail.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbEmail, "Introduceți emailul");
            }
            else if (tbDenumire.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(tbDenumire, "Introduceți denumirea aparatului");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume = tbNume.Text;
                    string prenume = tbPrenume.Text;
                    string telefon = tbTelefon.Text;
                    string adresa = tbAdresa.Text;
                    string email = tbEmail.Text;
                    DateTime dtRez = dtpRezervare.Value;

                    Clienti client = new Clienti(nume, prenume, telefon, adresa, email, dtRez);
                    listaClienti.Add(client);

                    string denumireAparat = tbDenumire.Text;

                    Aparate aparat = new Aparate(denumireAparat, 0);
                    listaAparate.Add(aparat);

                    MessageBox.Show("Rezervare aparat adăugată cu succes!");

                    // Salvare date în fișiere
                    SaveDataToFile();

                    // Salvare date în fișiere
                    SaveDataToFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void afisareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Clienti client in listaClienti)
            {
                ListViewItem item = new ListViewItem(client.Nume);
                item.SubItems.Add(client.Prenume);
                item.SubItems.Add(client.Telefon);
                item.SubItems.Add(client.Adresa);
                item.SubItems.Add(client.Email);
                item.SubItems.Add(client.DataRezervare.ToString());

                listView1.Items.Add(item);
            }
            listaClienti.Reverse();
        }
               private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserDataFromFile();
            MessageBox.Show("Datele utilizatorilor au fost șterse cu succes!");
        }
        void DeleteUserDataFromFile()
            {
                string filePath = "data.txt";

                try
                {
                    // Șterge conținutul fișierului
                    File.WriteAllText(filePath, string.Empty);

                    MessageBox.Show("Datele utilizatorilor au fost șterse din fișier!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergerea datelor: " + ex.Message);
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            // Creează o instanță a formei cu graficul
            FormGrafic formGrafic = new FormGrafic();

            // Adaugă graficul la formă
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            chart.ChartAreas.Add("area");
            chart.Series.Add("Clienți");
            chart.Series["Clienți"].ChartType = SeriesChartType.Bar;

            // Adaugă date la grafic
            chart.Series["Clienți"].Points.AddXY("Ianuarie", 100);
            chart.Series["Clienți"].Points.AddXY("Februarie", 150);
            chart.Series["Clienți"].Points.AddXY("Martie", 200);
            chart.Series["Clienți"].Points.AddXY("Aprilie", 175);
            chart.Series["Clienți"].Points.AddXY("Mai", 225);
            chart.Series["Clienți"].Points.AddXY("Iunie", 250);
            chart.Series["Clienți"].Points.AddXY("Iulie", 275);
            chart.Series["Clienți"].Points.AddXY("August", 300);
            chart.Series["Clienți"].Points.AddXY("Septembrie", 325);
            chart.Series["Clienți"].Points.AddXY("Octombrie", 150);
            chart.Series["Clienți"].Points.AddXY("Noiembrie", 275);
            chart.Series["Clienți"].Points.AddXY("Decembrie", 300);

            // Inversează orientarea axelor
            chart.ChartAreas[0].AxisX.IsReversed = true;
            chart.ChartAreas[0].AxisY.IsReversed = false;

            // Setează titlul graficului
            chart.Titles.Add("Numărul de clienți pe luni");
            chart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);

            // Adaugă graficul la formular
            formGrafic.Controls.Add(chart);

            // Deschide forma și afișează graficul în ea
            formGrafic.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = "Acesta este un text de exemplu.";
            Font font = new Font("Arial", 12);
            SizeF size = e.Graphics.MeasureString(text, font);
            PointF location = new PointF((e.PageBounds.Width - size.Width) / 2, (e.PageBounds.Height - size.Height) / 2);
            e.Graphics.DrawString(text, font, Brushes.Black, location);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crează o instanță a clasei PrintDocument
            PrintDocument printDoc = new PrintDocument();

            // Adaugă evenimentul PrintPage
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Deschide dialogul de configurare a imprimantei
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Tipărește documentul
                printDoc.Print();
            }
        }


        //private void button3_Click(object sender, EventArgs e)
        //{
        //    FormularNou formularNou = new FormularNou();
        //    formularNou.Show();
        //}


    }

}

    



