namespace BindingsListBox
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
            this.BoxFilms = new System.Windows.Forms.ListBox();
            this.Del = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.FilmInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FilmYear = new System.Windows.Forms.ComboBox();
            this.FilmDescr = new System.Windows.Forms.TextBox();
            this.FilmName = new System.Windows.Forms.TextBox();
            this.FilmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxFilms
            // 
            this.BoxFilms.FormattingEnabled = true;
            this.BoxFilms.Location = new System.Drawing.Point(13, 13);
            this.BoxFilms.Name = "BoxFilms";
            this.BoxFilms.Size = new System.Drawing.Size(211, 290);
            this.BoxFilms.TabIndex = 0;
            // 
            // Del
            // 
            this.Del.Enabled = false;
            this.Del.Location = new System.Drawing.Point(433, 13);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 3;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(245, 13);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(326, 13);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(101, 23);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // FilmInfo
            // 
            this.FilmInfo.Controls.Add(this.label3);
            this.FilmInfo.Controls.Add(this.label2);
            this.FilmInfo.Controls.Add(this.label1);
            this.FilmInfo.Controls.Add(this.button5);
            this.FilmInfo.Controls.Add(this.button4);
            this.FilmInfo.Controls.Add(this.FilmYear);
            this.FilmInfo.Controls.Add(this.FilmDescr);
            this.FilmInfo.Controls.Add(this.FilmName);
            this.FilmInfo.Enabled = false;
            this.FilmInfo.Location = new System.Drawing.Point(245, 43);
            this.FilmInfo.Name = "FilmInfo";
            this.FilmInfo.Size = new System.Drawing.Size(321, 263);
            this.FilmInfo.TabIndex = 4;
            this.FilmInfo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название фильма";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FilmYear
            // 
            this.FilmYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmYear.FormattingEnabled = true;
            this.FilmYear.Location = new System.Drawing.Point(19, 71);
            this.FilmYear.Name = "FilmYear";
            this.FilmYear.Size = new System.Drawing.Size(121, 21);
            this.FilmYear.TabIndex = 2;
            // 
            // FilmDescr
            // 
            this.FilmDescr.Location = new System.Drawing.Point(19, 110);
            this.FilmDescr.Multiline = true;
            this.FilmDescr.Name = "FilmDescr";
            this.FilmDescr.Size = new System.Drawing.Size(289, 107);
            this.FilmDescr.TabIndex = 1;
            // 
            // FilmName
            // 
            this.FilmName.Location = new System.Drawing.Point(19, 29);
            this.FilmName.Name = "FilmName";
            this.FilmName.Size = new System.Drawing.Size(289, 20);
            this.FilmName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 325);
            this.Controls.Add(this.FilmInfo);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BoxFilms);
            this.Name = "Form1";
            this.Text = "Фильмы";
            this.FilmInfo.ResumeLayout(false);
            this.FilmInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BoxFilms;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox FilmInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox FilmYear;
        private System.Windows.Forms.TextBox FilmDescr;
        private System.Windows.Forms.TextBox FilmName;
    }
}

