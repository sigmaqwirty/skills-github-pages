namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1?.Clear();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }
    }
}
