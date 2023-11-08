using System.Diagnostics;

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
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
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
            }
            return tab;
        }
        int[] MergeSort(int[] tab)
        {
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
        int[] QuickSort(int[] tab, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int pivot = Partition(tab, lewy, prawy);

                QuickSort(tab, lewy, pivot - 1);
                QuickSort(tab, pivot + 1, prawy);
            }
            return tab;
        }

        int Partition(int[] tab, int lewy, int prawy)
        {
            int pivot = tab[prawy];
            int i = lewy - 1;

            for (int j = lewy; j < prawy; j++)
            {
                if (tab[j] <= pivot)
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
                if (GlobalList.Length == 0) MessageBox.Show("lista nie moze byc pusta");
                else
                {
                    lbCzas.Text = "-";
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = BubbleSort(GlobalList);
                    sw.Stop();
                    lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
                }
            }
            else
            {
                try
                {
                    lbCzas.Text = "-";
                    Stopwatch sw = new Stopwatch();
                    sw = Stopwatch.StartNew();
                    int[] SortedList = BubbleSort(Convert(tbxLiczba.Text));
                    sw.Stop();
                    tbxWynik.Text = ConvertIntToString(SortedList);
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
            try
            {
                lbCzas.Text = "-";
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = SelectionSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
            }

        }

        private void btSI_Click(object sender, EventArgs e)
        {
            try
            {
                lbCzas.Text = "-";
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = InsertionSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
            }

        }

        private void btSM_Click(object sender, EventArgs e)
        {
            try
            {
                lbCzas.Text = "-";
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = MergeSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
            }

        }

        private void btSQ_Click(object sender, EventArgs e)
        {
            try
            {
                lbCzas.Text = "-";
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = QuickSort(Convert(tbxLiczba.Text), 0, Convert(tbxLiczba.Text).Length - 1);
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z造 format liczby musza byc oddzielone spacja");
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
                lbNapisPrawa.ForeColor = Color.Black;
                lbNapisLewa.ForeColor = Color.Gray;
            }
            else
            {
                lbNapisLewa.ForeColor = Color.Black;
                lbNapisPrawa.ForeColor = Color.Gray;
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
                GlobalList = new int[(int)nudDlugosc.Value];

                Random rnd = new Random();
                for (int i = 0; i < GlobalList.Length; i++)
                {
                    GlobalList[i] = rnd.Next(0, 1001);
                }
                isgenerated = true;
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
        }
    }
}