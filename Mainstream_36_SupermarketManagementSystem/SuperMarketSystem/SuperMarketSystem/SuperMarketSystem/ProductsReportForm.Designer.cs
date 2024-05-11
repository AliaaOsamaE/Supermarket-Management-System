
namespace SuperMarketSystem
{
    partial class ProductsReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ViewProductsReportBtn = new System.Windows.Forms.Button();
            this.ManagerProductsViewBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Padding = new System.Windows.Forms.Padding(100);
            this.crystalReportViewer1.Size = new System.Drawing.Size(1275, 705);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 500;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ViewProductsReportBtn
            // 
            this.ViewProductsReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductsReportBtn.Location = new System.Drawing.Point(337, 25);
            this.ViewProductsReportBtn.Name = "ViewProductsReportBtn";
            this.ViewProductsReportBtn.Size = new System.Drawing.Size(225, 41);
            this.ViewProductsReportBtn.TabIndex = 1;
            this.ViewProductsReportBtn.Text = "View Products Report";
            this.ViewProductsReportBtn.UseVisualStyleBackColor = true;
            this.ViewProductsReportBtn.Click += new System.EventHandler(this.ViewProductsReportBtn_Click);
            // 
            // ManagerProductsViewBackBtn
            // 
            this.ManagerProductsViewBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerProductsViewBackBtn.Location = new System.Drawing.Point(647, 25);
            this.ManagerProductsViewBackBtn.Name = "ManagerProductsViewBackBtn";
            this.ManagerProductsViewBackBtn.Size = new System.Drawing.Size(225, 41);
            this.ManagerProductsViewBackBtn.TabIndex = 2;
            this.ManagerProductsViewBackBtn.Text = "Back";
            this.ManagerProductsViewBackBtn.UseVisualStyleBackColor = true;
            this.ManagerProductsViewBackBtn.Click += new System.EventHandler(this.ManagerProductsViewBackBtn_Click);
            // 
            // ProductsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.ManagerProductsViewBackBtn);
            this.Controls.Add(this.ViewProductsReportBtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ProductsReportForm";
            this.Text = "ProductsReportForm";
            this.Load += new System.EventHandler(this.ProductsReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button ViewProductsReportBtn;
        private System.Windows.Forms.Button ManagerProductsViewBackBtn;
    }
}