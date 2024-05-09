namespace WindowsFormsApplication1
{
    partial class Sign_Up_Form
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
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.RePassword_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Job_Role_ComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Button.Location = new System.Drawing.Point(83, 445);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(152, 61);
            this.Confirm_Button.TabIndex = 1;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.Location = new System.Drawing.Point(198, 161);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.Size = new System.Drawing.Size(286, 20);
            this.Name_Text_Box.TabIndex = 3;
            this.Name_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Text_Box_KeyPress);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(12, 208);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(100, 24);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(198, 208);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(286, 20);
            this.Password_TextBox.TabIndex = 6;
            // 
            // RePassword_TextBox
            // 
            this.RePassword_TextBox.Location = new System.Drawing.Point(198, 257);
            this.RePassword_TextBox.Name = "RePassword_TextBox";
            this.RePassword_TextBox.Size = new System.Drawing.Size(286, 20);
            this.RePassword_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Job Role";
            // 
            // Job_Role_ComboBox
            // 
            this.Job_Role_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Job_Role_ComboBox.FormattingEnabled = true;
            this.Job_Role_ComboBox.Location = new System.Drawing.Point(198, 313);
            this.Job_Role_ComboBox.Name = "Job_Role_ComboBox";
            this.Job_Role_ComboBox.Size = new System.Drawing.Size(286, 21);
            this.Job_Role_ComboBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(517, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 61);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sign_Up_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Job_Role_ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RePassword_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Name_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.label1);
            this.Name = "Sign_Up_Form";
            this.Text = "Sign_Up_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sign_Up_Form_FormClosing);
            this.Load += new System.EventHandler(this.Sign_Up_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_Text_Box;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox RePassword_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Job_Role_ComboBox;
        private System.Windows.Forms.Button button3;
    }
}