
CREATE VIEW [dbo].vwFullPeople
AS SELECT p.*, 
	(SELECT g.GroupName FROM PersonGroups ps LEFT OUTER JOIN Groups g ON g.Id = ps.GroupId WHERE ps.PersonId = p.id and (g.GroupName = 'Donor' OR g.GroupName Is Null)) as Donor,
	(SELECT g.GroupName FROM PersonGroups ps LEFT OUTER JOIN Groups g ON g.Id = ps.GroupId WHERE ps.PersonId = p.id and (g.GroupName = 'Student' OR g.GroupName Is Null)) as Student,
	(SELECT g.GroupName FROM PersonGroups ps LEFT OUTER JOIN Groups g ON g.Id = ps.GroupId WHERE ps.PersonId = p.id and (g.GroupName = 'Client' OR g.GroupName Is Null)) as Client,
	(SELECT g.GroupName FROM PersonGroups ps LEFT OUTER JOIN Groups g ON g.Id = ps.GroupId WHERE ps.PersonId = p.id and (g.GroupName = 'Ministry Partner' OR g.GroupName Is Null)) as MinistryPartner,
	(SELECT g.GroupName FROM PersonGroups ps LEFT OUTER JOIN Groups g ON g.Id = ps.GroupId WHERE ps.PersonId = p.id and (g.GroupName = 'Mail Chimp' OR g.GroupName Is Null)) as MailChimp
	FROM People p