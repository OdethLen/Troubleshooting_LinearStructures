namespace Troubleshooting_LinearStructures
{
    public partial class Form1 : Form

    {
        List<int> qualifications;
        public Form1()
        {
            InitializeComponent();
            qualifications = new List<int>();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string number = txtWord.Text;

            if (string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Please enter a word to reverse.");
                return;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in number)
            {
                stack.Push(c);
            }

            string reversedWord = "";
            while (stack.Count > 0)
            {
                reversedWord += stack.Pop();
            }

            lblWord.Text = ("The reversed word is: " + reversedWord);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (qualifications.Count > 0)
            {
                double promedio = qualifications.Average();
                lblAverage.Text = "Average: " + promedio.ToString("F2");
            }
            else
            {
                MessageBox.Show("There are no qualifications for calculating the average.");
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQualification.Text, out int calificacion))
            {
                qualifications.Add(calificacion);
                txtQualification.Clear();
                MessageBox.Show("Qualification added correctly.");
            }
            else
            {
                MessageBox.Show("Please enter a valid qualification.");
            }
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
