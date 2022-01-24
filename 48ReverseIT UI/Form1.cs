using System;using System.Windows.Forms;
namespace _48ReverseIT_UI {
    public partial class FrmReverse : Form {
        public FrmReverse() {
            InitializeComponent();  }                                                                       // Sets up the Form

        public void tbxInput_TextChanged(object sender, EventArgs e) { tbxOutput.Text = "";                 // Resets the Output Text and runs code whenever the Input changes
            for (int i = tbxInput.Text.Length - 1; i >= 0; i--) {                                           // Loops through String
                tbxOutput.Text += tbxInput.Text.Substring(i, 1); }                                          // Reverses String
            if (tbxInput.Text == tbxOutput.Text && tbxInput.Text != "") { lblPaliOut.Text = "True"; }       // Checks for Palindromes
            else { lblPaliOut.Text = "False"; } } } }                                                       // Resets Palindrome Check