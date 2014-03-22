package cop4814.asg3;

public class Investment implements Comparable<Investment> {
	private String ticker; //unique Identifier for stocks
	private int numShares;
	private double price;
	
	public Investment() {
		// TODO Auto-generated constructor stub
	}
	
	public Investment(String ticker){
		this();
		this.ticker = ticker;
	}
	
	public Investment(String ticker, int numShares){
		this(ticker);
		this.numShares = numShares;
	}
	
	public Investment(String ticker, int numShares, double price){
		this(ticker, numShares);
		this.price = price;
	}
	
	public String getTicker() {
		return this.ticker;	
	}
	
	public void setTicker(String ticker) {
		this.ticker = ticker;
	}

	public int getNumShares() {
		return numShares;
	}

	public void setNumShares(int numShares) {
		this.numShares = numShares;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}
	
	@Override
	public String toString(){
		return String.format("(%s, %d shares @ $%.2f)", getTicker(), getNumShares(), getPrice());
	}

	@Override
	public boolean equals(Object object){
		if(object instanceof Investment)
			return ((Investment)object).getTicker().equalsIgnoreCase(this.ticker);
		//not an Investment let Object handle it
		return super.equals(object);
	}
	
	@Override
	public int compareTo(Investment inv) {
		int compareTicker = inv.getTicker().compareTo(this.ticker);
		return compareTicker!=0?compareTicker:(inv.numShares-this.numShares);
	}

}
