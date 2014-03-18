package cop4814.asg3;

import java.util.List;
import java.util.Map;

public class AccountManager {
	private Map<String, Account> accounts;

	public AccountManager() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * Read a text file containg several accounts, store this information 
	 * in the accounts Map. 
	 * @param filename - Path to File
	 * @return True if successful.
	 */
	public boolean readAccountsFile(String filename){
		return false;
	}

	/**
	 * Returns a List of all accounts.
	 * @return
	 */
	public List<Account> getAccounts(){
		return null;
	}

	/**
	 * Returns a list all stocks (investments), sorted in ascending 
	 * order by ticker symbol.
	 * @return
	 */
	public List<Investment> getInvestmentList(){
		return null;
	}

	/**
	 * If the account ID is found, this method returns the sum 
	 * value of all stock holdings in a single account not counting cash 
	 * balances. If the account is not found, return -1.0
	 * @param accountId
	 * @return
	 */
	public double getStockValuation(String accountId){
		return -1D;
	}

	/**
	 * Returns a Map of all account ID's and their cash balances. The 
	 * accounts must be ordered by account ID.
	 * @return
	 */
	public Map<String, Double> getCashBalances(){
		return null;
	}

	/**
	 * Returns an Map of account IDs and number of shares for each
	 * account that owns the stock identified by the ticker parameter. 
	 * The map should be sorted by account ID
	 * @param ticker
	 * @return
	 */
	public Map<String, Integer> getStockOwners(String ticker){
		return null;
	}

	/**
	 * 	Returns a list of all Portfolios, sorted in descending order 
	 * by their cash balances.
	 * @return
	 */
	public List<Portfolio> getPortfoliosByCashBalances(){
		return null;
	}
}
