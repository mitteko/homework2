using System;
namespace Homework
{

    //1
    enum Bank
    {
        Текущий,
        Сберегательный
    }

    
    //2
    struct BankAccount
    {
        public int number;
        public Bank type;
        public double balance;

        public void Print()
        {
            Console.WriteLine($"\nНомер счета:{number}\nТип:{type}\nБаланс:{balance}");
        }
    }

    //3
    enum ВУЗ
    {
        КГУ,
        КАИ,
        КХТИ 
    }

    struct Работник
    {
        public string name;
        public ВУЗ university;

        public void Print()
        {
            Console.WriteLine($"\nИмя:{name}\nВУЗ:{university}");
        }
    }



    class Program
    {


        static void Main()
        {
            Console.WriteLine("Лабораторная 3 Главы");

            //1
            Console.WriteLine("Лабораторная №1");
            Bank bank = Bank.Текущий;

            Console.WriteLine($"Вид банковского счета - {bank}");


            //2
            Console.WriteLine("Лабораторная №2");

            BankAccount bankAccount = new BankAccount();
            bankAccount.number = 3;
            bankAccount.type = bank;
            bankAccount.balance = 154330;
            bankAccount.Print();


            //3
            Console.WriteLine("Лабораторная №3");

            Работник работник = new Работник();
            работник.name = "Петя";
            работник.Print();
        } 

    }

}