import static org.junit.Assert.*;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import cop4814.asg3.AccountManager;


public class MyTests {
	private AccountManager manager;
	
	@Before
	public void setup(){
		manager = new AccountManager();
	}

	@Test
	public void testInputFile(){
		System.out.println(System.getProperty("user.dir"));
		String file = "portfolio_input.txt";
		assertTrue("Test if able to read file", manager.readAccountsFile(file));
	}
	
	@After
	public void print(){
		System.out.print(manager.getAccounts().toString());
	}
}
