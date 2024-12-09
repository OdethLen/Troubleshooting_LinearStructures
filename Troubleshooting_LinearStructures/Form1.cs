namespace Troubleshooting_LinearStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            lblWord.Text= ("The reversed word is: " + reversedWord);
        }
    }
}
