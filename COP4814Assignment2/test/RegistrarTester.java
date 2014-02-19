import static org.junit.Assert.*;

import org.junit.Test;


public class RegistrarTester{
	Registrar registrar = new Registrar();

	@Test
	public void testProbLowerTrue(){
		assertTrue("Status Probation Year Lower with 5 credits", 
				   registrar.canRegister(Status.Probation, YearLevel.LowerDivision, 0.0, 5));
	}

	@Test
	public void testProbLowerFalse(){
		assertFalse("Status Probation Year Lower with 5 credits", 
				   registrar.canRegister(Status.Probation, YearLevel.LowerDivision, 0.0, 8));
	}

	@Test
	public void testGradLowGpaTrue(){
		assertTrue("Graduate, GPA <3.0 with 6 credits",
				registrar.canRegister(Status.Unknown, YearLevel.Graduate, 2.8, 6));
	}

	@Test
	public void testGradLowGpaFalse(){
		assertFalse("Graduate, GPA <3.0 with 12 credits",
				registrar.canRegister(Status.Unknown, YearLevel.Graduate, 2.8, 12));
	}

	@Test
	public void testGradHighGpaTrue(){
		assertTrue("Graduate, GPA >3.0 with 12 credits",
				registrar.canRegister(Status.Unknown, YearLevel.Graduate, 3.4, 12));
	}

	@Test
	public void testGradHighGpaFalse(){
		assertFalse("Graduate, GPA >3.0 with 15 credits",
				registrar.canRegister(Status.Unknown, YearLevel.Graduate, 3.4, 15));
	}

	@Test
	public void testNormalLowerHighGpaTrue(){
		assertTrue("Status Normal, Lower Division, GPA >2.5 with 9 credits",
				registrar.canRegister(Status.Normal, YearLevel.LowerDivision, 3.2, 15));
	}

	@Test
	public void testNormalLowerHighGpaFalse(){
		assertFalse("Status Normal, Lower Division, GPA >2.5 with 15 credits",
				registrar.canRegister(Status.Normal, YearLevel.LowerDivision, 3.2, 22));
	}
	
	@Test
	public void testNormalLowerLowGpaTrue(){
		assertTrue("Status Normal, Lower Division, GPA <2.5 with 9 credits",
				registrar.canRegister(Status.Normal, YearLevel.LowerDivision, 2.5, 9));
	}

	@Test
	public void testNormalLowerLowGpaFalse(){
		assertFalse("Status Normal, Lower Division, GPA <2.5 with 15 credits",
				registrar.canRegister(Status.Normal, YearLevel.LowerDivision, 2.5, 15));
	}
	
	@Test
	public void testNormalUpperTrue(){
		assertTrue("Status Normal, Upper Division with 16 credits",
				registrar.canRegister(Status.Normal, YearLevel.UpperDivision, 0.0, 16));
	}

	@Test
	public void testNormalUpperFalse(){
		assertFalse("Status Normal, Upper Division with 21 credits",
				registrar.canRegister(Status.Normal, YearLevel.UpperDivision, 0.0, 21));
	}

	@Test
	public void testHonorsHighAvgTrue(){
		assertTrue("Status Honors, GPA >3.0 with 20 credits",
				registrar.canRegister(Status.Honors, YearLevel.Unknown, 3.2, 20));
	}
	
	@Test
	public void testHonorsHighAvgFalse(){
		assertFalse("Status Honors, GPA <3.0 with 24 credits",
				registrar.canRegister(Status.Honors, YearLevel.Unknown, 3.2, 24));
	}
	
	@Test
	public void testHonorsLowAvgTrue(){
		assertTrue("Status Honors, GPA <3.0 with 12 credits",
				registrar.canRegister(Status.Honors, YearLevel.Unknown, 2.7, 12));
	}
	
	@Test
	public void testHonorsLowAvgFalse(){
		assertFalse("Status Honors, GPA <3.0 with 18 credits",
				registrar.canRegister(Status.Honors, YearLevel.Unknown, 2.7, 18));
	}

}
