


CREATE VIEW [dbo].vwEventTransactions
	AS SELECT ev.Id, ev.EventId,ev.Description,ev.Amount,ev.FHICredit,ev.DateAdded, ev.PaymentMethodId, ets.StudentId, ets.RegistrationTypeId, r.Description as RegistrationType, p.PaymentMethod, tc.Id as CategoryId,tc.Category, (ev.amount * pm.percentage/100 + pm.plusfee) as fee
	FROM EventTransaction ev
	LEFT OUTER JOIN EventTransactionStudent ets ON ev.Id = ets.EventTransactionId
	LEFT OUTER JOIN RegistrationTypes r ON ets.RegistrationTypeId = r.Id
	LEFT OUTER JOIN PaymentMethods p ON ev.PaymentMethodId = p.Id
	LEFT OUTER JOIN TransactionCategory tc ON ev.TransactionCategoryId = tc.Id
	LEFT OUTER JOIN PaymentMethods pm ON ev.PaymentMethodId = pm.Id
