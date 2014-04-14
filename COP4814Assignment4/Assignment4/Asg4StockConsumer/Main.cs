/**
 * Assignment by
 * Leonardo Menendez
 * Robert Gomez
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asg4StockConsumer.localhost;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Asg4StockConsumer
{
    public partial class Main : Form
    {
        private Color lineColor;

        public Main()
        {
            InitializeComponent();
        }

        private void allShow_Click(object sender, EventArgs e)
        {
            try
            {
                changeCursor(Cursors.WaitCursor);
                errPro.Clear();


                Button b = (Button)sender;
                lineColor = Color.Blue;

                StockData[] data = runReport(b);

                if (data != null)
                {
                    if (data.Length == 0)
                    {
                        showMessage();
                        return;
                    }
                    //  testPrint(data);
                    graphResults(data, lineColor, true);
                }
            }
            finally
            {
                changeCursor(Cursors.Default);
            }
        }


        private StockData[] runReport(Button b)
        {
            DateTime start = getDateFromInput(txtStart);
            DateTime end = getDateFromInput(txtEnd);
            if (start == default(DateTime) || end == default(DateTime))
                //we have an error in the date so exit
                return null;


            int days = 0;
            StockPriceServiceClient client = new StockPriceServiceClient();
            client.InnerChannel.OperationTimeout = new TimeSpan(0, 30, 0);
            StockData[] data;

            if (b.Name == btnAvg.Name)
            {
                try
                {
                    days = int.Parse(mskDays.Text);
                }
                catch (Exception) { }

                if (days == 0 || days > 360)
                {
                    errPro.SetError(mskDays, "To calculate Moving Average please enter a valid value between 0 and 360 days");
                    return null;
                }
                lineColor = Color.Red;
                data = client.GetMovingAverage(start, end, days);
            }
            else
            {
                data = client.GetDateRange(start, end);
            }

            return data;
        }

        private void testPrint(StockData[] data)
        {
            foreach (StockData stock in data)
            {
                Console.Out.WriteLine("Date: " + stock.sDate + " Price: " + stock.sAdjClose);
            }
        }

        private void graphResults(StockData[] data, Color lineColor, bool clear)
        {

            Series series = new Series();
            series.Color = lineColor;
            series.BorderWidth = 2;
            series.BorderDashStyle = ChartDashStyle.Solid;
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Date;
            series.YValueType = ChartValueType.Double;

            if (clear)
                chtDisplay.Series.Clear();
            chtDisplay.Series.Add(series);
            chtDisplay.Legends.Clear();

            ChartArea area = chtDisplay.ChartAreas.First();
            area.AxisX.IsStartedFromZero = false;
            area.AxisY.IsStartedFromZero = false;
            area.AxisY.LabelStyle.Format = "##0.00";

            double max = 0D;
            double min = double.MaxValue;
            foreach (StockData stock in data)
            {
                if (stock.sAdjClose > max)
                    max = stock.sAdjClose;
                if (stock.sAdjClose < min)
                    min = stock.sAdjClose;
                series.Points.AddXY(stock.sDate, stock.sAdjClose);
            }

            area.AxisY.Maximum = max + 2D;
            area.AxisY.Minimum = min - 2D;

        }

        private void changeCursor(System.Windows.Forms.Cursor c)
        {
            this.Cursor = c;
        }


        private DateTime getDateFromInput(TextBoxBase inputControl)
        {
            try
            {
                return DateTime.Parse(inputControl.Text);
            }
            catch (Exception)
            {
                try
                {
                    //Try manually
                    String[] split = Regex.Split(inputControl.Text, "[/,-]");
                    return new DateTime(int.Parse(split[2]), int.Parse(split[0]), int.Parse(split[1]));
                }
                catch (Exception)
                {
                    errPro.SetError(inputControl, "Please provide a valid Date");
                    return default(DateTime);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                changeCursor(Cursors.WaitCursor);
                errPro.Clear();

                StockData[] reg = runReport(btnShow);
                StockData[] avg = runReport(btnAvg);

                if (reg != null && avg != null)
                {
                    if (reg.Length == 0 || avg.Length == 0)
                    {
                        showMessage();
                        return;
                    }
                    testPrint(reg);
                    testPrint(avg);
                    graphResults(reg, Color.Blue, true);
                    graphResults(avg, Color.Red, false);
                }

            }
            finally
            {
                changeCursor(Cursors.Default);
            }

        }

        private void showMessage()
        {
            MessageBox.Show("Sorry, your search did not return any results", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
