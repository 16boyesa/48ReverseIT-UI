using System;using System.Windows.Forms;
namespace _48ReverseIT_UI {
    public partial class FrmReverse : Form {
        public FrmReverse() {
            InitializeComponent();  }

        public void tbxInput_TextChanged(object sender, EventArgs e) { tbxOutput.Text = "";
            for (int i = tbxInput.Text.Length - 1; i >= 0; i--) {
                tbxOutput.Text += tbxInput.Text.Substring(i, 1); } 
            if (tbxInput.Text == tbxOutput.Text && tbxInput.Text != "") { lblPaliOut.Text = "True"; }
            else { lblPaliOut.Text = "False"; } } } }