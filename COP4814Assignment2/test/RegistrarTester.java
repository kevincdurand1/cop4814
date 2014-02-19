import static org.junit.Assert.*;

import org.junit.Test;


public class RegistrarTester{
	Registrar registrar = new Registrar();

	@Test
	public void testProbLowerTrue(){
		assertTrue("Staus Probation Year Lower with 5 credits", 
				   registrar.canRegister(Status.Probation, YearLevel.LowerDivision, 0.0, 5));
	}

	@Test
	public void testProbLowerFalse(){
		assertFalse("Staus Probation Year Lower with 5 credits", 
				   registrar.canRegister(Status.Probation, YearLevel.LowerDivision, 0.0, 8));
	}
}
