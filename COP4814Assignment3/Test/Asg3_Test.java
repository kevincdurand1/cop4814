/**
 * Test program for COP 4814 Assignmet 3, Spring 2014.
 */

import cop4814.asg3.*;

import java.util.List;
import java.util.Map;

public class Asg3_Test {
	
	AccountManager man = new AccountManager();
	
	void test_1() {

		System.out.println("----------- Account Stock Valuations --------------" );
		for( Account acc : man.getAccounts() ) {				
			double holdings = man.getStockValuation( acc.getId() );
			System.out.printf("Account %s's stock is valued at %.2f\n", acc.getId(), holdings );
		}
		
		System.out.println("\n------------- All cash balances : --------------- ");
		Map<String,Double> map = man.getCashBalances();
		for( Map.Entry<String,Double> entry : map.entrySet() ) {
			System.out.printf("Acct %s's cash balance is %.2f\n", entry.getKey(), entry.getValue() );
		}
		
	} // test_1
	
	void test_2()  {
		
		String ticker = "IBM";			// ** this may change **
		System.out.println("\n------------- Stock Owners : --------------- ");
	
		for( Map.Entry<String,Integer> entry : man.getStockOwners( ticker ).entrySet() ) {
			System.out.printf("Account %s owns %d shares of %s\n", 
					entry.getKey(), entry.getValue(), ticker );
		}
		
		System.out.println("\n-----Portfolios Balances (high to low) ---------- ");
		List<Portfolio> portfolios = man.getPortfoliosByCashBalances();
		for( Portfolio port : portfolios)
			System.out.printf("Portfolio %s's cash balance = %.2f\n", port.getId(), port.getCashBalance() );
		
		System.out.println("\n------------- All investments: --------------- ");
		for( Investment inv : man.getInvestmentList() ) {
			System.out.println( inv );
		}
	}

	void start() {
		
		if( man.readAccountsFile("portfolio_input.txt") ) {
			test_1();
			test_2();
		}
		else
			System.out.println("Cannot open input file ");
		
	}	
	
	public static void main(String[] args) {
		
		new Asg3_Test().start();
	}

}
