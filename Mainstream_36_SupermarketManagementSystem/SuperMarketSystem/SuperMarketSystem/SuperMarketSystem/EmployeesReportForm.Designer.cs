
namespace SuperMarketSystem
{
    partial class EmployeesReportForm
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
            this.EmployeeRolesCMBBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewEmployeeReportBtn = new System.Windows.Forms.Button();
            this.ManagerViewEmpBackBtn = new System.Windows.Forms.Button();
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
            this.crystalReportViewer1.ToolPanelWidth = 530;
            // 
            // EmployeeRolesCMBBox
            // 
            this.EmployeeRolesCMBBox.FormattingEnabled = true;
            this.EmployeeRolesCMBBox.Location = new System.Drawing.Point(231, 30);
            this.EmployeeRolesCMBBox.Name = "EmployeeRolesCMBBox";
            this.EmployeeRolesCMBBox.Size = new System.Drawing.Size(291, 24);
            this.EmployeeRolesCMBBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees\' Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // ViewEmployeeReportBtn
            // 
            this.ViewEmployeeReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployeeReportBtn.Location = new System.Drawing.Point(737, 23);
            this.ViewEmployeeReportBtn.Name = "ViewEmployeeReportBtn";
            this.ViewEmployeeReportBtn.Size = new System.Drawing.Size(206, 35);
            this.ViewEmployeeReportBtn.TabIndex = 5;
            this.ViewEmployeeReportBtn.Text = "View Employees Report";
            this.ViewEmployeeReportBtn.UseVisualStyleBackColor = true;
            this.ViewEmployeeReportBtn.Click += new System.EventHandler(this.ViewEmployeeReportBtn_Click);
            // 
            // ManagerViewEmpBackBtn
            // 
            this.ManagerViewEmpBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerViewEmpBackBtn.Location = new System.Drawing.Point(980, 23);
            this.ManagerViewEmpBackBtn.Name = "ManagerViewEmpBackBtn";
            this.ManagerViewEmpBackBtn.Size = new System.Drawing.Size(206, 35);
            this.ManagerViewEmpBackBtn.TabIndex = 6;
            this.ManagerViewEmpBackBtn.Text = "Back";
            this.ManagerViewEmpBackBtn.UseVisualStyleBackColor = true;
            this.ManagerViewEmpBackBtn.Click += new System.EventHandler(this.ManagerViewEmpBackBtn_Click);
            // 
            // EmployeesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.ManagerViewEmpBackBtn);
            this.Controls.Add(this.ViewEmployeeReportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeRolesCMBBox);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "EmployeesReportForm";
            this.Text = "EmployeesReportForm";
            this.Load += new System.EventHandler(this.EmployeesReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox EmployeeRolesCMBBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewEmployeeReportBtn;
        private System.Windows.Forms.Button ManagerViewEmpBackBtn;
    }
}