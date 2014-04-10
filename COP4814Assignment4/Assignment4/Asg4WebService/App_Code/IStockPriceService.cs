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
	[DataMember]
	public DateTime sDate{ get; set; }

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
