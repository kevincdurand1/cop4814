﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class StockPriceService : IStockPriceService
{
    private string strPath = "http://users.cis.fiu.edu/~irvinek/cop4814/data/ulti.xml";

    public StockData[] GetDateRange(DateTime start, DateTime stop)
    {
        if (start == null || stop == null)
            throw new NullReferenceException();
        if (stop.CompareTo(start) < 0)//These dates are backwards so switch them
        {
            DateTime temp = start;
            start = stop;
            stop = temp;
        }

        List<StockData> lstStockDataInput = StockReader.Read(strPath);
        List<StockData> lstStockDataOutput = null;
        if (lstStockDataInput != null)
            lstStockDataOutput = new List<StockData>();

        foreach (StockData stock in lstStockDataInput)
        {
            int before = stock.sDate.CompareTo(start);//if start is earlier than stock date get -1
            int after = stop.CompareTo(stock.sDate);//if stock date is after stop get -1
            if (before >= 0 && after >= 0)
                lstStockDataOutput.Add(stock);
        }

        return lstStockDataOutput.ToArray();
    }

    public StockData[] GetMovingAverage(DateTime start, DateTime stop, int days)
    {

        if (start == null || stop == null)
            throw new NullReferenceException();
        if (stop.CompareTo(start) < 0)//These dates are backwards so switch them
        {
            DateTime temp = start;
            start = stop;
            stop = temp;
        }

        List<StockData> lstStockDataInput = StockReader.Read(strPath);
        List<StockData> lstStockDataOutput = null;
        if (lstStockDataInput != null)
            lstStockDataOutput = new List<StockData>();

        foreach (StockData stock in lstStockDataInput)
        {
            int before = stock.sDate.CompareTo(start);//if start is earlier than stock date get -1
            int after = stop.CompareTo(stock.sDate);//if stock date is after stop get -1
            if (before >= 0 && after >= 0)
                lstStockDataOutput.Add(stock);
        }

        StockData[] a = lstStockDataOutput.ToArray();
        double sum;
        double avg = 0;
       

        for(int i=0; i != a.Length; i++)
        {
            sum = 0;
            for (int j = 0; j != days; j++)
            {
                sum += a[i].sClose;
            }
            avg = sum / days;
            a[i].sClose = avg;
        }







        return a;
    }
}