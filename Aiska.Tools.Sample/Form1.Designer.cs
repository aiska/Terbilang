namespace Aiska.Tools.Sample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Angka";
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(121, 27);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(256, 20);
            this.InputTxt.TabIndex = 1;
            this.InputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyUp);
            // 
            // ResultTxt
            // 
            this.ResultTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultTxt.Location = new System.Drawing.Point(12, 53);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.ReadOnly = true;
            this.ResultTxt.Size = new System.Drawing.Size(365, 85);
            this.ResultTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 146);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.TextBox ResultTxt;
    }
}

