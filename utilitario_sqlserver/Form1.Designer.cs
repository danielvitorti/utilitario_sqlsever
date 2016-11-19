namespace utilitario_sqlserver
{
    partial class FrmPrincipal
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
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lstPrincipal = new System.Windows.Forms.ListBox();
            this.btnListagemBanco = new System.Windows.Forms.Button();
            this.grpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.btnListagemBanco);
            this.grpPrincipal.Controls.Add(this.lstPrincipal);
            this.grpPrincipal.Controls.Add(this.btnRestore);
            this.grpPrincipal.Controls.Add(this.btnBackup);
            this.grpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(678, 366);
            this.grpPrincipal.TabIndex = 0;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "SQL Server - Backup e Restore";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(27, 57);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(223, 75);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Efetuar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(27, 250);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(223, 75);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Efetuar Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lstPrincipal
            // 
            this.lstPrincipal.FormattingEnabled = true;
            this.lstPrincipal.Location = new System.Drawing.Point(304, 87);
            this.lstPrincipal.Name = "lstPrincipal";
            this.lstPrincipal.Size = new System.Drawing.Size(334, 238);
            this.lstPrincipal.TabIndex = 1;
            // 
            // btnListagemBanco
            // 
            this.btnListagemBanco.Location = new System.Drawing.Point(304, 57);
            this.btnListagemBanco.Name = "btnListagemBanco";
            this.btnListagemBanco.Size = new System.Drawing.Size(334, 23);
            this.btnListagemBanco.TabIndex = 2;
            this.btnListagemBanco.Text = "Listagem de Bancos de Dados";
            this.btnListagemBanco.UseVisualStyleBackColor = true;
            this.btnListagemBanco.Click += new System.EventHandler(this.btnListagemBanco_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 390);
            this.Controls.Add(this.grpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Server - Utilitário de Backup e Restore";
            this.grpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.ListBox lstPrincipal;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnListagemBanco;
    }
}

