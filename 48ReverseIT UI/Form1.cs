using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;

namespace _48ReverseIT_UI {
    public partial class FrmReverse : Form {
        public FrmReverse() {
            InitializeComponent(); }


        private void tbxInput_TextChanged(object sender, EventArgs e) { tbxOutput.Text = "";
            for (int i = tbxInput.Text.Length - 1; i >= 0; i--) {
                tbxOutput.Text += tbxInput.Text.Substring(i, 1); } } } }
