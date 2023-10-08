namespace WinFormsApplication
{
    partial class Form2
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
            label4 = new Label();
            label3 = new Label();
            Telefon = new Label();
            label1 = new Label();
            btnList = new Button();
            btnSave = new Button();
            rtxtAddress = new RichTextBox();
            numericUpDownAge = new NumericUpDown();
            txtTelephone = new TextBox();
            txtNameSurname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 129);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 49;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 99);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 48;
            label3.Text = "Yas";
            // 
            // Telefon
            // 
            Telefon.AutoSize = true;
            Telefon.Location = new Point(54, 57);
            Telefon.Name = "Telefon";
            Telefon.Size = new Size(47, 15);
            Telefon.TabIndex = 47;
            Telefon.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 46;
            label1.Text = "Ad Soyad";
            // 
            // btnList
            // 
            btnList.Location = new Point(156, 267);
            btnList.Name = "btnList";
            btnList.Size = new Size(104, 23);
            btnList.TabIndex = 45;
            btnList.Text = "Listeye Dön";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(168, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 44;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(160, 126);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(100, 96);
            rtxtAddress.TabIndex = 43;
            rtxtAddress.Text = "";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(160, 97);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 42;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(160, 54);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(100, 23);
            txtTelephone.TabIndex = 41;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(160, 25);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(100, 23);
            txtNameSurname.TabIndex = 40;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 315);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Telefon);
            Controls.Add(label1);
            Controls.Add(btnList);
            Controls.Add(btnSave);
            Controls.Add(rtxtAddress);
            Controls.Add(numericUpDownAge);
            Controls.Add(txtTelephone);
            Controls.Add(txtNameSurname);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label Telefon;
        private Label label1;
        private Button btnList;
        private Button btnSave;
        private RichTextBox rtxtAddress;
        private NumericUpDown numericUpDownAge;
        private TextBox txtTelephone;
        private TextBox txtNameSurname;
    }
}