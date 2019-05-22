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
    public partial class addMajor : Form
    {
        const int MAX = 100;
        List<Major> major = new List<Major>();
        Major majordata = new Major();
        public addMajor(List<Major> major_list)
        {
            InitializeComponent();
            major = major_list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일| *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] line = new string[MAX];
                int count = 0;

                if (File.Exists(Path.GetFullPath(sfd.FileName)))
                {
                    StreamReader rd = new StreamReader(sfd.FileName);
                    while ((line[count] = rd.ReadLine()) != null) { count++; }
                    rd.Dispose();
                }
                StreamWriter wr = new StreamWriter(sfd.FileName);
                line[count] = textBox1.Text + " " + textBox2.Text;
                for (int i = 0; i <= count; i++)
                { wr.WriteLine(line[i]); }
                wr.Dispose();
            }
            majordata.Name = textBox1.Text;
            majordata.Code = textBox2.Text;
            major.Add(majordata);
        }
    }
}
