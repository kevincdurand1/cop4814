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

namespace Asg4StockConsumer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            StockPriceServiceClient client = new StockPriceServiceClient();
            StockData[] data = client.GetDateRange(start, end);

            

        }


        private void testPrint(StockData[] data)
        {
            foreach (StockData stock in data)
            {
                Console.Out.Write("Date: " + stock.ClosingDate + " Price: " + stock.ClosingPrice);
            }
        }

    }
}
