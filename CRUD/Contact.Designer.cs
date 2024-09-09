namespace CRUD
{
    partial class Contact
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
            ContactID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ContactIdTb = new TextBox();
            FirstNameTb = new TextBox();
            pictureBox1 = new PictureBox();
            LastNameTb = new TextBox();
            ContactNoTb = new TextBox();
            label5 = new Label();
            data1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            GenderCb = new ComboBox();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ContactID
            // 
            ContactID.AutoSize = true;
            ContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactID.Location = new Point(77, 107);
            ContactID.Name = "ContactID";
            ContactID.Size = new Size(104, 28);
            ContactID.TabIndex = 0;
            ContactID.Text = "Contact ID";
            ContactID.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 160);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 215);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 272);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 3;
            label4.Text = "Contact No";
            label4.Click += label4_Click;
            // 
            // ContactIdTb
            // 
            ContactIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactIdTb.Location = new Point(192, 104);
            ContactIdTb.Name = "ContactIdTb";
            ContactIdTb.Size = new Size(221, 34);
            ContactIdTb.TabIndex = 4;
            // 
            // FirstNameTb
            // 
            FirstNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameTb.Location = new Point(192, 154);
            FirstNameTb.Name = "FirstNameTb";
            FirstNameTb.Size = new Size(221, 34);
            FirstNameTb.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.contact_crud;
            pictureBox1.Location = new Point(389, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LastNameTb
            // 
            LastNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameTb.Location = new Point(192, 209);
            LastNameTb.Name = "LastNameTb";
            LastNameTb.Size = new Size(221, 34);
            LastNameTb.TabIndex = 7;
            // 
            // ContactNoTb
            // 
            ContactNoTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNoTb.Location = new Point(180, 266);
            ContactNoTb.Name = "ContactNoTb";
            ContactNoTb.Size = new Size(233, 34);
            ContactNoTb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 330);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // data1
            // 
            data1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data1.Location = new Point(438, 107);
            data1.Name = "data1";
            data1.RowHeadersWidth = 51;
            data1.Size = new Size(473, 287);
            data1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(71, 430);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(305, 430);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(420, 430);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 13;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(192, 334);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(100, 28);
            GenderCb.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(192, 430);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 16;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.exit;
            pictureBox2.Location = new Point(798, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 255);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(699, 430);
            button5.Name = "button5";
            button5.Size = new Size(153, 39);
            button5.TabIndex = 18;
            button5.Text = "Empty Table";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 510);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(GenderCb);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(data1);
            Controls.Add(label5);
            Controls.Add(ContactNoTb);
            Controls.Add(LastNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(FirstNameTb);
            Controls.Add(ContactIdTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ContactID);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Contact";
            Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)data1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ContactID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ContactIdTb;
        private TextBox FirstNameTb;
        private PictureBox pictureBox1;
        private TextBox LastNameTb;
        private TextBox ContactNoTb;
        private Label label5;
        private DataGridView data1;
        private Button button1;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ComboBox GenderCb;
        private Button button4;
        private PictureBox pictureBox2;
        private Button button5;
    }
}
