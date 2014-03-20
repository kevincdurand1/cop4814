package cop4814.asg3;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class AccountManager {
	private Map<String, Account> accounts;

	public AccountManager() {
		accounts = new TreeMap<String, Account>();
	}

	/**
	 * Read a text file containg several accounts, store this information 
	 * in the accounts Map. 
	 * @param filename - Path to File
	 * @return True if successful.
	 */
	public boolean readAccountsFile(String filename){
		Scanner in = null;
		try{
			in = new Scanner(new File(filename));
			String[] line = null;
			final String delimiter = ",";
			if(in.hasNext()){
				int numAccounts = getInt(in.next());
				for(int a=0; a<numAccounts; a++){
					line = in.next().split(delimiter);
					String accountId = line[0];
					Account account = new Account(accountId);
					int numPortfolio = getInt(line[1]);
					for(int p=0; p<numPortfolio; p++){
						line = in.next().split(delimiter);
						String portfolioId = line[0];
						Portfolio portfolio = new Portfolio(portfolioId, getDbl(line[1]));
						int numInvestment = getInt(line[2]);
						for(int i=0; i<numInvestment; i++){
							line = in.next().split(delimiter);
							Investment investment = new Investment(line[0], getInt(line[1]), getDbl(line[2]));
							portfolio.getHoldings().add(investment);
						}
						account.getPortfolios().add(portfolio);
					}
					accounts.put(accountId, account);
				}
				return !in.hasNext();
			}
		}catch(FileNotFoundException nfe){
			System.out.println("Sorry, cannot locate file: "+filename);
		}finally{
			if(in!=null)
				in.close();
		}
		
		return false;
	}

	/**
	 * Returns a List of all accounts.
	 * @return
	 */
	public List<Account> getAccounts(){
		List<Account> list = new LinkedList<Account>();
		list.addAll(accounts.values());
		return list;
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
	
	
	private int getInt(String number){
		try{
			return Integer.parseInt(number);
		}catch(NumberFormatException nfe){
			nfe.printStackTrace();
			return -1;
		}
	}
	
	private double getDbl(String number){
		try{
			return Double.parseDouble(number);
		}catch(NumberFormatException nfe){
			nfe.printStackTrace();
			return 0D;
		}
	}

}
