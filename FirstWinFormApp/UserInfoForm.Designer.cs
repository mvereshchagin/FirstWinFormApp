namespace FirstWinFormApp
{
    partial class UserInfoForm
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
            this.btEdit = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbFirstNameInfo = new System.Windows.Forms.Label();
            this.lbSecondNameInfo = new System.Windows.Forms.Label();
            this.lbAddressInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.Location = new System.Drawing.Point(320, 241);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(110, 23);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(436, 241);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(12, 91);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(40, 15);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "Адрес";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Location = new System.Drawing.Point(12, 53);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(58, 15);
            this.lbSecondName.TabIndex = 11;
            this.lbSecondName.Text = "Фамилия";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 18);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(31, 15);
            this.lbFirstName.TabIndex = 10;
            this.lbFirstName.Text = "Имя";
            // 
            // lbFirstNameInfo
            // 
            this.lbFirstNameInfo.AutoSize = true;
            this.lbFirstNameInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFirstNameInfo.Location = new System.Drawing.Point(95, 18);
            this.lbFirstNameInfo.Name = "lbFirstNameInfo";
            this.lbFirstNameInfo.Size = new System.Drawing.Size(60, 18);
            this.lbFirstNameInfo.TabIndex = 13;
            this.lbFirstNameInfo.Text = "label1";
            // 
            // lbSecondNameInfo
            // 
            this.lbSecondNameInfo.AutoSize = true;
            this.lbSecondNameInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSecondNameInfo.Location = new System.Drawing.Point(95, 53);
            this.lbSecondNameInfo.Name = "lbSecondNameInfo";
            this.lbSecondNameInfo.Size = new System.Drawing.Size(60, 18);
            this.lbSecondNameInfo.TabIndex = 14;
            this.lbSecondNameInfo.Text = "label1";
            // 
            // lbAddressInfo
            // 
            this.lbAddressInfo.AutoSize = true;
            this.lbAddressInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddressInfo.Location = new System.Drawing.Point(95, 91);
            this.lbAddressInfo.Name = "lbAddressInfo";
            this.lbAddressInfo.Size = new System.Drawing.Size(60, 18);
            this.lbAddressInfo.TabIndex = 15;
            this.lbAddressInfo.Text = "label1";
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 276);
            this.Controls.Add(this.lbAddressInfo);
            this.Controls.Add(this.lbSecondNameInfo);
            this.Controls.Add(this.lbFirstNameInfo);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btClose);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "UserInfoForm";
            this.Text = "Информацйия о пользователе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btEdit;
        private Button btClose;
        private Label lbAddress;
        private Label lbSecondName;
        private Label lbFirstName;
        private Label lbFirstNameInfo;
        private Label lbSecondNameInfo;
        private Label lbAddressInfo;
    }
}