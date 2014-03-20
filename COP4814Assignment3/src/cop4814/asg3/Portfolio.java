package cop4814.asg3;

import java.util.LinkedList;
import java.util.List;

public class Portfolio implements Comparable<Portfolio> {
	private String portfolioId;
	private double cashBalance;
	private List<Investment> holdings = new LinkedList<Investment>();

	public Portfolio() {

	}
	
	public Portfolio(String portfolioId){
		this();
		this.portfolioId = portfolioId;
	}
	
	public Portfolio(String portfolioId, Double cashBalance){
		this(portfolioId);
		this.cashBalance = cashBalance;
	}

	public String getId() {
		return portfolioId;
	}

	public void setId(String portfolioId) {
		this.portfolioId = portfolioId;
	}

	public double getCashBalance() {
		return cashBalance;
	}

	public void setCashBalance(double cashBalance) {
		this.cashBalance = cashBalance;
	}
	
	public List<Investment> getHoldings() {
		return this.holdings;
	}
	
	@Override
	public String toString(){
		return String.format("Portfolio: %s Balance:%f \n %s\n", getId(), getCashBalance(), getHoldings().toString());
	}
		
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Portfolio)
			return ((Portfolio)obj).getId().equalsIgnoreCase(this.portfolioId);
		//not an instance of Portfolio, let Object handle it
		return super.equals(obj);
	}

	@Override
	public int compareTo(Portfolio port) {
		return port.getId().compareTo(this.portfolioId);
	}

}
