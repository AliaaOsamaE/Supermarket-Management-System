
namespace SuperMarketSystem
{
    partial class ClerkReportForm
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
            this.CategoryNameCMBBox = new System.Windows.Forms.ComboBox();
            this.ProductNameCMBBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayInfoBtn = new System.Windows.Forms.Button();
            this.ClerkBackBtn = new System.Windows.Forms.Button();
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
            this.crystalReportViewer1.Padding = new System.Windows.Forms.Padding(110);
            this.crystalReportViewer1.Size = new System.Drawing.Size(1275, 705);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 410;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // CategoryNameCMBBox
            // 
            this.CategoryNameCMBBox.FormattingEnabled = true;
            this.CategoryNameCMBBox.Location = new System.Drawing.Point(232, 22);
            this.CategoryNameCMBBox.Name = "CategoryNameCMBBox";
            this.CategoryNameCMBBox.Size = new System.Drawing.Size(182, 24);
            this.CategoryNameCMBBox.TabIndex = 1;
            this.CategoryNameCMBBox.SelectedIndexChanged += new System.EventHandler(this.CategoryNameCMBBox_SelectedIndexChanged);
            // 
            // ProductNameCMBBox
            // 
            this.ProductNameCMBBox.FormattingEnabled = true;
            this.ProductNameCMBBox.Location = new System.Drawing.Point(853, 26);
            this.ProductNameCMBBox.Name = "ProductNameCMBBox";
            this.ProductNameCMBBox.Size = new System.Drawing.Size(182, 24);
            this.ProductNameCMBBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product";
            // 
            // DisplayInfoBtn
            // 
            this.DisplayInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayInfoBtn.Location = new System.Drawing.Point(420, 60);
            this.DisplayInfoBtn.Name = "DisplayInfoBtn";
            this.DisplayInfoBtn.Size = new System.Drawing.Size(159, 47);
            this.DisplayInfoBtn.TabIndex = 5;
            this.DisplayInfoBtn.Text = "Display Data";
            this.DisplayInfoBtn.UseVisualStyleBackColor = true;
            this.DisplayInfoBtn.Click += new System.EventHandler(this.DisplayInfoBtn_Click);
            // 
            // ClerkBackBtn
            // 
            this.ClerkBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClerkBackBtn.Location = new System.Drawing.Point(632, 60);
            this.ClerkBackBtn.Name = "ClerkBackBtn";
            this.ClerkBackBtn.Size = new System.Drawing.Size(159, 47);
            this.ClerkBackBtn.TabIndex = 6;
            this.ClerkBackBtn.Text = "Back";
            this.ClerkBackBtn.UseVisualStyleBackColor = true;
            this.ClerkBackBtn.Click += new System.EventHandler(this.ClerkBackBtn_Click);
            // 
            // ClerkReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.ClerkBackBtn);
            this.Controls.Add(this.DisplayInfoBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameCMBBox);
            this.Controls.Add(this.CategoryNameCMBBox);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ClerkReportForm";
            this.Text = "ClerkReportForm";
            this.Load += new System.EventHandler(this.ClerkReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox CategoryNameCMBBox;
        private System.Windows.Forms.ComboBox ProductNameCMBBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DisplayInfoBtn;
        private System.Windows.Forms.Button ClerkBackBtn;
    }
}