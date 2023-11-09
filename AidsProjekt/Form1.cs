using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AidsProjekt
{
    public partial class Form1 : Form
    {
        int[] GlobalList = new int[0];
        bool isgenerated = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void tbxLiczba_TextChanged(object sender, EventArgs e)
        {

        }
        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        string ConvertIntToString(int[] tab)
        {
            string napis = "";
            for (int i = 0; i < tab.Length; i++)
            {
                napis += tab[i].ToString();
                napis += " ";
            }
            return napis;
        }

        int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
                pbSorty.PerformStep();
            }
            return tab;

        }
        int[] SelectionSort(int[] tab)
        {
            int k;
            for (int i = 0; i < tab.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[k])
                    {
                        int temp = tab[j];
                        tab[j] = tab[k];
                        tab[k] = temp;
                    }
                }
             pbSorty.PerformStep();
            }
            return tab;
        }
        int[] InsertionSort(int[] tab)
        {
            int j, temp;
            for (int i = 1; i < tab.Length; i++)
            {
                temp = tab[i];
                j = i - 1;
                while (j >= 0 && tab[j] > temp)
                {
                    tab[j + 1] = tab[j];
                    --j;
                }
                tab[j + 1] = temp;
                pbSorty.PerformStep();
            }
            return tab;
        }
        int[] MergeSort(int[] tab)
        {
            pbSorty.PerformStep();
            if (tab.Length <= 1) return tab;
            int srodek = tab.Length / 2;
            int[] lewy = new int[srodek];
            int[] prawy = new int[tab.Length - srodek];

            for (int i = 0; i < srodek; i++)
            {
                lewy[i] = tab[i];
            }
            for (int i = srodek; i < tab.Length; i++)
            {
                prawy[i - srodek] = tab[i];
            }
            lewy = MergeSort(lewy);
            prawy = MergeSort(prawy);
            return Merge(lewy, prawy);


        }
        int[] Merge(int[] lewy, int[] prawy)
        {
            int[] tab = new int[lewy.Length + prawy.Length];
            int i = 0, j = 0, k = 0;
            while (i < lewy.Length && j < prawy.Length)
            {
                if (lewy[i] < prawy[j])
                    tab[k++] = lewy[i++];
                else
                    tab[k++] = prawy[j++];
            }

            while (i < lewy.Length)
                tab[k++] = lewy[i++];

            while (j < prawy.Length)
                tab[k++] = prawy[j++];
            return tab;
        }

        int Podzial(int[] tab, int lewy, int prawy)
        {
            int bufor = tab[prawy];
            int i = lewy - 1;

            for (int j = lewy; j < prawy; j++)
            {
                if (tab[j] <= bufor)
                {
                    i++;
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                }
            }

            int temp2 = tab[i + 1];
            tab[i + 1] = tab[prawy];
            tab[prawy] = temp2;

            return i + 1;
        }
        int[] QuickSort(int[] tablica, int lewyIndeks, int prawyIndeks)
        {
            if(pbSorty.Value != pbSorty.Maximum - 1)
                pbSorty.PerformStep();
            if (lewyIndeks < prawyIndeks)
            {
                int indeksSrodka = Podzial(tablica, lewyIndeks, prawyIndeks);
                QuickSort(tablica, lewyIndeks, indeksSrodka - 1);
                QuickSort(tablica, indeksSrodka + 1, prawyIndeks);
            }
            return tablica;
        }

        private void tbxWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCzas_Click(object sender, EventArgs e)
        {

        }
        private void btSB_Click(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                if (isgenerated == false) MessageBox.Show("najpierw wygeneruj liste!");
                else
                {
                    lbCzas.Text = "-";
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = GlobalList.Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    GlobalList = BubbleSort(GlobalList);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = Convert(tbxLiczba.Text).Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = BubbleSort(Convert(tbxLiczba.Text));
                    sw.Stop();
                    tbxWynik.Text = ConvertIntToString(SortedList);
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
                }
            }

        }

        private void btSS_Click(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                if (isgenerated == false) MessageBox.Show("najpierw wygeneruj liste!");
                else
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = GlobalList.Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    GlobalList = SelectionSort(GlobalList);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = Convert(tbxLiczba.Text).Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = SelectionSort(Convert(tbxLiczba.Text));
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    tbxWynik.Text = ConvertIntToString(SortedList);
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
                }
            }
        }

        private void btSI_Click(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                if (isgenerated == false) MessageBox.Show("najpierw wygeneruj liste!");
                else
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = GlobalList.Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    GlobalList = InsertionSort(GlobalList);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = Convert(tbxLiczba.Text).Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = InsertionSort(Convert(tbxLiczba.Text));
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    tbxWynik.Text = ConvertIntToString(SortedList);
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
                }
            }
        }

        private void btSM_Click(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                if (isgenerated == false) MessageBox.Show("najpierw wygeneruj liste!");
                else
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = GlobalList.Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    GlobalList = MergeSort(GlobalList);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = Convert(tbxLiczba.Text).Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = MergeSort(Convert(tbxLiczba.Text));
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    tbxWynik.Text = ConvertIntToString(SortedList);
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
                }
            }

        }

        private void btSQ_Click(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                if (isgenerated == false) MessageBox.Show("najpierw wygeneruj liste!");
                else
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = GlobalList.Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    GlobalList = QuickSort(GlobalList, 0, GlobalList.Length - 1);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    pbSorty.Visible = true;
                    pbSorty.Minimum = 1;
                    pbSorty.Maximum = Convert(tbxLiczba.Text).Length;
                    pbSorty.Value = 1;
                    pbSorty.Step = 1;
                    lbCzas.Text = "-";
                    Cursor.Current = Cursors.WaitCursor;
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = QuickSort(Convert(tbxLiczba.Text), 0, Convert(tbxLiczba.Text).Length - 1);
                    sw.Stop();
                    Cursor.Current = Cursors.Default;
                    tbxWynik.Text = ConvertIntToString(SortedList);
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
                }
            }
        }

        //numeric ustawienia
        private void nudDlugosc_ValueChanged(object sender, EventArgs e)
        {
            nudDlugosc.Maximum = 2000000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbPrzelacz_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrzelacz.Checked)
            {
                lbNapisPrawa.ForeColor = Color.Lime;
                lbNapisLewa.ForeColor = Color.Red;
            }
            else
            {
                lbNapisLewa.ForeColor = Color.Lime;
                lbNapisPrawa.ForeColor = Color.Red;
            }
        }
        //Generowanie Listy
        private void btGen_Click(object sender, EventArgs e)
        {
            if ((int)nudDlugosc.Value == 0)
            {
                MessageBox.Show("Lista musi byc dluzsza niz 0");
            }
            else if ((int)nudDlugosc.Value > 2000000)
            {
                MessageBox.Show("Lista ma byc krotsza niz 2mln");
            }
            else
            {
                pbGeneracja.Visible = true;
                pbGeneracja.Minimum = 1;
                if ((int)nudDlugosc.Value == 1)
                    pbGeneracja.Maximum = (int)nudDlugosc.Value + 1;
                else
                    pbGeneracja.Maximum = (int)nudDlugosc.Value;
                pbGeneracja.Value = 1;
                pbGeneracja.Step = 1;
                Cursor.Current = Cursors.WaitCursor;
                GlobalList = new int[(int)nudDlugosc.Value];

                Random rnd = new Random();
                for (int i = 0; i < GlobalList.Length; i++)
                {
                    GlobalList[i] = rnd.Next(0, 1001);
                    pbGeneracja.PerformStep();
                }
                isgenerated = true;
                Cursor.Current = Cursors.Default;
            }

        }
        // tester
        String printuj(int[] lista)
        {
            String print = "";
            for (int i = 0; i < lista.Length; i++)
            {
                print += lista[i].ToString();
                print += " ";
            }
            return print;
        }

        private void btWyswietl_Click(object sender, EventArgs e)
        {
            if (isgenerated)
                MessageBox.Show(printuj(GlobalList));
            else
                MessageBox.Show("Nie wygenerowales listy!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalList = new int[0];
            isgenerated = false;
            pbGeneracja.Value = 1;
            if(chbPrzelacz.Checked)
                pbSorty.Value = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCzyscListy_Click(object sender, EventArgs e)
        {
            tbxLiczba.Clear();
            tbxWynik.Clear();
            pbSorty.Value = 1;
        }

    }
}