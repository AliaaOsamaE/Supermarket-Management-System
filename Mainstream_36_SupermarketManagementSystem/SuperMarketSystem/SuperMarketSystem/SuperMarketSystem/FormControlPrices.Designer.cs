
namespace SuperMarketSystem
{
    partial class FormControlPrices
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
            this.SaveNewPricesbutton = new System.Windows.Forms.Button();
            this.LoadProducts = new System.Windows.Forms.Button();
            this.ProductCategory = new System.Windows.Forms.TextBox();
            this.EnterProductCategory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveNewPricesbutton
            // 
            this.SaveNewPricesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewPricesbutton.Location = new System.Drawing.Point(801, 535);
            this.SaveNewPricesbutton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveNewPricesbutton.Name = "SaveNewPricesbutton";
            this.SaveNewPricesbutton.Size = new System.Drawing.Size(237, 65);
            this.SaveNewPricesbutton.TabIndex = 13;
            this.SaveNewPricesbutton.Text = "Save New Prices";
            this.SaveNewPricesbutton.UseVisualStyleBackColor = true;
            this.SaveNewPricesbutton.Click += new System.EventHandler(this.SaveNewPricesbutton_Click);
            // 
            // LoadProducts
            // 
            this.LoadProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProducts.Location = new System.Drawing.Point(348, 141);
            this.LoadProducts.Margin = new System.Windows.Forms.Padding(4);
            this.LoadProducts.Name = "LoadProducts";
            this.LoadProducts.Size = new System.Drawing.Size(265, 41);
            this.LoadProducts.TabIndex = 12;
            this.LoadProducts.Text = "Load Products";
            this.LoadProducts.UseVisualStyleBackColor = true;
            this.LoadProducts.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // ProductCategory
            // 
            this.ProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategory.Location = new System.Drawing.Point(450, 71);
            this.ProductCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(319, 34);
            this.ProductCategory.TabIndex = 11;
            // 
            // EnterProductCategory
            // 
            this.EnterProductCategory.BackColor = System.Drawing.SystemColors.Control;
            this.EnterProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterProductCategory.Location = new System.Drawing.Point(112, 68);
            this.EnterProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterProductCategory.Name = "EnterProductCategory";
            this.EnterProductCategory.Size = new System.Drawing.Size(319, 46);
            this.EnterProductCategory.TabIndex = 10;
            this.EnterProductCategory.Text = "Enter Product Category";
            this.EnterProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(857, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(457, 492);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormControlPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveNewPricesbutton);
            this.Controls.Add(this.LoadProducts);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.EnterProductCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormControlPrices";
            this.Text = "FormControlPrices";
            this.Load += new System.EventHandler(this.FormControlPrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveNewPricesbutton;
        private System.Windows.Forms.Button LoadProducts;
        private System.Windows.Forms.TextBox ProductCategory;
        private System.Windows.Forms.Label EnterProductCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}