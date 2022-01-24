namespace _48ReverseIT_UI
{
    partial class FrmReverse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.lblPali = new System.Windows.Forms.Label();
            this.lblPaliOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxInput.Location = new System.Drawing.Point(12, 12);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(129, 20);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxOutput.Location = new System.Drawing.Point(12, 38);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(129, 20);
            this.tbxOutput.TabIndex = 1;
            this.tbxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPali
            // 
            this.lblPali.AutoSize = true;
            this.lblPali.Location = new System.Drawing.Point(23, 70);
            this.lblPali.Name = "lblPali";
            this.lblPali.Size = new System.Drawing.Size(62, 13);
            this.lblPali.TabIndex = 2;
            this.lblPali.Text = "Palindrome:";
            // 
            // lblPaliOut
            // 
            this.lblPaliOut.AutoSize = true;
            this.lblPaliOut.Location = new System.Drawing.Point(100, 70);
            this.lblPaliOut.Name = "lblPaliOut";
            this.lblPaliOut.Size = new System.Drawing.Size(32, 13);
            this.lblPaliOut.TabIndex = 3;
            this.lblPaliOut.Text = "False";
            // 
            // FrmReverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(153, 93);
            this.Controls.Add(this.lblPaliOut);
            this.Controls.Add(this.lblPali);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxInput);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximumSize = new System.Drawing.Size(169, 132);
            this.MinimumSize = new System.Drawing.Size(169, 132);
            this.Name = "FrmReverse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "48 - Reverse IT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label lblPali;
        private System.Windows.Forms.Label lblPaliOut;
    }
}

