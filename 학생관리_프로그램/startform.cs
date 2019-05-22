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
    
    public partial class StartForm : Form
    {
        public static Student s;
        List<Student> data = new List<Student>();
        ListViewItem item;
        static List<Major> major = new List<Major>();
        const int MAX = 100;
        public StartForm()
        {
            InitializeComponent();
            //폼 시작시 학과정보를 먼저 불러온다.
            MessageBox.Show("학과정보를 불러옵니다.");

            OpenFileDialog ofd = new OpenFileDialog();
            string line;
            Major tempdata;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(ofd.FileName);
                string[] tmp = new string[2];
                while ((line = rd.ReadLine()) != null)
                {
                    tempdata = new Major();
                    tmp = line.Split(' ');
                    tempdata.Name = tmp[0];

                    tempdata.Code = tmp[1];

                    major.Add(tempdata);
                }
                rd.Dispose();
            }
            this.TopMost = true;
           
        }

        // ListView에 학생 정보 하나씩 추가
        private void add_listitem(Student sdata) {
            ListViewItem item;
            item = new ListViewItem(sdata.Code);
            item.SubItems.Add(sdata.Name);
            item.SubItems.Add(sdata.Major);
            string print = sdata.Grade.ToString() + "(" + sdata.G_string + ")";
            item.SubItems.Add(print);
            listView_student.Items.Add(item);
        }
        //학생정보 추가 폼 로딩후 생성된 학생 클래스 받기
        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            s = new Student();
            addstudent Add = new addstudent(s, major);
            Add.ShowDialog();
            data.Add(s);
            add_listitem(s);
        }
        //미리 저장된 학생 정보 불어오기
        private void button2_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            OpenFileDialog ofd = new OpenFileDialog();
            string line;
            
            Student tempdata = new Student();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(ofd.FileName);
                string[] tmp = new string[5];
                while ((line = rd.ReadLine()) != null)
                {
                    tmp = line.Split(' ');
                    tempdata.Name = tmp[0];

                    tempdata.Code = tmp[1];

                    tempdata.Major = tmp[2];

                    tempdata.Grade = double.Parse(tmp[3]);

                    tempdata.G_string = tmp[4];
                    data.Add(tempdata);
                    add_listitem(tempdata);
                }
                rd.Dispose();
            }
        }
        //학과정보 추가 폼 불러오기
        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            addMajor M = new addMajor(major);
            M.ShowDialog();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_student.Items.Count; i++) {
                item = listView_student.Items[i];
                if (textBox1.Text == item.SubItems[0].Text) {
                    listView_student.Items[i].BackColor = Color.Yellow;
                }
                else
                    listView_student.Items[i].BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 데이터를 저장 합니다.");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일| *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string line;
                int count = data.Count;
                StreamWriter wr = new StreamWriter(sfd.FileName);
                foreach (Student studentdata in data)
                {
                    line = studentdata.Name + " " + studentdata.Code + " " + studentdata.Major + " " + studentdata.Grade.ToString("n2") + " " + studentdata.G_string;
                    wr.WriteLine(line);
                }
                wr.Dispose();
            }
        }

        private void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem del_i in listView_student.Items) {
                listView_student.Items.Remove(del_i);
            }
            data.RemoveRange(0, data.Count);
        }
    }
}
