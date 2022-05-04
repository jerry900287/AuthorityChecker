namespace AuthorityChecker
{
    partial class AuthorityCheckerForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.workstationIDLabel = new System.Windows.Forms.Label();
            this.machineNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminLabel.Location = new System.Drawing.Point(12, 9);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(119, 18);
            this.isAdminLabel.TabIndex = 0;
            this.isAdminLabel.Text = "Is Administrator:";
            // 
            // workstationIDLabel
            // 
            this.workstationIDLabel.AutoSize = true;
            this.workstationIDLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workstationIDLabel.Location = new System.Drawing.Point(12, 58);
            this.workstationIDLabel.Name = "workstationIDLabel";
            this.workstationIDLabel.Size = new System.Drawing.Size(114, 18);
            this.workstationIDLabel.TabIndex = 1;
            this.workstationIDLabel.Text = "Workstation ID:";
            // 
            // machineNameLabel
            // 
            this.machineNameLabel.AutoSize = true;
            this.machineNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineNameLabel.Location = new System.Drawing.Point(12, 90);
            this.machineNameLabel.Name = "machineNameLabel";
            this.machineNameLabel.Size = new System.Drawing.Size(117, 18);
            this.machineNameLabel.TabIndex = 2;
            this.machineNameLabel.Text = "Machine Name:";
            // 
            // AuthorityCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.machineNameLabel);
            this.Controls.Add(this.workstationIDLabel);
            this.Controls.Add(this.isAdminLabel);
            this.Name = "AuthorityCheckerForm";
            this.Text = "AuthorityCheckerForm";
            this.Load += new System.EventHandler(this.AuthorityCheckerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isAdminLabel;
        private System.Windows.Forms.Label workstationIDLabel;
        private System.Windows.Forms.Label machineNameLabel;
    }
}

