namespace 학생관리_프로그램
{
    partial class addstudent
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
            this.list_Major = new System.Windows.Forms.ListBox();
            this.lab_major = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_4 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.gender_group = new System.Windows.Forms.GroupBox();
            this.radio_woman = new System.Windows.Forms.RadioButton();
            this.radio_man = new System.Windows.Forms.RadioButton();
            this.txt_4grade = new System.Windows.Forms.TextBox();
            this.txt_3grade = new System.Windows.Forms.TextBox();
            this.txt_2grade = new System.Windows.Forms.TextBox();
            this.txt_1grade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.lab_average = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_space = new System.Windows.Forms.Label();
            this.picture_face = new System.Windows.Forms.PictureBox();
            this.btn_loadPicture = new System.Windows.Forms.Button();
            this.gender_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_face)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Major
            // 
            this.list_Major.FormattingEnabled = true;
            this.list_Major.ItemHeight = 15;
            this.list_Major.Location = new System.Drawing.Point(220, 122);
            this.list_Major.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_Major.Name = "list_Major";
            this.list_Major.Size = new System.Drawing.Size(159, 79);
            this.list_Major.TabIndex = 40;
            this.list_Major.SelectedIndexChanged += new System.EventHandler(this.list_Major_SelectedIndexChanged_1);
            // 
            // lab_major
            // 
            this.lab_major.BackColor = System.Drawing.Color.White;
            this.lab_major.Location = new System.Drawing.Point(150, 210);
            this.lab_major.Name = "lab_major";
            this.lab_major.Size = new System.Drawing.Size(229, 26);
            this.lab_major.TabIndex = 39;
            this.lab_major.Text = "학과명 확인시 학과 클릭";
            this.lab_major.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(146, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "학    과 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_4
            // 
            this.cb_4.AutoSize = true;
            this.cb_4.Location = new System.Drawing.Point(140, 340);
            this.cb_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_4.Name = "cb_4";
            this.cb_4.Size = new System.Drawing.Size(77, 19);
            this.cb_4.TabIndex = 37;
            this.cb_4.Text = "4학년 :";
            this.cb_4.UseVisualStyleBackColor = true;
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.Location = new System.Drawing.Point(140, 310);
            this.cb_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(77, 19);
            this.cb_3.TabIndex = 36;
            this.cb_3.Text = "3학년 :";
            this.cb_3.UseVisualStyleBackColor = true;
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.Location = new System.Drawing.Point(140, 276);
            this.cb_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(77, 19);
            this.cb_2.TabIndex = 35;
            this.cb_2.Text = "2학년 :";
            this.cb_2.UseVisualStyleBackColor = true;
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(140, 242);
            this.cb_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(77, 19);
            this.cb_1.TabIndex = 34;
            this.cb_1.Text = "1학년 :";
            this.cb_1.UseVisualStyleBackColor = true;
            // 
            // gender_group
            // 
            this.gender_group.Controls.Add(this.radio_woman);
            this.gender_group.Controls.Add(this.radio_man);
            this.gender_group.Location = new System.Drawing.Point(17, 222);
            this.gender_group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_group.Name = "gender_group";
            this.gender_group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_group.Size = new System.Drawing.Size(81, 86);
            this.gender_group.TabIndex = 33;
            this.gender_group.TabStop = false;
            this.gender_group.Text = "성별";
            // 
            // radio_woman
            // 
            this.radio_woman.AutoSize = true;
            this.radio_woman.Location = new System.Drawing.Point(7, 52);
            this.radio_woman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_woman.Name = "radio_woman";
            this.radio_woman.Size = new System.Drawing.Size(58, 19);
            this.radio_woman.TabIndex = 10;
            this.radio_woman.TabStop = true;
            this.radio_woman.Text = "여자";
            this.radio_woman.UseVisualStyleBackColor = true;
            // 
            // radio_man
            // 
            this.radio_man.AutoSize = true;
            this.radio_man.Location = new System.Drawing.Point(7, 25);
            this.radio_man.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_man.Name = "radio_man";
            this.radio_man.Size = new System.Drawing.Size(58, 19);
            this.radio_man.TabIndex = 10;
            this.radio_man.TabStop = true;
            this.radio_man.Text = "남자";
            this.radio_man.UseVisualStyleBackColor = true;
            // 
            // txt_4grade
            // 
            this.txt_4grade.Location = new System.Drawing.Point(220, 338);
            this.txt_4grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_4grade.Name = "txt_4grade";
            this.txt_4grade.Size = new System.Drawing.Size(159, 25);
            this.txt_4grade.TabIndex = 31;
            // 
            // txt_3grade
            // 
            this.txt_3grade.Location = new System.Drawing.Point(220, 304);
            this.txt_3grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_3grade.Name = "txt_3grade";
            this.txt_3grade.Size = new System.Drawing.Size(159, 25);
            this.txt_3grade.TabIndex = 30;
            // 
            // txt_2grade
            // 
            this.txt_2grade.Location = new System.Drawing.Point(220, 270);
            this.txt_2grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_2grade.Name = "txt_2grade";
            this.txt_2grade.Size = new System.Drawing.Size(159, 25);
            this.txt_2grade.TabIndex = 32;
            // 
            // txt_1grade
            // 
            this.txt_1grade.Location = new System.Drawing.Point(220, 240);
            this.txt_1grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_1grade.Name = "txt_1grade";
            this.txt_1grade.Size = new System.Drawing.Size(159, 25);
            this.txt_1grade.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(220, 88);
            this.code_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(159, 25);
            this.code_textBox.TabIndex = 27;
            this.code_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lab_average
            // 
            this.lab_average.BackColor = System.Drawing.Color.White;
            this.lab_average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_average.Location = new System.Drawing.Point(220, 368);
            this.lab_average.Name = "lab_average";
            this.lab_average.Size = new System.Drawing.Size(160, 26);
            this.lab_average.TabIndex = 26;
            this.lab_average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_average.Click += new System.EventHandler(this.lab_average_Click_1);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(147, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "평   점 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "학    번 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_textBox
            // 
            this.date_textBox.Location = new System.Drawing.Point(220, 53);
            this.date_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_textBox.Name = "date_textBox";
            this.date_textBox.Size = new System.Drawing.Size(159, 25);
            this.date_textBox.TabIndex = 23;
            this.date_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "출생년도 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(220, 20);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(159, 25);
            this.name_textBox.TabIndex = 21;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // name_space
            // 
            this.name_space.Location = new System.Drawing.Point(148, 20);
            this.name_space.Name = "name_space";
            this.name_space.Size = new System.Drawing.Size(69, 26);
            this.name_space.TabIndex = 20;
            this.name_space.Text = "이    름 : ";
            this.name_space.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_face
            // 
            this.picture_face.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_face.Location = new System.Drawing.Point(9, 10);
            this.picture_face.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picture_face.Name = "picture_face";
            this.picture_face.Size = new System.Drawing.Size(122, 163);
            this.picture_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_face.TabIndex = 19;
            this.picture_face.TabStop = false;
            // 
            // btn_loadPicture
            // 
            this.btn_loadPicture.Location = new System.Drawing.Point(17, 182);
            this.btn_loadPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loadPicture.Name = "btn_loadPicture";
            this.btn_loadPicture.Size = new System.Drawing.Size(106, 29);
            this.btn_loadPicture.TabIndex = 18;
            this.btn_loadPicture.Text = "사진불러오기";
            this.btn_loadPicture.UseVisualStyleBackColor = true;
            this.btn_loadPicture.Click += new System.EventHandler(this.btn_loadPicture_Click);
            // 
            // addstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 455);
            this.Controls.Add(this.list_Major);
            this.Controls.Add(this.lab_major);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_4);
            this.Controls.Add(this.cb_3);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.gender_group);
            this.Controls.Add(this.txt_4grade);
            this.Controls.Add(this.txt_3grade);
            this.Controls.Add(this.txt_2grade);
            this.Controls.Add(this.txt_1grade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.lab_average);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_space);
            this.Controls.Add(this.picture_face);
            this.Controls.Add(this.btn_loadPicture);
            this.Name = "addstudent";
            this.Text = "학생추가";
            this.gender_group.ResumeLayout(false);
            this.gender_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Major;
        private System.Windows.Forms.Label lab_major;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_4;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.GroupBox gender_group;
        private System.Windows.Forms.RadioButton radio_woman;
        private System.Windows.Forms.RadioButton radio_man;
        private System.Windows.Forms.TextBox txt_4grade;
        private System.Windows.Forms.TextBox txt_3grade;
        private System.Windows.Forms.TextBox txt_2grade;
        private System.Windows.Forms.TextBox txt_1grade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.Label lab_average;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox date_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_space;
        private System.Windows.Forms.PictureBox picture_face;
        private System.Windows.Forms.Button btn_loadPicture;
    }
}