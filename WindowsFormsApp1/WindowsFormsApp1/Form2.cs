using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        // 件数
        private int sumUnit = 0;

        // 总价
        private double sumPrice = 0.00;

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// 关闭、退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            DataGridViewCheckBoxCell cell1 = new DataGridViewCheckBoxCell();
            row.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Value = dataGridView1.RowCount + 1;
            row.Cells.Add(cell2);

            DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
            cell3.Value = "AAA";
            row.Cells.Add(cell3);

            DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
            cell4.Value = "11.1";
            row.Cells.Add(cell4);

            DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
            cell5.Value = "6";
            row.Cells.Add(cell5);

            DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();
            cell6.Value = Convert.ToDouble(cell4.Value) * Convert.ToInt32(cell5.Value);
            row.Cells.Add(cell6);

            dataGridView1.Rows.Add(row);
            // 更新总价和总件数
            updateSumCountPrice(1, Convert.ToDouble(cell4.Value), Convert.ToInt32(cell5.Value));
        }

        /// <summary>
        /// 更新合计标签
        /// </summary>
        /// <param name="type">1-增加，2-删减</param>
        /// <param name="price">单价</param>
        /// <param name="unit">单品个数</param>
        private void updateSumCountPrice(int type, double price, int unit)
        {
            if (type == 1)
            {
                sumUnit += unit;
                sumPrice += price * unit;
            }
            else if (type == 2)
            {
                sumUnit -= unit;
                sumPrice -= price * unit;
            }
            label2.Text = "合计：" + sumUnit + "件，" + sumPrice + "元";
        }

        /// <summary>
        /// 删除 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewCheckBoxCell tempCell = (DataGridViewCheckBoxCell) dataGridView1.Rows[i].Cells[0];
                // checkedbox被勾选
                if (tempCell.EditedFormattedValue.Equals(true))
                {
                    // 更新总价，总件数
                    updateSumCountPrice(2,
                        Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));
                    // 删除行
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            // 更新整个表的ID值
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = i + 1;
            }
        }

        /// <summary>
        /// 结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            // 件数
            int calcSumUnit = 0;
            // 总价
            double calcSumPrice = 0.00;
            // 重新统计总件数和总价
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                calcSumUnit += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                calcSumPrice += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) *
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            DialogResult calDialogResult = MessageBox.Show("合计：" + calcSumUnit + "件，" + calcSumPrice + "元",
                " 结算",
                MessageBoxButtons.OKCancel
            );
            // 结算确认，清屏
            if (calDialogResult == DialogResult.OK)
            {
                sumUnit = 0;
                sumPrice = 0.00;
                label2.Text = "合计：" + sumUnit + "件，" + sumPrice + "元";
                dataGridView1.Rows.Clear();
                
            }
        }
    }
}