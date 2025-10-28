namespace TestExercise
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ForName = new System.Windows.Forms.TextBox();
            this.ForSurname = new System.Windows.Forms.TextBox();
            this.ForDate = new System.Windows.Forms.DateTimePicker();
            this.ForGender = new System.Windows.Forms.ComboBox();
            this.ForNumber = new System.Windows.Forms.TextBox();
            this.ForAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddEditBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ForPersonID = new System.Windows.Forms.TextBox();
            this.ForEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "გვარი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "სახელი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "დაბადების თარიღი";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ტელენოფის ნომერი";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "სქესი";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "მისამართი";
            // 
            // ForName
            // 
            this.ForName.Location = new System.Drawing.Point(414, 77);
            this.ForName.Name = "ForName";
            this.ForName.Size = new System.Drawing.Size(100, 20);
            this.ForName.TabIndex = 7;
            // 
            // ForSurname
            // 
            this.ForSurname.Location = new System.Drawing.Point(414, 113);
            this.ForSurname.Name = "ForSurname";
            this.ForSurname.Size = new System.Drawing.Size(100, 20);
            this.ForSurname.TabIndex = 8;
            // 
            // ForDate
            // 
            this.ForDate.Location = new System.Drawing.Point(414, 156);
            this.ForDate.Name = "ForDate";
            this.ForDate.Size = new System.Drawing.Size(200, 20);
            this.ForDate.TabIndex = 9;
            // 
            // ForGender
            // 
            this.ForGender.FormattingEnabled = true;
            this.ForGender.Location = new System.Drawing.Point(414, 195);
            this.ForGender.Name = "ForGender";
            this.ForGender.Size = new System.Drawing.Size(121, 21);
            this.ForGender.TabIndex = 10;
            // 
            // ForNumber
            // 
            this.ForNumber.Location = new System.Drawing.Point(414, 244);
            this.ForNumber.Name = "ForNumber";
            this.ForNumber.Size = new System.Drawing.Size(100, 20);
            this.ForNumber.TabIndex = 11;
            // 
            // ForAddress
            // 
            this.ForAddress.Location = new System.Drawing.Point(414, 282);
            this.ForAddress.Name = "ForAddress";
            this.ForAddress.Size = new System.Drawing.Size(100, 20);
            this.ForAddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "პაციენტის რედაქტირება/დამატება";
            // 
            // AddEditBtn
            // 
            this.AddEditBtn.Location = new System.Drawing.Point(274, 392);
            this.AddEditBtn.Name = "AddEditBtn";
            this.AddEditBtn.Size = new System.Drawing.Size(75, 23);
            this.AddEditBtn.TabIndex = 14;
            this.AddEditBtn.Text = "შენახვა";
            this.AddEditBtn.UseVisualStyleBackColor = true;
            this.AddEditBtn.Click += new System.EventHandler(this.AddEditBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(388, 392);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.Text = "დახურვა";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "პირადი ნომერი";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ელ-ფოსტა";
            // 
            // ForPersonID
            // 
            this.ForPersonID.Location = new System.Drawing.Point(414, 321);
            this.ForPersonID.Name = "ForPersonID";
            this.ForPersonID.Size = new System.Drawing.Size(100, 20);
            this.ForPersonID.TabIndex = 18;
            // 
            // ForEmail
            // 
            this.ForEmail.Location = new System.Drawing.Point(414, 359);
            this.ForEmail.Name = "ForEmail";
            this.ForEmail.Size = new System.Drawing.Size(100, 20);
            this.ForEmail.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForEmail);
            this.Controls.Add(this.ForPersonID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddEditBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ForAddress);
            this.Controls.Add(this.ForNumber);
            this.Controls.Add(this.ForGender);
            this.Controls.Add(this.ForDate);
            this.Controls.Add(this.ForSurname);
            this.Controls.Add(this.ForName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ForName;
        private System.Windows.Forms.TextBox ForSurname;
        private System.Windows.Forms.DateTimePicker ForDate;
        private System.Windows.Forms.ComboBox ForGender;
        private System.Windows.Forms.TextBox ForNumber;
        private System.Windows.Forms.TextBox ForAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddEditBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ForPersonID;
        private System.Windows.Forms.TextBox ForEmail;
    }
}