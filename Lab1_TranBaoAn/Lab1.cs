namespace Lab1_TranBaoAn
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            new Bai1().ShowDialog();
            this.Hide();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            new Bai2().ShowDialog();
            this.Hide();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            new Bai3().ShowDialog();
            this.Hide();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            new Bai4().ShowDialog();
            this.Hide();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            new Bai5().ShowDialog();
            this.Hide();

        }
    }
}
