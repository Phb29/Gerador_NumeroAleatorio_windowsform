namespace LotoNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            int Inicial= Convert.ToInt32(textBox1.Text);
            int Final= Convert.ToInt32(textBox2.Text);
            int Limite= Convert.ToInt32(textBox3.Text);
            int Sorteado;
            int[] Verificador = new int[100];

            String Resultado = " ";
            for(int i = 0; i < Limite ; i++)
            {

                Inicio: //goto retorna aqui
            Sorteado=Aleatorio.Next(Inicial,Final+1);
                for(int x = 0; x < Limite ; x++)
                {
                    if (Verificador[x] == Sorteado)
                    {
                        goto Inicio;
                    }
                }

                Resultado += " "+Sorteado;
                label4.Text=Resultado;
                Verificador[i] = Sorteado;
            }
        }
    }
}