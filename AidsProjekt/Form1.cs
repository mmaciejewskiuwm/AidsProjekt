using System.Diagnostics;

namespace AidsProjekt
{
    public partial class Form1 : Form
    {
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

        private void btSB_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = BubbleSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z³y format liczby musza byc oddzielone spacja");
            }
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
            int j,temp;
            for(int i = 1; i < tab.Length; i++)
            {
                temp = tab[i];
                j = i - 1;
                while(j>=0 && tab[j]>temp)
                {
                    tab[j+1] = tab[j];
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

            for (int i = 0; i< srodek; i++)
            {
                lewy[i] = tab[i];
            }
            for (int i = srodek; i< tab.Length; i++)
            {
                lewy[i-srodek] = tab[i];
            }
            MergeSort(lewy);
            MergeSort(prawy);
            return Merge(lewy, prawy);


        }
        int[] Merge(int[] lewy,int[] prawy)
        {
            int[] tab = new int[lewy.Length+prawy.Length];
            int i = 0; int j = 0; int k = 0;
            while (i < lewy.Length && j < prawy.Length)
            {
                if (lewy[i] <= prawy[j])
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

        private void tbxWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCzas_Click(object sender, EventArgs e)
        {

        }

        private void btSS_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = SelectionSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z³y format liczby musza byc oddzielone spacja");
            }

        }

        private void btSI_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw = Stopwatch.StartNew();
                int[] SortedList = InsertionSort(Convert(tbxLiczba.Text));
                sw.Stop();
                tbxWynik.Text = ConvertIntToString(SortedList);
                lbCzas.Text = sw.Elapsed.TotalSeconds.ToString() + " sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("z³y format liczby musza byc oddzielone spacja");
            }

        }

        private void btSM_Click(object sender, EventArgs e)
        {

        }

        private void btSQ_Click(object sender, EventArgs e)
        {

        }
    }
}