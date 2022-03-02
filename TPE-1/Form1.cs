using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPE_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var isPFE = rbPFE.Checked;
            var k = (int)nudFactors.Value;
            var p = (int)nudEffects.Value;
            var v = (int)nudVar.Value;

            if (!isPFE && k <= p)
            {
                MessageBox.Show("Линейных эффектов должно быть меньше факторов", "Ошибка");
                return;
            }

            var model = isPFE ? PFE(k, v) : DFE(k, p, v);
            CreateTable(model);
        }

        private List<List<double>> PFE(int k, int v)
        {
            var model = new List<List<double>>();
            var all = Math.Pow(v, k);

            for (int i = 0; i < all; i++)
            {
                model.Add(new List<double>());
                for (int j = 0; j < k; j++)
                {
                    model[i].Add(0);
                }
            }
                

            int parts, step, row;
            for (int col = 0; col < k; col++)
            {
                step = (int)Math.Pow(v, col);
                parts = (int)(all / step);
                for (int i = 0; i < parts; i++)
                {
                    for (int iter = 0; iter < step; iter++)
                    {
                        row = i * step + iter;
                        model[row][col] = GetVaried(i % v, v);
                    }
                }
            }

            return model;
        }

        private List<List<double>> DFE(int k, int p, int v)
        {
            var model = PFE(k, v);
            var all = Math.Pow(v, k);
            for (int i = 0; i < all; i++)
            {
                for (int j = k - p - 1; j < k; j++)
                {
                    model[i].Add(0);
                }
            }

            for (int i = 0; i < p; i++)
            {
                // 2

            }

            return model;
        }

        private double GetVaried(int elem, int full)
        {
            var part = 2.0 / (full - 1);
            return -1 + (part * elem);
        }

        private void CreateTable(List<List<double>> model)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            for (int col = 0; col < model[0].Count; col++)
            {
                grid.Columns.Add($"x{col + 1}", $"x{col + 1}");

                for (int row = 0; row < model.Count; row++)
                {
                    if (col == 0)
                    {
                        grid.Rows.Add(new DataGridViewRow()
                        {
                            HeaderCell = new DataGridViewRowHeaderCell() { Value = $"y{row+1}" }
                        });
                    }

                    grid.Rows[row].Cells[col].Value = model[row][col];
                }
            }

        }

        private void rbPFE_CheckedChanged(object sender, EventArgs e)
        {
            nudEffects.Visible = rbDFE.Checked;
            label3.Visible = rbDFE.Checked;
        }
    }
}
