
namespace BookRegistration
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.txtIsbn = new System.Windows.Forms.MaskedTextBox();
            this.checkEnglish = new System.Windows.Forms.CheckBox();
            this.checkPortuguese = new System.Windows.Forms.CheckBox();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioEbook = new System.Windows.Forms.RadioButton();
            this.radioPhysical = new System.Windows.Forms.RadioButton();
            this.ListView = new System.Windows.Forms.ListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.groupBoxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(230, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(438, 35);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(230, 99);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(438, 35);
            this.txtDate.TabIndex = 5;
            // 
            // ComboCategory
            // 
            this.ComboCategory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Location = new System.Drawing.Point(230, 146);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(438, 38);
            this.ComboCategory.TabIndex = 6;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(230, 196);
            this.txtIsbn.Mask = "000-00-0000";
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(438, 35);
            this.txtIsbn.TabIndex = 7;
            // 
            // checkEnglish
            // 
            this.checkEnglish.AutoSize = true;
            this.checkEnglish.Location = new System.Drawing.Point(43, 286);
            this.checkEnglish.Name = "checkEnglish";
            this.checkEnglish.Size = new System.Drawing.Size(95, 17);
            this.checkEnglish.TabIndex = 8;
            this.checkEnglish.Text = "English Edition";
            this.checkEnglish.UseVisualStyleBackColor = true;
            // 
            // checkPortuguese
            // 
            this.checkPortuguese.AutoSize = true;
            this.checkPortuguese.Location = new System.Drawing.Point(43, 249);
            this.checkPortuguese.Name = "checkPortuguese";
            this.checkPortuguese.Size = new System.Drawing.Size(115, 17);
            this.checkPortuguese.TabIndex = 9;
            this.checkPortuguese.Text = "Portuguese Edition";
            this.checkPortuguese.UseVisualStyleBackColor = true;
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.radioEbook);
            this.groupBoxFormat.Controls.Add(this.radioPhysical);
            this.groupBoxFormat.Location = new System.Drawing.Point(196, 249);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(388, 112);
            this.groupBoxFormat.TabIndex = 10;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Format";
            // 
            // radioEbook
            // 
            this.radioEbook.AutoSize = true;
            this.radioEbook.Location = new System.Drawing.Point(32, 77);
            this.radioEbook.Name = "radioEbook";
            this.radioEbook.Size = new System.Drawing.Size(56, 17);
            this.radioEbook.TabIndex = 1;
            this.radioEbook.Text = "eBook";
            this.radioEbook.UseVisualStyleBackColor = true;
            // 
            // radioPhysical
            // 
            this.radioPhysical.AutoSize = true;
            this.radioPhysical.Checked = true;
            this.radioPhysical.Location = new System.Drawing.Point(32, 36);
            this.radioPhysical.Name = "radioPhysical";
            this.radioPhysical.Size = new System.Drawing.Size(92, 17);
            this.radioPhysical.TabIndex = 0;
            this.radioPhysical.TabStop = true;
            this.radioPhysical.Text = "Physical Book";
            this.radioPhysical.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.FormattingEnabled = true;
            this.ListView.ItemHeight = 23;
            this.ListView.Location = new System.Drawing.Point(43, 471);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(641, 119);
            this.ListView.TabIndex = 11;
            this.ListView.Tag = "";
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(31, 394);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 43);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register / Alter";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(252, 394);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(195, 43);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.Location = new System.Drawing.Point(473, 394);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(195, 43);
            this.bntDelete.TabIndex = 14;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 617);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.groupBoxFormat);
            this.Controls.Add(this.checkPortuguese);
            this.Controls.Add(this.checkEnglish);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.MaskedTextBox txtIsbn;
        private System.Windows.Forms.CheckBox checkEnglish;
        private System.Windows.Forms.CheckBox checkPortuguese;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioEbook;
        private System.Windows.Forms.RadioButton radioPhysical;
        private System.Windows.Forms.ListBox ListView;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button bntDelete;
    }
}

