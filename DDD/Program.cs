using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DDD.BuyerAgregate;
using DDD.OrderAgregate;
using DDD.Repository.Repositories;


namespace DDD
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            
            int sr1 = generateId();
            Console.WriteLine(sr1);
            int sr2 = generateId();
            Console.WriteLine(sr2);
            //Console.WriteLine(id3);
            
        }
        public static int generateId()
        {
            Random rnd = new Random();
            int Id = rnd.Next(1000,10000);
            return Id;
        }
    }
}