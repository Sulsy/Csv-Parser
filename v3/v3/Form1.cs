using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            String path = textBox1.Text;ClassLibrary1.Parse.razdel = Convert.ToChar(textBox2.Text);
            List<List<object>> list = (ClassLibrary1.Transorm.TransormToTwoList(@path));
            for (Int32 j = 0; j < list.Count; j++)
            {
                dataGridView1.RowCount = list.Count;
                dataGridView1.ColumnCount = list[j].Count;
                
                for (Int32 i = 0; i < (list[j].Count-1); i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = list[j][i];
                    DataGridViewColumn column = dataGridView1.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String path =textBox1.Text; ClassLibrary1.Parse.razdel = Convert.ToChar(textBox2.Text);
            Boolean sort =false;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sort = true;
            }
            
            List<List<object>> list = (ClassLibrary1.Transorm.TransormToTwoList(sort, @path));
            for (Int32 j = 0; j < list.Count; j++)
            {
                dataGridView1.RowCount = list.Count;
                dataGridView1.ColumnCount = list[j].Count;

                for (Int32 i = 0; i < (list[j].Count - 1); i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = list[j][i];
                    DataGridViewColumn column = dataGridView1.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            String path = textBox1.Text; ClassLibrary1.Parse.razdel = Convert.ToChar(textBox2.Text);
            Boolean sort = false;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sort = false;
            }

            List<List<Object>> list = (ClassLibrary1.Transorm.TransormToTwoList(sort, @path));
            for (Int32 j = 0; j < list.Count; j++)
            {
                dataGridView1.RowCount = list.Count;
                dataGridView1.ColumnCount = list[j].Count;

                for (Int32 i = 0; i < (list[j].Count - 1); i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = list[j][i];
                    DataGridViewColumn column = dataGridView1.Columns[i];
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }
    }
}
