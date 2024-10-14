namespace TASKOS3V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateClass c1 = new CreateClass(namebox.Text, contentbox.Text);
            c1.createfile();
            MessageBox.Show("File is created");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateClass c2 = new CreateClass(namebox.Text, contentbox.Text);
            c2.writenfile(contentbox.Text);
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            CreateClass c3 = new CreateClass(namebox.Text, contentbox.Text);
            c3.readfile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateClass c4 = new CreateClass(namebox.Text, contentbox.Text);
            c4.deletefile();

        }
    }
}