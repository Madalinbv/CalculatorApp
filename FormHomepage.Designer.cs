namespace CalculatorApp
{
    partial class FormHomepage
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
            this.ButtonCalculatorForm = new System.Windows.Forms.Button();
            this.ButtonAboutForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCalculatorForm
            // 
            this.ButtonCalculatorForm.Location = new System.Drawing.Point(189, 83);
            this.ButtonCalculatorForm.Name = "ButtonCalculatorForm";
            this.ButtonCalculatorForm.Size = new System.Drawing.Size(112, 65);
            this.ButtonCalculatorForm.TabIndex = 0;
            this.ButtonCalculatorForm.Text = "Calculator";
            this.ButtonCalculatorForm.UseVisualStyleBackColor = true;
            this.ButtonCalculatorForm.Click += new System.EventHandler(this.ButtonCalculatorForm_Click);
            // 
            // ButtonAboutForm
            // 
            this.ButtonAboutForm.Location = new System.Drawing.Point(189, 170);
            this.ButtonAboutForm.Name = "ButtonAboutForm";
            this.ButtonAboutForm.Size = new System.Drawing.Size(112, 65);
            this.ButtonAboutForm.TabIndex = 1;
            this.ButtonAboutForm.Text = "About";
            this.ButtonAboutForm.UseVisualStyleBackColor = true;
            this.ButtonAboutForm.Click += new System.EventHandler(this.ButtonAboutForm_Click);
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAboutForm);
            this.Controls.Add(this.ButtonCalculatorForm);
            this.Name = "FormHomepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculatorForm;
        private System.Windows.Forms.Button ButtonAboutForm;
    }
}

