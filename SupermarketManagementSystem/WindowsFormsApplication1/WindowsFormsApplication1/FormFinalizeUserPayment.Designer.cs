namespace WindowsFormsApplication1
{
    partial class Finilizing_customer_payment_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.TransactionData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PayWithPointRadioButton = new System.Windows.Forms.RadioButton();
            this.PayWithoutPointsRadioButton = new System.Windows.Forms.RadioButton();
            this.FinishButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayTotalButton = new System.Windows.Forms.Button();
            this.TotalPaymentWithPointsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPaymentWithoutPointsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.CatergoriesComboBox = new System.Windows.Forms.ComboBox();
            this.Customer_previous_points_textbox = new System.Windows.Forms.TextBox();
            this.Customer_previous_points = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Products";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(28, 124);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(126, 32);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(29, 180);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(125, 32);
            this.DeleteProductButton.TabIndex = 5;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // TransactionData
            // 
            this.TransactionData.AllowUserToAddRows = false;
            this.TransactionData.AllowUserToDeleteRows = false;
            this.TransactionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionData.Location = new System.Drawing.Point(572, 9);
            this.TransactionData.MultiSelect = false;
            this.TransactionData.Name = "TransactionData";
            this.TransactionData.ReadOnly = true;
            this.TransactionData.Size = new System.Drawing.Size(404, 306);
            this.TransactionData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Phone Number";
            // 
            // CustomerPhoneNumberTextBox
            // 
            this.CustomerPhoneNumberTextBox.Location = new System.Drawing.Point(300, 237);
            this.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox";
            this.CustomerPhoneNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.CustomerPhoneNumberTextBox.TabIndex = 8;
            this.CustomerPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerPhoneNumberTextBox_KeyPress);
            // 
            // PayWithPointRadioButton
            // 
            this.PayWithPointRadioButton.AutoSize = true;
            this.PayWithPointRadioButton.Location = new System.Drawing.Point(6, 19);
            this.PayWithPointRadioButton.Name = "PayWithPointRadioButton";
            this.PayWithPointRadioButton.Size = new System.Drawing.Size(167, 28);
            this.PayWithPointRadioButton.TabIndex = 10;
            this.PayWithPointRadioButton.TabStop = true;
            this.PayWithPointRadioButton.Text = "Pay with points";
            this.PayWithPointRadioButton.UseVisualStyleBackColor = true;
            // 
            // PayWithoutPointsRadioButton
            // 
            this.PayWithoutPointsRadioButton.AutoSize = true;
            this.PayWithoutPointsRadioButton.Location = new System.Drawing.Point(6, 42);
            this.PayWithoutPointsRadioButton.Name = "PayWithoutPointsRadioButton";
            this.PayWithoutPointsRadioButton.Size = new System.Drawing.Size(196, 28);
            this.PayWithoutPointsRadioButton.TabIndex = 11;
            this.PayWithoutPointsRadioButton.TabStop = true;
            this.PayWithoutPointsRadioButton.Text = "Pay without points";
            this.PayWithoutPointsRadioButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(136, 489);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(148, 30);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.Text = "Finish Payment";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Payment With Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Payment Without Points";
            // 
            // DisplayTotalButton
            // 
            this.DisplayTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalButton.Location = new System.Drawing.Point(489, 489);
            this.DisplayTotalButton.Name = "DisplayTotalButton";
            this.DisplayTotalButton.Size = new System.Drawing.Size(127, 30);
            this.DisplayTotalButton.TabIndex = 15;
            this.DisplayTotalButton.Text = "Display Total";
            this.DisplayTotalButton.UseVisualStyleBackColor = true;
            this.DisplayTotalButton.Click += new System.EventHandler(this.DisplayTotalButton_Click);
            // 
            // TotalPaymentWithPointsTextBox
            // 
            this.TotalPaymentWithPointsTextBox.Location = new System.Drawing.Point(897, 350);
            this.TotalPaymentWithPointsTextBox.Name = "TotalPaymentWithPointsTextBox";
            this.TotalPaymentWithPointsTextBox.ReadOnly = true;
            this.TotalPaymentWithPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPaymentWithPointsTextBox.TabIndex = 16;
            // 
            // TotalPaymentWithoutPointsTextBox
            // 
            this.TotalPaymentWithoutPointsTextBox.Location = new System.Drawing.Point(897, 387);
            this.TotalPaymentWithoutPointsTextBox.Name = "TotalPaymentWithoutPointsTextBox";
            this.TotalPaymentWithoutPointsTextBox.ReadOnly = true;
            this.TotalPaymentWithoutPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPaymentWithoutPointsTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity of the Product";
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Location = new System.Drawing.Point(267, 85);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(160, 21);
            this.QuantityComboBox.TabIndex = 19;
            this.QuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.QuantityComboBox_SelectedIndexChanged);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(267, 49);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(212, 21);
            this.ProductComboBox.TabIndex = 3;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // CatergoriesComboBox
            // 
            this.CatergoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatergoriesComboBox.FormattingEnabled = true;
            this.CatergoriesComboBox.Location = new System.Drawing.Point(267, 17);
            this.CatergoriesComboBox.Name = "CatergoriesComboBox";
            this.CatergoriesComboBox.Size = new System.Drawing.Size(212, 21);
            this.CatergoriesComboBox.TabIndex = 1;
            this.CatergoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CatergoriesComboBox_SelectedIndexChanged);
            // 
            // Customer_previous_points_textbox
            // 
            this.Customer_previous_points_textbox.Location = new System.Drawing.Point(300, 279);
            this.Customer_previous_points_textbox.Name = "Customer_previous_points_textbox";
            this.Customer_previous_points_textbox.ReadOnly = true;
            this.Customer_previous_points_textbox.Size = new System.Drawing.Size(163, 20);
            this.Customer_previous_points_textbox.TabIndex = 20;
            // 
            // Customer_previous_points
            // 
            this.Customer_previous_points.AutoSize = true;
            this.Customer_previous_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_previous_points.Location = new System.Drawing.Point(25, 288);
            this.Customer_previous_points.Name = "Customer_previous_points";
            this.Customer_previous_points.Size = new System.Drawing.Size(249, 24);
            this.Customer_previous_points.TabIndex = 21;
            this.Customer_previous_points.Text = "Customer Previous Points";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PayWithPointRadioButton);
            this.groupBox1.Controls.Add(this.PayWithoutPointsRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 94);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(812, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Finilizing_customer_payment_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Customer_previous_points);
            this.Controls.Add(this.Customer_previous_points_textbox);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPaymentWithoutPointsTextBox);
            this.Controls.Add(this.TotalPaymentWithPointsTextBox);
            this.Controls.Add(this.DisplayTotalButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CustomerPhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactionData);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CatergoriesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Finilizing_customer_payment_form";
            this.Text = "Finalizing Customer Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Finilizing_customer_payment_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView TransactionData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerPhoneNumberTextBox;
        private System.Windows.Forms.RadioButton PayWithPointRadioButton;
        private System.Windows.Forms.RadioButton PayWithoutPointsRadioButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DisplayTotalButton;
        private System.Windows.Forms.TextBox TotalPaymentWithPointsTextBox;
        private System.Windows.Forms.TextBox TotalPaymentWithoutPointsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.ComboBox CatergoriesComboBox;
        private System.Windows.Forms.TextBox Customer_previous_points_textbox;
        private System.Windows.Forms.Label Customer_previous_points;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

