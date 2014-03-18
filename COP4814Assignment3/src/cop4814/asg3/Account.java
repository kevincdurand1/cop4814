package cop4814.asg3;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;

public class Account implements Comparable<Account>, Iterable<Portfolio> {
	private String accountId;
	private List<Portfolio> portfolios = new LinkedList<Portfolio>();
	
	public Account() {
		// TODO Auto-generated constructor stub
	}

	public String getAccountId() {
		return accountId;
	}

	public void setAccountId(String accountId) {
		this.accountId = accountId;
	}

	public List<Portfolio> getPortfolios() {
		return this.portfolios;
	}
	
	@Override
	public Iterator<Portfolio> iterator() {
		return portfolios.iterator();
	}
	
	@Override
	public boolean equals(Object obj){
		if(obj instanceof Account)
			return ((Account)obj).getAccountId().equals(this.accountId);
		//Not an instance of Account, let Object handle it
		return super.equals(obj);
	}

	@Override
	public int compareTo(Account acc) {
		return acc.getAccountId().compareTo(this.accountId);
	}

}
