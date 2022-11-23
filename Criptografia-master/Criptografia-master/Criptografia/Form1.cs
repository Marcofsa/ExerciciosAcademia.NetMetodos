namespace Criptografia
{
    
    public partial class Form1 : Form
    {
        string dadoCripto;
        string dadoCripto2;
        string msg, msg2, chave;
        string msgDescripto, msgDescripto2;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblCripto.Text = "";
            lblChavePublica.Text = "";
            Assimetrica a = new Assimetrica();
            msg = txbFrase.Text;
            dadoCripto = a.encrypt(msg);
            //lblChavePublica.Text = a.getPublicKey();
            MessageBox.Show(a.getPublicKey());
            lblCripto.Text = dadoCripto;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDescripto.Text = "";
            Simetrica s = new Simetrica();
            chave = txbChave.Text;
            msgDescripto = s.DecryptData(dadoCripto, chave);
            lblDescripto.Text = msgDescripto;
           


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCripto.Text = "";
            Simetrica s = new Simetrica();
            msg = txbFrase.Text;
            //dadoCripto = s.EncryptData(msg, "atoS");
            chave = txbChave.Text;
            dadoCripto = s.EncryptData(msg, chave);
            lblCripto.Text = dadoCripto;

            

            /*AES significa Advanced Encryption Standard e foi desenvolvido para atualizar o algoritmo DES original. 
            Entre alguns dos aplicativos mais comuns de algoritmo AES incluem-se aplicativos de mensagens, como o Signal ou WhatsApp, e
            o programa de compactação de arquivos WinZip.*/
            /*
            Simetrica s = new Simetrica();
            Console.WriteLine("Utilizando chaves simétricas");
            Console.WriteLine("Algoritmo AES");
            Console.WriteLine("Digite uma mensagem para ser critografada: ");
            msg = Console.ReadLine();
            Console.WriteLine("Digite outra mensagem para ser critografada: ");
            msg2 = Console.ReadLine();
            dadoCripto = s.EncryptData(msg, "atoS");
            Console.WriteLine("Mensagem critografada: "+dadoCripto);
            dadoCripto2 = s.EncryptData(msg2, "UFN");
            Console.WriteLine("Mensagem critografada: " + dadoCripto2);
            
            msgDescripto = s.DecryptData(dadoCripto, "atoS");
            Console.WriteLine("Msg 1 descripto = "+msgDescripto);
            msgDescripto2 = s.DecryptData(dadoCripto2, "UFN");
            Console.WriteLine("Msg 2 descripto = " + msgDescripto2);


            Console.WriteLine("Utilizando Chaves assimétricas");
            Assimetrica a = new Assimetrica();

            Console.WriteLine("Digite uma mensagem para ser critografada: ");
            msg = Console.ReadLine();

            Console.WriteLine("Digite outra mensagem para ser critografada: ");
            msg2 = Console.ReadLine();

            // Console.WriteLine(a.getPublicKey());

            dadoCripto = a.encrypt(msg);
            Console.WriteLine("Mensagem critpo 1 " + dadoCripto);

            dadoCripto2 = a.encrypt(msg2);
            Console.WriteLine("Mensagem critpo 2 " + dadoCripto2);

            msgDescripto = a.decrypt(dadoCripto);
            Console.WriteLine("Mensagem descriptografada: " + msgDescripto);

            msgDescripto2 = a.decrypt(dadoCripto2);
            Console.WriteLine("Mensagem 2 descriptografada: " + msgDescripto2);*/


        }
    }
}