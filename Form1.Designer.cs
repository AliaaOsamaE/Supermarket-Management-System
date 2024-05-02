
namespace SupermarketManagementSystem
{
    partial class FinalizePaymentForm
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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.DelProductBtn = new System.Windows.Forms.Button();
            this.CalcTotalBtn = new System.Windows.Forms.Button();
            this.FinalizeBtn = new System.Windows.Forms.Button();
            this.CatergoriesComboBox = new System.Windows.Forms.ComboBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.TransactionData = new System.Windows.Forms.DataGridView();
            this.FinWithPointsRBtn = new System.Windows.Forms.RadioButton();
            this.FinWithoutPointsRBtn = new System.Windows.Forms.RadioButton();
            this.PaymentChoiceGBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPriceWithPointsTestBox = new System.Windows.Forms.TextBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PreviousPointsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).BeginInit();
            this.PaymentChoiceGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(40, 212);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(153, 36);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // DelProductBtn
            // 
            this.DelProductBtn.Location = new System.Drawing.Point(40, 254);
            this.DelProductBtn.Name = "DelProductBtn";
            this.DelProductBtn.Size = new System.Drawing.Size(153, 36);
            this.DelProductBtn.TabIndex = 1;
            this.DelProductBtn.Text = "Delete Product";
            this.DelProductBtn.UseVisualStyleBackColor = true;
            this.DelProductBtn.Click += new System.EventHandler(this.DelProductBtn_Click);
            // 
            // CalcTotalBtn
            // 
            this.CalcTotalBtn.Location = new System.Drawing.Point(821, 551);
            this.CalcTotalBtn.Name = "CalcTotalBtn";
            this.CalcTotalBtn.Size = new System.Drawing.Size(153, 36);
            this.CalcTotalBtn.TabIndex = 2;
            this.CalcTotalBtn.Text = "Calculate Total";
            this.CalcTotalBtn.UseVisualStyleBackColor = true;
            this.CalcTotalBtn.Click += new System.EventHandler(this.CalcTotalBtn_Click);
            // 
            // FinalizeBtn
            // 
            this.FinalizeBtn.Location = new System.Drawing.Point(37, 551);
            this.FinalizeBtn.Name = "FinalizeBtn";
            this.FinalizeBtn.Size = new System.Drawing.Size(153, 36);
            this.FinalizeBtn.TabIndex = 3;
            this.FinalizeBtn.Text = "Finalize Payment";
            this.FinalizeBtn.UseVisualStyleBackColor = true;
            this.FinalizeBtn.Click += new System.EventHandler(this.FinalizeBtn_Click);
            // 
            // CatergoriesComboBox
            // 
            this.CatergoriesComboBox.FormattingEnabled = true;
            this.CatergoriesComboBox.Location = new System.Drawing.Point(40, 46);
            this.CatergoriesComboBox.Name = "CatergoriesComboBox";
            this.CatergoriesComboBox.Size = new System.Drawing.Size(265, 24);
            this.CatergoriesComboBox.TabIndex = 4;
            this.CatergoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CatergoriesComboBox_SelectedIndexChanged);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(40, 112);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(265, 24);
            this.ProductComboBox.TabIndex = 5;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer\'s Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(40, 331);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(232, 22);
            this.PhoneNumberTextBox.TabIndex = 9;
            // 
            // TransactionData
            // 
            this.TransactionData.AllowUserToAddRows = false;
            this.TransactionData.AllowUserToDeleteRows = false;
            this.TransactionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionData.Location = new System.Drawing.Point(563, 26);
            this.TransactionData.Name = "TransactionData";
            this.TransactionData.RowHeadersWidth = 51;
            this.TransactionData.RowTemplate.Height = 24;
            this.TransactionData.Size = new System.Drawing.Size(559, 327);
            this.TransactionData.TabIndex = 10;
            // 
            // FinWithPointsRBtn
            // 
            this.FinWithPointsRBtn.AutoSize = true;
            this.FinWithPointsRBtn.Location = new System.Drawing.Point(27, 36);
            this.FinWithPointsRBtn.Name = "FinWithPointsRBtn";
            this.FinWithPointsRBtn.Size = new System.Drawing.Size(156, 21);
            this.FinWithPointsRBtn.TabIndex = 11;
            this.FinWithPointsRBtn.TabStop = true;
            this.FinWithPointsRBtn.Text = "Use Previous Points";
            this.FinWithPointsRBtn.UseVisualStyleBackColor = true;
            // 
            // FinWithoutPointsRBtn
            // 
            this.FinWithoutPointsRBtn.AutoSize = true;
            this.FinWithoutPointsRBtn.Location = new System.Drawing.Point(27, 79);
            this.FinWithoutPointsRBtn.Name = "FinWithoutPointsRBtn";
            this.FinWithoutPointsRBtn.Size = new System.Drawing.Size(193, 21);
            this.FinWithoutPointsRBtn.TabIndex = 12;
            this.FinWithoutPointsRBtn.TabStop = true;
            this.FinWithoutPointsRBtn.Text = "Don\'t Use Previous Points";
            this.FinWithoutPointsRBtn.UseVisualStyleBackColor = true;
            // 
            // PaymentChoiceGBox
            // 
            this.PaymentChoiceGBox.Controls.Add(this.FinWithPointsRBtn);
            this.PaymentChoiceGBox.Controls.Add(this.FinWithoutPointsRBtn);
            this.PaymentChoiceGBox.Location = new System.Drawing.Point(37, 380);
            this.PaymentChoiceGBox.Name = "PaymentChoiceGBox";
            this.PaymentChoiceGBox.Size = new System.Drawing.Size(252, 135);
            this.PaymentChoiceGBox.TabIndex = 13;
            this.PaymentChoiceGBox.TabStop = false;
            this.PaymentChoiceGBox.Text = "Choose Payment ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quatity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Location = new System.Drawing.Point(40, 172);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(265, 24);
            this.QuantityComboBox.TabIndex = 16;
            this.QuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Payment With Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Payment Without Points";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TotalPriceWithPointsTestBox
            // 
            this.TotalPriceWithPointsTestBox.Location = new System.Drawing.Point(821, 380);
            this.TotalPriceWithPointsTestBox.Name = "TotalPriceWithPointsTestBox";
            this.TotalPriceWithPointsTestBox.Size = new System.Drawing.Size(232, 22);
            this.TotalPriceWithPointsTestBox.TabIndex = 20;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(821, 458);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(232, 22);
            this.TotalPriceTextBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Previous Customer Points";
            // 
            // PreviousPointsTextBox
            // 
            this.PreviousPointsTextBox.Location = new System.Drawing.Point(337, 331);
            this.PreviousPointsTextBox.Name = "PreviousPointsTextBox";
            this.PreviousPointsTextBox.Size = new System.Drawing.Size(179, 22);
            this.PreviousPointsTextBox.TabIndex = 23;
            // 
            // FinalizePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1201, 617);
            this.Controls.Add(this.PreviousPointsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.TotalPriceWithPointsTestBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentChoiceGBox);
            this.Controls.Add(this.TransactionData);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.CatergoriesComboBox);
            this.Controls.Add(this.FinalizeBtn);
            this.Controls.Add(this.CalcTotalBtn);
            this.Controls.Add(this.DelProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Name = "FinalizePaymentForm";
            this.Text = "Finalize Payment";
            this.Load += new System.EventHandler(this.FinalizePaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).EndInit();
            this.PaymentChoiceGBox.ResumeLayout(false);
            this.PaymentChoiceGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button DelProductBtn;
        private System.Windows.Forms.Button CalcTotalBtn;
        private System.Windows.Forms.Button FinalizeBtn;
        private System.Windows.Forms.ComboBox CatergoriesComboBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.DataGridView TransactionData;
        private System.Windows.Forms.RadioButton FinWithPointsRBtn;
        private System.Windows.Forms.RadioButton FinWithoutPointsRBtn;
        private System.Windows.Forms.GroupBox PaymentChoiceGBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalPriceWithPointsTestBox;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PreviousPointsTextBox;
    }
}

