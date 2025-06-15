using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace test
{
    public partial class diagrama : Form
    {
        DataGridView dataGrid;
        Chart chart1;
        public diagrama(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;

        }

        private void diagrama_Load(object sender, EventArgs e)
        {
            chart1 = new Chart { Dock = DockStyle.Fill };
            chart1.ChartAreas.Add(new ChartArea("PieChartArea"));
            chart1.Series.Add(new Series("Classes") { ChartType = SeriesChartType.Pie });
            Controls.Add(chart1);
            GeneratePieChart();
        }

        private void GeneratePieChart() // Генерация круговой диаграммы
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                for (int i = 1; i < row.Cells.Count; i++)
                {
                    string value = row.Cells[i].Value?.ToString() ?? "";
                    if (string.IsNullOrEmpty(value)) continue;

                    if (!counts.ContainsKey(value))
                        counts[value] = 0;

                    counts[value]++;
                }
            }
            chart1.Series["Classes"].Points.Clear();
            foreach (var kvp in counts)
            {
                chart1.Series["Classes"].Points.AddXY(kvp.Key, kvp.Value);
            }
        }
    }
}
