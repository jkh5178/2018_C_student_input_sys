using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 학생관리_프로그램
{
    public partial class addstudent : Form
    {
        double grade = 0, grad1, grad2, grad3, grad4;
        List<Major> major = new List<Major>();
        Student s = new Student();
        const int MAX = 100;
        
        //생성자 상위폼의 학생클래스와 학과 정보 받아와야 됨.
        public addstudent(Student main_S, List<Major> major_list)
        {
            InitializeComponent();
            button2.Enabled = false;
            s = main_S;
            major = major_list;
            foreach (Major majordata in major) {
                list_Major.Items.Add(majordata.Name);
            }

        }
        //선택학과 출력
        private Major find_major(List<Major> m, string item)
        {
            
            for(int i = 0; i < m.Count; i++) { 
                if (item == m[i].Name)
                { return m[i];}
            }
            Major Null=new Major();
            Null.Name = "오류";
            Null.Code = "0";
            return Null;
        }
        //클래스 생성하여 메인 폼으로 전달
        private void button2_Click(object sender, EventArgs e)
        {

            name_textBox.Text = checked_radio(name_textBox.Text, radio_man);
            name_textBox.Text = checked_radio(name_textBox.Text, radio_woman);

            s.Name = name_textBox.Text;
            s.Code = code_textBox.Text;

            s.Grade = grade;
            if (grade >= 4) { s.G_string = "A"; }
            else if (grade >= 3) { s.G_string = "B"; }
            else if (grade >= 2.5) { s.G_string = "C"; }
            else if (grade >= 2) { s.G_string = "D"; }
            else { s.G_string = "F"; }


            if (date_textBox.Text == "") { s.Age = 0; }
            else
            { s.Age = (DateTime.Today.Year - int.Parse(date_textBox.Text)); }
            s.Major = list_Major.SelectedItem.ToString();
            this.Close();
        }

        //성적평균 산출
        private void lab_average_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            grade = 0;

            if (cb_1.Checked)
            {
                grad1 = double.Parse(txt_1grade.Text);
                count += 1;
                grade += grad1;
            }
            if (cb_2.Checked)
            {
                grad2 = double.Parse(txt_2grade.Text);
                count += 1;
                grade += grad2;
            }
            if (cb_3.Checked)
            {
                grad3 = double.Parse(txt_3grade.Text);
                count += 1;
                grade += grad3;
            }
            if (cb_4.Checked)
            {
                grad4 = double.Parse(txt_4grade.Text);
                count += 1;
                grade += grad4;
            }
            //성적은 0에서 4.5까지만 입력 가능하다.
            if (grad1 > 4.5 || grad1 < 0) { MessageBox.Show("1학년 성적을 다시 입력하시오."); txt_1grade.Text = "0"; return; }
            if (grad2 > 4.5 || grad2 < 0) { MessageBox.Show("2학년 성적을 다시 입력하시오."); txt_2grade.Text = "0"; return; }
            if (grad3 > 4.5 || grad3 < 0) { MessageBox.Show("3학년 성적을 다시 입력하시오."); txt_3grade.Text = "0"; return; }
            if (grad4 > 4.5 || grad4 < 0) { MessageBox.Show("4학년 성적을 다시 입력하시오."); txt_4grade.Text = "0"; return; }

            if (count == 0) { grade = 0; }
            else { grade = grade / count; }
            lab_average.Text = grade.ToString("n2");
            button2.Enabled = true;
        }

        //학과list에서 선택한 학과와 학과코드 표기
        private void list_Major_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Major m = new Major();
            m = find_major(major, list_Major.SelectedItem.ToString());
            lab_major.Text = m.Code + ": " + m.Name;
        }
        //성별 선택 시 이름옆에 성별 표기
        private string checked_radio(string atstring, RadioButton radiobnt)
        {
            if (radiobnt.Checked) { atstring = atstring + "(" + radiobnt.Text + ")"; }
            return atstring;
        }
        //사진불러오기
        private void btn_loadPicture_Click(object sender, EventArgs e)
        {   
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                picture_face.Image = img;
            }
            name_textBox.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
        }


    }
}
