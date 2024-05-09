namespace WindowsFormsApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EnterProductCategory = new System.Windows.Forms.Label();
            this.ProductCategory = new System.Windows.Forms.TextBox();
            this.LoadProducts = new System.Windows.Forms.Button();
            this.SaveNewPricesbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // EnterProductCategory
            // 
            this.EnterProductCategory.BackColor = System.Drawing.SystemColors.Control;
            this.EnterProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterProductCategory.Location = new System.Drawing.Point(29, 63);
            this.EnterProductCategory.Name = "EnterProductCategory";
            this.EnterProductCategory.Size = new System.Drawing.Size(239, 37);
            this.EnterProductCategory.TabIndex = 4;
            this.EnterProductCategory.Text = "Enter Product Category";
            this.EnterProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategory.Location = new System.Drawing.Point(283, 66);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(240, 29);
            this.ProductCategory.TabIndex = 5;
            // 
            // LoadProducts
            // 
            this.LoadProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProducts.Location = new System.Drawing.Point(206, 123);
            this.LoadProducts.Name = "LoadProducts";
            this.LoadProducts.Size = new System.Drawing.Size(199, 33);
            this.LoadProducts.TabIndex = 6;
            this.LoadProducts.Text = "Load Products";
            this.LoadProducts.UseVisualStyleBackColor = true;
            this.LoadProducts.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // SaveNewPricesbutton
            // 
            this.SaveNewPricesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewPricesbutton.Location = new System.Drawing.Point(546, 443);
            this.SaveNewPricesbutton.Name = "SaveNewPricesbutton";
            this.SaveNewPricesbutton.Size = new System.Drawing.Size(178, 53);
            this.SaveNewPricesbutton.TabIndex = 7;
            this.SaveNewPricesbutton.Text = "Save New Prices";
            this.SaveNewPricesbutton.UseVisualStyleBackColor = true;
            this.SaveNewPricesbutton.Click += new System.EventHandler(this.SaveNewPricesbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormControlPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveNewPricesbutton);
            this.Controls.Add(this.LoadProducts);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.EnterProductCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormControlPrices";
            this.Text = "Control Prices";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EnterProductCategory;
        private System.Windows.Forms.TextBox ProductCategory;
        private System.Windows.Forms.Button LoadProducts;
        private System.Windows.Forms.Button SaveNewPricesbutton;
        private System.Windows.Forms.Button button1;
    }
}

