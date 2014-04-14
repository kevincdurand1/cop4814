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

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IStockPriceService
{

    [OperationContract]
    StockData[] GetDateRange(DateTime start, DateTime stop);

    [OperationContract]
    StockData[] GetMovingAverage(DateTime start, DateTime stop, int days);


}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class StockData
{
    private int p1;
    private int p2;
    private int p3;
    private int p4;
    private int p5;
    private int p6;
    private int p7;

    public StockData(DateTime date, double open, double high, double low, double close, double volume, double adjClose)
    {
        sDate = date;
        sOpen = open;
        sHigh = high;
        sLow = low;
        sClose = close;
        sVolume = volume;
        sAdjClose = adjClose;
    }

    public StockData(int p1, int p2, int p3, int p4, int p5, int p6, int p7)
    {
        // TODO: Complete member initialization
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
        this.p5 = p5;
        this.p6 = p6;
        this.p7 = p7;
    }
    [DataMember]
    public DateTime sDate { get; set; }

    [DataMember]
    public double sClose { get; set; }

    [DataMember]
    public double sOpen { get; set; }

    [DataMember]
    public double sHigh { get; set; }

    [DataMember]
    public double sLow { get; set; }

    [DataMember]
    public double sVolume { get; set; }

    [DataMember]
    public double sAdjClose { get; set; }


}