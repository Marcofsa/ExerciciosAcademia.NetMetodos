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

        private void btnClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja adicionar o nome a lista?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }
    }
}