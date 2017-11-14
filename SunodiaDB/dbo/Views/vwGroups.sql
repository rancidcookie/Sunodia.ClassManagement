
CREATE VIEW [dbo].vwGroups
	AS SELECT g.GroupName, Concat(p.FirstName, ' ', p.LastName) as FullName, p.* FROM People p
	Left Outer Join PersonGroups pg ON p.id = pg.PersonId
	Left Outer Join dbo.[Groups] g ON pg.GroupId = g.id