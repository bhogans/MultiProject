using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp.Data.SqlServer.Constants
{
	public static class ErrorConstants
	{
		//Candidate
		public const string CandidateNotFound = "CANDIDATE ID NOT FOUND";
		public const string CandidateNotConverted = "CANDIDATE NOT CONVERTED TO EMPLOYEE";

		//Employees
		public const string EmployeeNotFound = "EMPLOYEE ID NOT FOUND";
		public const string InvalidEmail = "INVALID EMAIL";

		// Clients

		public const string ClientNotFound = "CLIENT ID NOT FOUND";

		//Tasks

		public const string TaskNotFound = "Task ID NOT FOUND";

		public const string InvalidStatus = "INVALID STATUS";

	}
}
