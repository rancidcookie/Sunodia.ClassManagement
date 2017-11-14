using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using eEvent = Eventbrite.Models.Event;
using sEvent = FHI.Models.Event;

using Sunodia.ClassManagement.Models;

namespace Sunodia.ClassManagement.Extensions
{
    public static class EventExtensions
    {
        public static PaymentExpenses CalculatPaymentExpenses(this Event inEvent)
        {
            PaymentExpenses retVal = new PaymentExpenses();

            foreach (var trx in inEvent.EventTransactions)
            {
                if(trx.PaymentMethodId != null)
                {
                    var newExp = new PaymentExpense((int)trx.PaymentMethodId, trx.PaymentMethod.PaymentMethod1, trx.Amount,trx.PaymentMethod.Percentage,trx.PaymentMethod.PlusFee);
                    retVal.Add(newExp);
                }
            }

            return retVal;
        }

        public static void FromEventbriteEvent(this sEvent inEvent, eEvent toLoad)
        {
            inEvent = new sEvent()
            {
                Active = true,
                StartDate = toLoad.start.ToDate(),
                EndDate = toLoad.end.ToDate(),
                Description = toLoad.description.text,
                NickName = toLoad.name.text,
            };

        }
    }

    public class PaymentExpenses : Dictionary<int, PaymentExpense>
    {
        public decimal TotalExpense()
        {
            decimal retVal = 0;
            foreach (var item in this)
            {
                var tmpItem = (PaymentExpense)item.Value;
                retVal += tmpItem.TotalAmount;
            }

            return retVal;
        }
        public void Add(PaymentExpense pExpense)
        {
            decimal tmpExpense = pExpense.TotalAmount * pExpense.Percentage / 100 + pExpense.PlusFee;
            pExpense.TotalAmount = tmpExpense;
            if (tmpExpense > 0)
            {
                if (this.ContainsKey(pExpense.MethodId))
                {
                    this[pExpense.MethodId].TotalAmount += tmpExpense;
                }
                else
                {
                    this.Add(pExpense.MethodId, pExpense);
                }
            }
        }
    }

    public class PaymentExpense
    {
        public string Name = "";
        public int PaymentMethodId = 0;
        public decimal TotalAmount = 0;
        public int MethodId = 0;
        public decimal Percentage = 0;
        public decimal PlusFee = 0;

        public PaymentExpense(int id, string name, decimal amount, decimal percentage, decimal plusFee)
        {
            MethodId = id;
            Percentage = percentage;
            PlusFee = plusFee;
            Name = name;
            TotalAmount = amount;
        }
    }

}