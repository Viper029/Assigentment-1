using System;
using System.Linq;

class Program
{
    static int question1(int[] arr)
    {
        int ans = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            ans += arr[i];
        }
            if (ans > 3000)
            {
                ans = ans - (ans / 10);
                return ans;
            }
            return ans;
        
    }


    static double question2()
    {


        Console.Write("Enter the temprature in Celcius: ");
        double ans = 0;

        int temp = Convert.ToInt32(Console.ReadLine());
        ans = temp * (1.8) + 32;
        return ans;

    }

    static bool ValidatePassword(string password)
    {
        if (password.Length < 8)
            return false;

        bool UpperCase = false;
        bool LowerCase = false;
        bool Digit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                UpperCase = true;
            if (char.IsLower(c))
                LowerCase = true;
            if (char.IsDigit(c))
                Digit = true;
        }

        return UpperCase && LowerCase && Digit;
    }


    static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300, 400, 500 ,7,8,9};
            /*Console.WriteLine("question 1 = " + question1(arr));
            Console.WriteLine("question 2 :" + question2());
            //Console.WriteLine("enter password:");
            String password = "asdfas2323Adsd";
            if(password == null)
            {
            Console.WriteLine("passwrod is null");   
            }
            
            else if (ValidatePassword(password))
            {
                Console.WriteLine("password is valid");
            }
            else
            {
                Console.WriteLine("password is not valid");
            }
            ATM obj = new ATM();
            obj.deposit(1000);


            Taxifare taxifare = new Taxifare();
            Console.WriteLine(taxifare.calculatefare(20));*/
            leftrotate(arr,2);
            for(int i =0 ;i< arr.Length;i++) 
                {Console.WriteLine(arr[i]);}
        }
    
}







    
public class ATM
{
    int balance = 0;

    public void withdraw(int b)
    {
        if (balance < b)
        {
            Console.WriteLine("LOW BALANCE");

        }
        else
        {
            balance = balance - b;
            Console.WriteLine("Succesfully withdrwal" + b);
        }
    }

     public void deposit(int money)
    {
        Console.WriteLine("deposited in" + money);
    }
}

public class Taxifare{
    
    public int fare = 20;
    public int nightCharge = 10;

    public int rate = 5;
    public int calculatefare(int distance){

        Console.WriteLine("if travelling after 10 P.M. (Y/N)");
        char checkNight = Console.ReadLine()[0];
        if(distance<2) return fare;
        else if(checkNight == 'N' || checkNight == 'n'){
            return (20+(distance-2)*rate);
        }
        else{
            return(20+(distance-2)*rate + nightCharge);
        }

    }
}





public class Q7A7
    {
        public class Attendance
        {
            int attendance = 0;
            int totalDay = 5;

            public void Attend()
            {
                attendance++;
            }

            public int PresentDays()
            {
                return attendance;
            }

            public Boolean HasPrefectAttendance()
            {
                return attendance >= totalDay / 2 ? true : false;
            }
        }
        public Q7A7()
        {
            Attendance a = new Attendance();
            a.Attend();
            a.Attend();
            a.Attend();
            a.Attend();
            Console.WriteLine(a.PresentDays());
            Console.WriteLine(a.HasPrefectAttendance());
        }
    }



 public class Q9A9
    {
        public class ShopingCart
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            double total = 0;

            public void AddItem(string name, double price)
            {
                cart.Add(name, price);
                total += price;
            }

            public void RemoveItem(string name)
            {
                total -= cart[name];
                cart.Remove(name);
            }

            public void GetTotal()
            {
                Console.WriteLine("Total: " + total);
            }
        }
    }

    public class Q10A10
    {
        public Q10A10()
        {
            Console.Write("Enter wages per week: ");
            int wagePerWeek = Convert.ToInt32(Console.ReadLine());
            int[] hoursPerWeek = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter " + (i + 1) + " working hours: ");
                hoursPerWeek[i] = Convert.ToInt32(Console.ReadLine());
            }

            int monthlySalary = 0;
            foreach (int hours in hoursPerWeek)
            {
                monthlySalary += hours * wagePerWeek;
            }
            Console.WriteLine("Monthly Salary: " + monthlySalary);
        }
    }

