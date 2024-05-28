using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем названия графиков в ListBox
            listBoxGraphs.Items.Add("y = k * ln(x + b)");
            listBoxGraphs.Items.Add("y = ax^2 + bx + c");
            listBoxGraphs.Items.Add("y = k * sin(x + b)");

            // Настройка Chart
            chart.Series.Clear();
            chart.ChartAreas.Add(new ChartArea("MainArea"));
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            // Очистка графика
            chart.Series.Clear();

            // Получение выбранного графика
            int selectedIndex = listBoxGraphs.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите график из списка.");
                return;
            }

            // Получение и проверка коэффициентов
            if (!double.TryParse(textBox1.Text, out double coef1) ||
                !double.TryParse(textBox2.Text, out double coef2) ||
                !double.TryParse(textBox3.Text, out double coef3))
            {
                MessageBox.Show("Пожалуйста, введите корректные коэффициенты.");
                return;
            }

            // Получение и проверка начальных координат
            double x0 = (double)numericUpDownX0.Value;
            double y0 = (double)numericUpDownY0.Value;

            // Построение графика
            Series series = new Series("Graph");
            series.ChartType = SeriesChartType.Line;

            for (double x = -10; x <= 10; x += 0.1)
            {
                double y = 0;
                switch (selectedIndex)
                {
                    case 0:
                        y = coef1 * Math.Log(x + coef2);
                        break;
                    case 1:
                        y = coef1 * x * x + coef2 * x + coef3;
                        break;
                    case 2:
                        y = coef1 * Math.Sin(x + coef2);
                        break;
                }

                // Применение сдвига начала координат
                x += x0;
                y += y0;

                series.Points.AddXY(x, y);
            }

            chart.Series.Add(series);
        }

        private void numericUpDownX0_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
