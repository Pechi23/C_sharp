using System.Security.AccessControl;
using System.Security.Cryptography.Xml;

namespace laborator_11_18
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        private static int X = GenereazaNrDe4CifreDistincte();
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Se da un nr de 4 cifre,distincte
        X nu este vizibil utilizatorului
        construiti vizual o metoda de introducere succesiv a unor numere de 4 cifre distincte
        la fiecare introducere se afiseaza 2 valori C si B cu urmatoarea semnificatie
        C - numarul de cifre identice pe pozitii identice dintre y1 si X
        P - numarul de cifre identice pe pozitii diferite dintre y1 si X
        aplicatia se incheie cand utilizatorul introduce un nr a carui rezultat este 4C

        prb mai complicata:
        pt o secventa de numere si rezultate, construiti un mecanism pt care gasiti cel mai repede numarul X
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Y = int.Parse(textBox1.Text);

            int c = 0, p = 0;
            GetCP(X,Y,ref c,ref p);

            /*
            int firstGuess = GenereazaNrDe4CifreDistincte();
            while(label2.Text.CompareTo(Convert.ToString(X))!=0)
            {              
                
            }
            */
            listBox1.Items.Add($"{X} {Y} c:{c} p:{p}");
        }

        private static void GetCP(int X,int Y,ref int c,ref int p)
        {
            c = p = 0;
            int[] x = new int[4];
            int[] y = new int[4];
            GetCifre(X, ref x[0], ref x[1], ref x[2], ref x[3]);
            GetCifre(Y, ref y[0], ref y[1], ref y[2], ref y[3]);
            int i = 0;
            while (i < 4)
            {
                if (x[i] == y[i])
                    c++;
                int[] frX = GetFr(X);
                int[] frY = GetFr(Y);
                if (x[i] != y[i] && frY[x[i]] == 1)
                    p++;
                i++;
            }
        }

        private static int[] GetFr(int x)
        {
            int[] fr = new int[10];
            while(x>0)
            {
                fr[x%10]++;
                x /= 10;
            }
            return fr;
        }

        private static void GetCifre(int X,ref int x1, ref int x2, ref int x3, ref int x4)
        {
            x1 = X / 1000;
            x2 = X / 100 % 10;
            x3 = X / 10 % 10;
            x4 = X % 10;
        }

        private static int GenereazaNrDe4CifreDistincte()
        {
            int rez = rnd.Next(1234,9878);
            int[] fr = new int[10];
            int aux = rez;
            while(aux>0)
            {
                fr[aux % 10]++;
                aux /= 10;
            }
            for (int i = 0; i < 10; i++)
                if (fr[i] > 1)
                    return GenereazaNrDe4CifreDistincte();

            return rez;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}