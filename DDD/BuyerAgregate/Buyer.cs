#nullable enable
using System;
using System.Collections.Generic;

namespace DDD.BuyerAgregate
{
    //покупатель
    public class Buyer
    {
        public Guid Id { get; set; }
        public BuyerRoot BuyerRoot { get; set; }

        public TypeOfPaymentMethod PaymentMethod { get; set; }

        public PaymentSystem? CardType { get; set; }


        public Buyer(Guid id)
        {
            Id = id;
        }

        public void addByuerRoot(BuyerRoot buyerRoot)
        {
            BuyerRoot = buyerRoot;
        }
        public void AddPaymentMethod(TypeOfPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void AddCardType(PaymentSystem? cardType)
        {
            if (PaymentMethod ==  TypeOfPaymentMethod.Card && cardType != null)
            {
                CardType = cardType;
            }
        }
        
    }
    
//фабрика
    public class BuyerFactory
    {
        public static Buyer CreateBuyer(TypeOfPaymentMethod paymentMethod, PaymentSystem? paymentSystem)
        {
            var buyer = new Buyer(Guid.NewGuid());
            var buyerRoot = new BuyerRoot("Крамцов Глеб", "Рязанская обл,ул. Московская, д 55");
            buyer.addByuerRoot(buyerRoot);
            buyer.AddPaymentMethod(paymentMethod);
            buyer.AddCardType(paymentSystem);
            
            return buyer;
        }
    }
}