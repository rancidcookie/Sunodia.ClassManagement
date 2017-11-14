CREATE VIEW [dbo].[vwStudentTotals]
	AS 
	
	SELECT classid, count(*) as StudentCount, sum(paid) as TotalPaid 
	 FROM ClassAttendees
	 GROUP BY classid