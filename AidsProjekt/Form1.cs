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

        private void tbxWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCzas_Click(object sender, EventArgs e)
        {

        }

        private void btSS_Click(object sender, EventArgs e)
        {

        }

        private void btSI_Click(object sender, EventArgs e)
        {

        }

        private void btSM_Click(object sender, EventArgs e)
        {

        }

        private void btSQ_Click(object sender, EventArgs e)
        {

        }
    }
}