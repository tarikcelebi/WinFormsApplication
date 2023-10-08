namespace WinFormsApplication
{
    partial class Form1
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
            Button btnAddNewClient;
            lstClients = new ListBox();
            btnAddNewClient = new Button();
            SuspendLayout();
            // 
            // btnAddNewClient
            // 
            btnAddNewClient.Location = new Point(125, 236);
            btnAddNewClient.Name = "btnAddNewClient";
            btnAddNewClient.Size = new Size(102, 23);
            btnAddNewClient.TabIndex = 3;
            btnAddNewClient.Text = "Yeni Müşteri Ekle";
            btnAddNewClient.UseVisualStyleBackColor = true;
            btnAddNewClient.Click += btnAddNewClient_Click;
            // 
            // lstClients
            // 
            lstClients.FormattingEnabled = true;
            lstClients.ItemHeight = 15;
            lstClients.Location = new Point(43, 76);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(255, 154);
            lstClients.TabIndex = 2;
            lstClients.SelectedIndexChanged += lstClients_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 334);
            Controls.Add(btnAddNewClient);
            Controls.Add(lstClients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstClients;
    }
}