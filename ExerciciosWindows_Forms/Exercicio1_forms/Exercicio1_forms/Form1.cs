namespace Exercicio1_forms
{
    public partial class frmExercicio1 : Form
    {
      
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionaNome(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adicionar nome?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult)
            {
                          
            }
           
        }
    }
}