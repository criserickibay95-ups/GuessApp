using System.Text;

namespace GuessApp
{
    public partial class Form1 : Form
    {
		string correctWord = "guitar";
		public Form1()
        {
            InitializeComponent();

		StringBuilder strGuess = new StringBuilder();

			for (int i = 0; i < correctWord.Length; i++)
			{
				if (i == 0 || i == correctWord.Length - 1)
					strGuess.Append(correctWord[i]);
				else
					strGuess.Append('?');
			}
	lblWord.Text = strGuess.ToString();
        }
private void btnGuess_Click(object sender, EventArgs e)
{
	string guess = txtGuess.Text.Trim().ToLower();

	if (guess == "")
	{
		MessageBox.Show("Please enter a guess.");
		return;
	}
			if (guess == correctWord)
			{
				lblWord.Text = correctWord;
				MessageBox.Show("Yayy! you won!");
			}
			else
			{
				MessageBox.Show("Wrong guess! Try again.");
				listWrong.Items.Add(guess);
			}
	txtGuess.Clear();
	txtGuess.Focus();
}
}
}



