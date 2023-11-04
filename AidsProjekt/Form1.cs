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
            for(int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
    }
}