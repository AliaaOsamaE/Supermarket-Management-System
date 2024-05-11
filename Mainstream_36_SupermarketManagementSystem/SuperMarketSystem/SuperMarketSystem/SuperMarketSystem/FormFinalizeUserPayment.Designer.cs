
namespace SuperMarketSystem
{
    partial class FormFinalizeUserPayment
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PayWithPointRadioButton = new System.Windows.Forms.RadioButton();
            this.PayWithoutPointsRadioButton = new System.Windows.Forms.RadioButton();
            this.Customer_previous_points = new System.Windows.Forms.Label();
            this.Customer_previous_points_textbox = new System.Windows.Forms.TextBox();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPaymentWithoutPointsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPaymentWithPointsTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTotalButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CustomerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TransactionData = new System.Windows.Forms.DataGridView();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CatergoriesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1093, 611);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PayWithPointRadioButton);
            this.groupBox1.Controls.Add(this.PayWithoutPointsRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 440);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(307, 116);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // PayWithPointRadioButton
            // 
            this.PayWithPointRadioButton.AutoSize = true;
            this.PayWithPointRadioButton.Location = new System.Drawing.Point(8, 23);
            this.PayWithPointRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.PayWithPointRadioButton.Name = "PayWithPointRadioButton";
            this.PayWithPointRadioButton.Size = new System.Drawing.Size(209, 33);
            this.PayWithPointRadioButton.TabIndex = 10;
            this.PayWithPointRadioButton.TabStop = true;
            this.PayWithPointRadioButton.Text = "Pay with points";
            this.PayWithPointRadioButton.UseVisualStyleBackColor = true;
            // 
            // PayWithoutPointsRadioButton
            // 
            this.PayWithoutPointsRadioButton.AutoSize = true;
            this.PayWithoutPointsRadioButton.Location = new System.Drawing.Point(8, 52);
            this.PayWithoutPointsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.PayWithoutPointsRadioButton.Name = "PayWithoutPointsRadioButton";
            this.PayWithoutPointsRadioButton.Size = new System.Drawing.Size(245, 33);
            this.PayWithoutPointsRadioButton.TabIndex = 11;
            this.PayWithoutPointsRadioButton.TabStop = true;
            this.PayWithoutPointsRadioButton.Text = "Pay without points";
            this.PayWithoutPointsRadioButton.UseVisualStyleBackColor = true;
            // 
            // Customer_previous_points
            // 
            this.Customer_previous_points.AutoSize = true;
            this.Customer_previous_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_previous_points.Location = new System.Drawing.Point(43, 363);
            this.Customer_previous_points.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_previous_points.Name = "Customer_previous_points";
            this.Customer_previous_points.Size = new System.Drawing.Size(314, 29);
            this.Customer_previous_points.TabIndex = 42;
            this.Customer_previous_points.Text = "Customer Previous Points";
            // 
            // Customer_previous_points_textbox
            // 
            this.Customer_previous_points_textbox.Location = new System.Drawing.Point(410, 352);
            this.Customer_previous_points_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_previous_points_textbox.Name = "Customer_previous_points_textbox";
            this.Customer_previous_points_textbox.ReadOnly = true;
            this.Customer_previous_points_textbox.Size = new System.Drawing.Size(216, 22);
            this.Customer_previous_points_textbox.TabIndex = 41;
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Location = new System.Drawing.Point(366, 114);
            this.QuantityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(212, 24);
            this.QuantityComboBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Quantity of the Product";
            // 
            // TotalPaymentWithoutPointsTextBox
            // 
            this.TotalPaymentWithoutPointsTextBox.Location = new System.Drawing.Point(1206, 485);
            this.TotalPaymentWithoutPointsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPaymentWithoutPointsTextBox.Name = "TotalPaymentWithoutPointsTextBox";
            this.TotalPaymentWithoutPointsTextBox.ReadOnly = true;
            this.TotalPaymentWithoutPointsTextBox.Size = new System.Drawing.Size(132, 22);
            this.TotalPaymentWithoutPointsTextBox.TabIndex = 38;
            // 
            // TotalPaymentWithPointsTextBox
            // 
            this.TotalPaymentWithPointsTextBox.Location = new System.Drawing.Point(1206, 440);
            this.TotalPaymentWithPointsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalPaymentWithPointsTextBox.Name = "TotalPaymentWithPointsTextBox";
            this.TotalPaymentWithPointsTextBox.ReadOnly = true;
            this.TotalPaymentWithPointsTextBox.Size = new System.Drawing.Size(132, 22);
            this.TotalPaymentWithPointsTextBox.TabIndex = 37;
            // 
            // DisplayTotalButton
            // 
            this.DisplayTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalButton.Location = new System.Drawing.Point(662, 611);
            this.DisplayTotalButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayTotalButton.Name = "DisplayTotalButton";
            this.DisplayTotalButton.Size = new System.Drawing.Size(169, 37);
            this.DisplayTotalButton.TabIndex = 36;
            this.DisplayTotalButton.Text = "Display Total";
            this.DisplayTotalButton.UseVisualStyleBackColor = true;
            this.DisplayTotalButton.Click += new System.EventHandler(this.DisplayTotalButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total Payment Without Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total Payment With Points";
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(191, 611);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(197, 37);
            this.FinishButton.TabIndex = 33;
            this.FinishButton.Text = "Finish Payment";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CustomerPhoneNumberTextBox
            // 
            this.CustomerPhoneNumberTextBox.Location = new System.Drawing.Point(410, 301);
            this.CustomerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox";
            this.CustomerPhoneNumberTextBox.Size = new System.Drawing.Size(216, 22);
            this.CustomerPhoneNumberTextBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer Phone Number";
            // 
            // TransactionData
            // 
            this.TransactionData.AllowUserToAddRows = false;
            this.TransactionData.AllowUserToDeleteRows = false;
            this.TransactionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionData.Location = new System.Drawing.Point(773, 20);
            this.TransactionData.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionData.MultiSelect = false;
            this.TransactionData.Name = "TransactionData";
            this.TransactionData.ReadOnly = true;
            this.TransactionData.RowHeadersWidth = 51;
            this.TransactionData.Size = new System.Drawing.Size(539, 377);
            this.TransactionData.TabIndex = 30;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(49, 231);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(167, 39);
            this.DeleteProductButton.TabIndex = 29;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(47, 162);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(168, 39);
            this.AddProductButton.TabIndex = 28;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(366, 69);
            this.ProductComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(281, 24);
            this.ProductComboBox.TabIndex = 27;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Products";
            // 
            // CatergoriesComboBox
            // 
            this.CatergoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatergoriesComboBox.FormattingEnabled = true;
            this.CatergoriesComboBox.Location = new System.Drawing.Point(366, 30);
            this.CatergoriesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CatergoriesComboBox.Name = "CatergoriesComboBox";
            this.CatergoriesComboBox.Size = new System.Drawing.Size(281, 24);
            this.CatergoriesComboBox.TabIndex = 25;
            this.CatergoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CatergoriesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Categories";
            // 
            // FormFinalizeUserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 669);
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
            this.Name = "FormFinalizeUserPayment";
            this.Text = "FormFinalizeUserPayment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFinalizeUserPayment_FormClosing);
            this.Load += new System.EventHandler(this.FormFinalizeUserPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PayWithPointRadioButton;
        private System.Windows.Forms.RadioButton PayWithoutPointsRadioButton;
        private System.Windows.Forms.Label Customer_previous_points;
        private System.Windows.Forms.TextBox Customer_previous_points_textbox;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPaymentWithoutPointsTextBox;
        private System.Windows.Forms.TextBox TotalPaymentWithPointsTextBox;
        private System.Windows.Forms.Button DisplayTotalButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.TextBox CustomerPhoneNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TransactionData;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CatergoriesComboBox;
        private System.Windows.Forms.Label label1;
    }
}