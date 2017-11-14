CREATE VIEW [dbo].vwRegistrationTotals
	AS 
	SELECT ca.ClassId, r.Description, sum(ca.paid) as Total 
	FROM ClassAttendees ca
	JOIN RegistrationTypes r ON ca.RegistrationTypeId = r.Id
	GROUP BY ca.ClassId,r.Id,r.Description