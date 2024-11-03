namespace AiSD_cwiczenia_2
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }
        List lista1 = new List();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        int liczba;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String tekst = textBox1.Text;
            liczba = int.Parse(tekst);
        }


        private void AddFirst(object sender, EventArgs e)
        {
            lista1.AddFirst(liczba);
            UpdateLabel();
        }

        private void AddLast(object sender, EventArgs e)
        {
            lista1.AddLast(liczba);
            UpdateLabel();
        }

        private void RemoveFirst(object sender, EventArgs e)
        {
            lista1.deleteFirst();
            UpdateLabel();
        }

        private void RemoveLast(object sender, EventArgs e)
        {
            lista1.deleteLast();
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            label1.Text = lista1.PrintList();
            UpdateCount();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {         
        }
        private void UpdateCount()
        {
            label3.Text = lista1.count.ToString();
        }
    }
}