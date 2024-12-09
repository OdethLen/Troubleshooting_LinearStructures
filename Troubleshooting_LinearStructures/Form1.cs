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
                // Calcular el promedio usando LINQ
                double promedio = qualifications.Average();
                // Mostrar el promedio en el Label
                lblAverage.Text = "Promedio: " + promedio.ToString("F2");
            }
            else
            {
                // Si no hay calificaciones, mostrar un mensaje
                MessageBox.Show("No hay calificaciones para calcular el promedio.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQualification.Text, out int calificacion))
            {
                // Agregar la calificación a la lista
                qualifications.Add(calificacion);
                // Limpiar el TextBox para ingresar una nueva calificación
                txtQualification.Clear();
                // Mostrar un mensaje de éxito
                MessageBox.Show("Calificación agregada correctamente.");
            }
            else
            {
                // Si no es un número válido, mostrar un mensaje de error
                MessageBox.Show("Por favor ingresa una calificación válida.");
            }
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
