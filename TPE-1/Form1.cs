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
        List<List<int>> savedColumns;

        public Form1()
        {
            InitializeComponent();
        }

        void btnApply_Click(object sender, EventArgs e)
        {
            var isPFE = rbPFE.Checked;
            var k = (int)nudFactors.Value;
            var p = (int)nudEffects.Value;
            var v = (int)nudVar.Value;

            
            if (!isPFE)
            {
                k = (int)nudFactors.Value - p;
                var effects = GetGroups(k);

                if (p > effects)
                {
                    MessageBox.Show($"Линейных эффектов должно быть не более {effects}", "Ошибка");
                    return;
                }
            }

            var model = isPFE ? PFE(k, v) : DFE(k, p, v);
            CreateTable(model, k);
        }

        int GetGroups(int k)
        {
            var result = 0;
            for (int i = 2; i <= k; i++)
                result += GetGroup(k, i);

            return result;
        }

        int GetGroup(int k, int m)
        {
            return (int)((Fact(k)) / (Fact(m) * Fact(k - m)));
        }

        List<List<double>> PFE(int k, int v)
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

        List<List<double>> DFE(int k, int p, int v)
        {
            var model = PFE(k, v);
            var all = Math.Pow(v, k);
            for (int i = 0; i < all; i++)
                for (int j = 0; j < p; j++)
                    model[i].Add(0);

            int effects;
            List<List<int>> columns = new List<List<int>>();
            int added = 0;
            bool isExit = false;

            // пары, тройки, четверки...
            for (int group = 2; group <= k; group++)
            {
                effects = GetGroup(k, group);
                for (int add = 0; add < effects; add++)
                {
                    columns.Add(new List<int>());
                    added++;

                    // сочетание для столбца
                    columns[added - 1] = NextSet(
                            added == 1 ? null : columns[added - 2],
                            k,
                            group
                        );

                    for (int row = 0; row < all; row++)
                    {
                        // перемножаем сочетание
                        model[row][k + added - 1] = columns[added - 1].Aggregate(1.0, 
                            (acc, b) => 
                                acc * model[row][b - 1]
                            );
                    }

                    if (added >= p)
                    {
                        isExit = true;
                        break;
                    }     
                }

                if (isExit)
                    break;
            }

            savedColumns = columns;
            return model;
        }

        // Факториал
        long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }

        // Получить следующее сочентание из n по m
        List<int> NextSet(List<int> a, int n, int m)
        {
            var result = a != null 
                ? new List<int>(a) 
                : new List<int>();

            // первое заполнение
            if (result.Count != m)
            {
                result.Clear();
                for (int i = 1; i <= m; i++)
                    result.Add(i);

                return result;
            }

            int k = m;

            for (int i = k - 1; i >= 0; --i)
                if (result[i] < n - k + i + 1)
                {
                    result[i]++;
                    for (int j = i + 1; j < k; ++j)
                        result[j] = result[j - 1] + 1;
                    return result;
                }
            return result;
        }

        double GetVaried(int elem, int full)
        {
            var part = 2.0 / (full - 1);
            return -1 + (part * elem);
        }

        void CreateTable(List<List<double>> model, int k)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            string name;
            for (int col = 0; col < model[0].Count; col++)
            {
                if (col < k)
                    name = $"x{col + 1}";
                else
                    name = savedColumns[col - k].Aggregate("", (acc, el) => acc + $"x{el}");
                   
                grid.Columns.Add(name, name);

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

        void rbPFE_CheckedChanged(object sender, EventArgs e)
        {
            nudEffects.Visible = rbDFE.Checked;
            label3.Visible = rbDFE.Checked;
        }
    }
}
