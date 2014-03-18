package cop4814.asg3;

import java.util.LinkedList;
import java.util.List;

public class Portfolio implements Comparable<Portfolio> {
	private String portfolioID;
	private double cashBalance;
	private List<Investment> holdings = new LinkedList<Investment>();

	public Portfolio() {
		// TODO Auto-generated constructor stub
	}

	public String getPortfolioID() {
		return portfolioID;
	}

	public void setPortfolioID(String portfolioID) {
		this.portfolioID = portfolioID;
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
	public boolean equals(Object obj) {
		if(obj instanceof Portfolio)
			return ((Portfolio)obj).getPortfolioID().equalsIgnoreCase(this.portfolioID);
		//not an instance of Portfolio, let Object handle it
		return super.equals(obj);
	}

	@Override
	public int compareTo(Portfolio port) {
		return port.getPortfolioID().compareTo(this.portfolioID);
	}

}
