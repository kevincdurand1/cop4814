/**
 * Assignment by
 * Leonardo Menendez
 * Robert Gomez
 */
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
	
	public Account(String accountId){
		this();
		this.accountId = accountId;
	}

	public String getId() {
		return accountId;
	}

	public void setId(String accountId) {
		this.accountId = accountId;
	}

	public List<Portfolio> getPortfolios() {
		return this.portfolios;
	}
	
	@Override
	public String toString(){
		return String.format("Account %s \n %s \n", getId(), getPortfolios().toString());
	}
	
	@Override
	public Iterator<Portfolio> iterator() {
		return portfolios.iterator();
	}
	
	@Override
	public boolean equals(Object obj){
		if(obj instanceof Account)
			return ((Account)obj).getId().equals(this.accountId);
		//Not an instance of Account, let Object handle it
		return super.equals(obj);
	}

	@Override
	public int compareTo(Account acc) {
		return acc.getId().compareTo(this.accountId);
	}

}
