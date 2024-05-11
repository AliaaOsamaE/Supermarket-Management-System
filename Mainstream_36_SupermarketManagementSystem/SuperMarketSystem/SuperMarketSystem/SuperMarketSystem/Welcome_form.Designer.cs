
namespace SuperMarketSystem
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
            this.Sign_in_Button = new System.Windows.Forms.Button();
            this.Sign_Up_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sign_in_Button
            // 
            this.Sign_in_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_in_Button.Location = new System.Drawing.Point(696, 363);
            this.Sign_in_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Sign_in_Button.Name = "Sign_in_Button";
            this.Sign_in_Button.Size = new System.Drawing.Size(351, 86);
            this.Sign_in_Button.TabIndex = 5;
            this.Sign_in_Button.Text = "Sign In";
            this.Sign_in_Button.UseVisualStyleBackColor = true;
            this.Sign_in_Button.Click += new System.EventHandler(this.Sign_in_Button_Click);
            // 
            // Sign_Up_Button
            // 
            this.Sign_Up_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Button.Location = new System.Drawing.Point(94, 363);
            this.Sign_Up_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Sign_Up_Button.Name = "Sign_Up_Button";
            this.Sign_Up_Button.Size = new System.Drawing.Size(353, 86);
            this.Sign_Up_Button.TabIndex = 4;
            this.Sign_Up_Button.Text = "Sign Up";
            this.Sign_Up_Button.UseVisualStyleBackColor = true;
            this.Sign_Up_Button.Click += new System.EventHandler(this.Sign_Up_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(86, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Supermarket Managment System";
            // 
            // Welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 639);
            this.Controls.Add(this.Sign_in_Button);
            this.Controls.Add(this.Sign_Up_Button);
            this.Controls.Add(this.label1);
            this.Name = "Welcome_form";
            this.Text = "Welcome_form";
            this.Load += new System.EventHandler(this.Welcome_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_in_Button;
        private System.Windows.Forms.Button Sign_Up_Button;
        private System.Windows.Forms.Label label1;
    }
}