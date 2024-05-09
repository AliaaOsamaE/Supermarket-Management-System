namespace WindowsFormsApplication1
{
    partial class Welcome_form
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
            this.Sign_Up_Button = new System.Windows.Forms.Button();
            this.Sign_in_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(55, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Supermarket Managment System";
            // 
            // Sign_Up_Button
            // 
            this.Sign_Up_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Button.Location = new System.Drawing.Point(61, 279);
            this.Sign_Up_Button.Name = "Sign_Up_Button";
            this.Sign_Up_Button.Size = new System.Drawing.Size(265, 70);
            this.Sign_Up_Button.TabIndex = 1;
            this.Sign_Up_Button.Text = "Sign Up";
            this.Sign_Up_Button.UseVisualStyleBackColor = true;
            this.Sign_Up_Button.Click += new System.EventHandler(this.Sign_Up_Button_Click);
            // 
            // Sign_in_Button
            // 
            this.Sign_in_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_in_Button.Location = new System.Drawing.Point(512, 279);
            this.Sign_in_Button.Name = "Sign_in_Button";
            this.Sign_in_Button.Size = new System.Drawing.Size(263, 70);
            this.Sign_in_Button.TabIndex = 2;
            this.Sign_in_Button.Text = "Sign In";
            this.Sign_in_Button.UseVisualStyleBackColor = true;
            this.Sign_in_Button.Click += new System.EventHandler(this.Sign_in_Button_Click);
            // 
            // Welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 534);
            this.Controls.Add(this.Sign_in_Button);
            this.Controls.Add(this.Sign_Up_Button);
            this.Controls.Add(this.label1);
            this.Name = "Welcome_form";
            this.Text = "Welcome_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sign_Up_Button;
        private System.Windows.Forms.Button Sign_in_Button;
    }
}