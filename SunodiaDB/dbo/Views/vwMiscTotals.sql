

CREATE VIEW [dbo].[vwMiscTotals]
	AS 
	SELECT ca.ClassId, e.Description, p.PaymentMethod, Sum(ca.Paid) As TotalPaid 
FROM ClassAttendees ca
JOIN Events e ON ca.ClassId = e.id 
JOIN PaymentMethods p ON ca.PaymentTypeId = p.Id 
Group By ca.Classid, e.Description, p.id, p.PaymentMethod