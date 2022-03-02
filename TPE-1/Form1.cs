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
            var model = new List<List<double>>();
            var k = (double)nudFactors.Value;
        }

        private void CreateTable(List<List<double>> model)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            


        }
    }
}
