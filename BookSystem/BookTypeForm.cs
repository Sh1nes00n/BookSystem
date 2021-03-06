﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataFac;

namespace BookSystem
{
    public partial class BookTypeForm : Form
    {
        DataDal dal = new DataDal();

        public BookTypeForm()
        {
            InitializeComponent();
        }

        private void BookTypeForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var list = dal.getBookTypes();
            foreach(var item in list)
            {
                listBox1.Items.Add(item.name);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var list = dal.delBookType(listBox1.Items[index].ToString());
                listBox1.Items.Clear();
                foreach (var item in list)
                {
                    listBox1.Items.Add(item.name);
                }
                MessageBox.Show("删除成功");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new S_BookType()
            {
                name = textBox1.Text
            };
            var t = dal.addBookType(model);
            if (t.Item1 == 1)
            {
                listBox1.Items.Clear();
                foreach (var item in t.Item2)
                {
                    listBox1.Items.Add(item.name);
                }
                MessageBox.Show("添加成功");
            }
            else
                MessageBox.Show(t.Item3.ToString());
            
        }
    }
}
