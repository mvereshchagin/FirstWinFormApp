namespace FirstWinFormApp
{
    partial class UserEditForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.edFirstName = new System.Windows.Forms.TextBox();
            this.edSecondName = new System.Windows.Forms.TextBox();
            this.edAddress = new System.Windows.Forms.RichTextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(11, 28);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(31, 15);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "Имя";
            // 
            // lbSecondName
            // 
            this.lbSecondName.AutoSize = true;
            this.lbSecondName.Location = new System.Drawing.Point(11, 63);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(58, 15);
            this.lbSecondName.TabIndex = 1;
            this.lbSecondName.Text = "Фамилия";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(11, 101);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(40, 15);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Адрес";
            // 
            // edFirstName
            // 
            this.edFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edFirstName.Location = new System.Drawing.Point(72, 25);
            this.edFirstName.Name = "edFirstName";
            this.edFirstName.Size = new System.Drawing.Size(704, 23);
            this.edFirstName.TabIndex = 3;
            this.edFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.edFirstName_Validating);
            // 
            // edSecondName
            // 
            this.edSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSecondName.Location = new System.Drawing.Point(72, 60);
            this.edSecondName.Name = "edSecondName";
            this.edSecondName.Size = new System.Drawing.Size(704, 23);
            this.edSecondName.TabIndex = 4;
            this.edSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.edSecondName_Validating);
            // 
            // edAddress
            // 
            this.edAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edAddress.Location = new System.Drawing.Point(72, 98);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(704, 146);
            this.edAddress.TabIndex = 5;
            this.edAddress.Text = "";
            this.edAddress.Validating += new System.ComponentModel.CancelEventHandler(this.edAddress_Validating);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(701, 255);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Location = new System.Drawing.Point(620, 255);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 290);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.edAddress);
            this.Controls.Add(this.edSecondName);
            this.Controls.Add(this.edFirstName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbSecondName);
            this.Controls.Add(this.lbFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "UserEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стартовая форма";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFirstName;
        private Label lbSecondName;
        private Label lbAddress;
        private TextBox edFirstName;
        private TextBox edSecondName;
        private RichTextBox edAddress;
        private Button btCancel;
        private Button btOk;
        private ErrorProvider errorProvider;
    }
}