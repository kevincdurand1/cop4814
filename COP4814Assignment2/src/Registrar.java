
public class Registrar {


	public boolean canRegister(Status status, YearLevel year, double avg, int credit){
		if(status==Status.Unknown && year != YearLevel.Graduate){
			return false;
		}
		
		if(year == YearLevel.Unknown && status != Status.Honors){
			return false;
		}
		
		if(status==Status.Probation){
			if(year==YearLevel.LowerDivision){
				if(credit>6)
					return false;
			}else if(year==YearLevel.UpperDivision){
				if(credit>3)
					return false;
			}
		}else if(status==Status.Warning){
			if(year==YearLevel.LowerDivision){
				if(avg >2.2){
					if(credit>12)
						return false;
				}else{
					if(credit>6)
						return false;
				}
			}else if(year==YearLevel.UpperDivision){
				if(avg>2.4){
					if(credit>10)
						return false;
				}else{
					if(credit>8)
						return false;
				}
			}
		}else if(status==Status.Normal){
			if(year==YearLevel.LowerDivision){
				if(avg>2.5){
					if(credit>16)
						return false;
				}else{
					if(credit>12)
						return false;
				}
			}else if(year==YearLevel.UpperDivision){
				if(credit>18)
					return false;
			}
			
		}else if(status==Status.Honors){
			if(avg<3.0){
				if(credit>16)
					return false;
			}else{
				if(credit>22)
					return false;
			}
		
		}
		
		if(year==YearLevel.Graduate){
			if(avg<3.0){
				if(credit>6)
					return false;
			}else {
				if(credit>12)
					return false;
			}
			
		}
		

		return true;
	}
	

}
