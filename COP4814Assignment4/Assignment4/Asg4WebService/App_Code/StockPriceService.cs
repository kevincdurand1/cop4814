﻿/**
 * Assignment by
 * Leonardo Menendez
 * Robert Gomez
 */

using System;
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
        int daysSplit = days / 2;
        int mod = days % 2;

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



        TimeSpan adjTimeBefore = new TimeSpan(daysSplit+mod, 0, 0, 0);
        TimeSpan adjTimeAfter = new TimeSpan(daysSplit, 0, 0, 0);

        foreach (StockData stock in lstStockDataInput)
        {
            int before = stock.sDate.CompareTo(start-adjTimeBefore);//if start is earlier than stock date get -1
            int after = stop.CompareTo(stock.sDate+adjTimeAfter);//if stock date is after stop get -1
            if (before >= 0 && after >= 0)
                lstStockDataOutput.Add(stock);
        }
 
        if (lstStockDataOutput == null || lstStockDataOutput.Count < 1)
            return null;

        double sum;
        double avg = 0;


        for (int i = daysSplit; i < lstStockDataOutput.Count - (daysSplit+mod); i++)
        {
            sum = 0;
            for (int j = i - daysSplit; j < (i + daysSplit+mod); j++)
                    sum += lstStockDataOutput.ElementAt(j).sAdjClose;

                avg = sum / days;
                lstStockDataOutput.ElementAt(i).sAdjClose = avg;
        }

        //remove extra days from output
        for(int i=0; i<daysSplit+mod; i++)
            if(lstStockDataOutput.ElementAt(i).sDate.CompareTo(start) == -1)
                lstStockDataOutput.RemoveAt(i);

        for(int i=lstStockDataOutput.Count-(daysSplit+mod); i<lstStockDataOutput.Count; i++)
            if(lstStockDataOutput.ElementAt(i).sDate.CompareTo(stop) == 1)
                lstStockDataOutput.RemoveAt(i);

        return lstStockDataOutput.ToArray();
    }
}