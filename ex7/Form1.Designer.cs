namespace ex7
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
            contactF = new TextBox();
            lastnameF = new TextBox();
            adresseF = new TextBox();
            firstnameF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ContactID = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            genderF = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contactF
            // 
            contactF.Location = new Point(198, 74);
            contactF.Name = "contactF";
            contactF.Size = new Size(115, 27);
            contactF.TabIndex = 0;
            contactF.TextChanged += textBox1_TextChanged;
            // 
            // lastnameF
            // 
            lastnameF.Location = new Point(198, 181);
            lastnameF.Name = "lastnameF";
            lastnameF.Size = new Size(115, 27);
            lastnameF.TabIndex = 1;
            // 
            // adresseF
            // 
            adresseF.Location = new Point(198, 237);
            adresseF.Name = "adresseF";
            adresseF.Size = new Size(115, 27);
            adresseF.TabIndex = 2;
            // 
            // firstnameF
            // 
            firstnameF.Location = new Point(198, 127);
            firstnameF.Name = "firstnameF";
            firstnameF.Size = new Size(115, 27);
            firstnameF.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Contact ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 127);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 181);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 237);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 7;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 293);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(135, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(245, 373);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(360, 373);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "clear table";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Location = new Point(471, 373);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ContactID, Firstname, lastname, Gender });
            dataGridView1.Location = new Point(386, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(547, 243);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ContactID
            // 
            ContactID.HeaderText = "ContactID";
            ContactID.MinimumWidth = 6;
            ContactID.Name = "ContactID";
            ContactID.Width = 125;
            // 
            // Firstname
            // 
            Firstname.HeaderText = "FirstName";
            Firstname.MinimumWidth = 6;
            Firstname.Name = "Firstname";
            Firstname.Width = 125;
            // 
            // lastname
            // 
            lastname.HeaderText = "LastName";
            lastname.MinimumWidth = 6;
            lastname.Name = "lastname";
            lastname.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // genderF
            // 
            genderF.FormattingEnabled = true;
            genderF.Items.AddRange(new object[] { "Man", "Women" });
            genderF.Location = new Point(198, 290);
            genderF.Name = "genderF";
            genderF.Size = new Size(151, 28);
            genderF.TabIndex = 15;
            genderF.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(genderF);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstnameF);
            Controls.Add(adresseF);
            Controls.Add(lastnameF);
            Controls.Add(contactF);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contactF;
        private TextBox lastnameF;
        private TextBox adresseF;
        private TextBox firstnameF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ContactID;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn Gender;
        private ComboBox genderF;
    }
}
