using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp.Data.SqlServer.Constants
{
	public static class EventConstants
	{
		// employee status

		public const string NewCandidate = "NEW CANDIDATE";
		public const string Processed = "PROCESSED";
		public const string EmployeeCreated = "EMPLOYEE CREATED";
		public const string Removed = "REMOVED";
		public const string Exception = "EXCEPTION";
		public const string Replaced = "REPLACED";
		public const string Blocked = "BLOCKED";

		// recall status
		public const string Created = "CREATED";
		public const string Scanned = "SCANNED";

		// package event types

		public const string FileImport = "FILEIMPORT";
		public const string Reprint = "REPRINT";
		public const string AutoScan = "AUTOSCAN";
		public const string ManualScan = "MANUALSCAN";
		public const string RepeatScan = "REPEATSCAN";
		public const string RateAssigned = "RATEASSIGNED";
		public const string RateUpdated = "RATEUPDATED";
		public const string ContainerChanged = "CONTAINERCHANGED";
		public const string ForcedException = "FORCEDEXCEPTION";
		public const string ManualRecall = "MANUALRECALL";
		public const string ManualRelease = "MANUALRELEASE";
		public const string ManualReturn = "MANUALRETURN";
		public const string EodProcessed = "EODPROCESSED";
		public const string Shipped = "SHIPPED";
		public const string ApiCreated = "APICREATED";

		// job
		public const string JobScan = "JOBSCAN";
		public const string JobStarted = "STARTED";
	}
}
