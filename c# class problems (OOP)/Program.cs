//pgm inheritance
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Vehicle
    {
        int passenger_count;
        string make;
        string model;

        public int Passenger_count { get => passenger_count; set => passenger_count = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            List<Sedan> sedanlist = new List<Sedan>();
            List<SUV> suvlist = new List<SUV>();
            int n = Convert.ToInt32(Console.ReadLine());

            // Write code for the programming login to find number of SUVs and Sedans
            for (int i = 0; i < n; i++)
            {
                int passenger = Convert.ToInt32(Console.ReadLine());
                string make = Console.ReadLine();
                string model = Console.ReadLine();

                int x = Convert.ToInt32(Console.ReadLine());

                if (passenger > 4)
                {
                    suvlist.Add(new SUV() { Passenger_count = passenger, Make = make, Model = model, GroundClearance = x });
                }
                else
                {
                    sedanlist.Add(new Sedan() { Passenger_count = passenger, Make = make, Model = model, Bootspace = x });
                }

            }

            Console.WriteLine("Number of SUVs : " + suvlist.Count);
            Console.WriteLine("Number of Sedans : " + sedanlist.Count);
        }
    }

    // Write code for inheriting the property from vehicle class. This class should be used for classifying vehicle type.
    class Sedan : Vehicle
    {
        int bootspace;
        public int Bootspace { get => bootspace; set => bootspace = value; }
    }
    class SUV : Vehicle
    {
        int groundclearance;
        public int GroundClearance { get => groundclearance; set => groundclearance = value; }
    }

}
*/


/*-----------------------------------------------------------------------------------------------------------------------*/



//pgm inheritance 2
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Bankaccount
    {
        int acid;
        string name;

        public int Acid { get => acid; set => acid = value; }
       public string Name { get => name; set => name = value; }


    }
    class Savingacc:Bankaccount
    {
        int savingaccount;
        public int Savingaccount { get => savingaccount; set => savingaccount = value; }

        public void addAmt(int amount)
        {
            savingaccount += amount;
            Console.WriteLine("AMOUNT DEPOSITED IS :"+ savingaccount);
        }
        public void Withdrawsavings(int amount)
        {
            if (amount > savingaccount)
            {
                Console.WriteLine("INSUFFICIENT BALANCE");
            }
            else
            {
                savingaccount -= amount;
                Console.WriteLine("NEW AMMOUNT IS :"+ savingaccount);
            }
        }

    }
    class Currentacc:Bankaccount
    {
        int currentaccount;
        public int Currentaccount { get => currentaccount; set => currentaccount = value; }

        public void addAmt(int amount)
        {
            currentaccount += amount;
            Console.WriteLine("AMOUNT DEPOSITED IS:"+currentaccount);
        }

        public void WithdrawCurrent(int amount)
        {
            if(amount>currentaccount)
            {
                Console.WriteLine("MINIMUM BALANCE SHOULD BE HUNDRED");
            }
            else
            {
                currentaccount -= amount;
                Console.WriteLine("NEW AMOUNT :"+ currentaccount);
            }
        }
    }

    class solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Savingacc> sa = new List<Savingacc>();
            List<Currentacc> ca = new List<Currentacc>();
            for (int i = 0; i < n; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name1 = Console.ReadLine();
                int amount = Convert.ToInt32(Console.ReadLine());

                if (id == 0)
                {
                    sa.Add(new Savingacc() { Acid = id, Name = name1, Savingaccount = amount });
                }
                else
                    ca.Add(new Currentacc() { Acid = id, Name = name1, Currentaccount = amount });


            }
            solution c = new solution();
            int a = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            int cd = Convert.ToInt32(Console.ReadLine());
            c.searchaccount(sa, ca, a, name, b, cd);
            Console.ReadKey();

        }
        public void searchaccount(List<Savingacc> l, List<Currentacc> c, int id, string name, int amount, int withdraw)
        {
            Savingacc suser = null;
            Currentacc cuser = null;
            if(id==0)
            {
                foreach(Savingacc s in l)
                {
                    if(s.Name.Equals(name))
                    {
                        suser = s;
                        break;
                    }
                }
                if(suser!=null)
                {
                    suser.addAmt(amount);
                    suser.Withdrawsavings(withdraw);
                }
            }
            else
            {
                foreach(Currentacc x in c)
                {
                    if(x.Name.Equals(name))
                    {
                        cuser = x;
                        break;
                    }
                }
                if (cuser != null)
                {
                    cuser.addAmt(amount);
                    cuser.WithdrawCurrent(withdraw);
                }
            }
            if(cuser==null && suser==null)
            {
                Console.WriteLine("USER NOT FOUND");
            }


        }
    }




}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/


/*
 c# xplore
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class student
    {
        int id;
        string name;
        string course;
        int mark;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Mark { get => mark; set => mark = value; }
        public string Course { get => course; set => course = value; }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Write your code to create a list of students, take input and call showmax function
            List<student> stud = new List<student>();
            for (int i = 0; i < n; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string course = Console.ReadLine();
                int marks = Convert.ToInt32(Console.ReadLine());
                stud.Add(new student { Id = id, Name = name, Mark = marks, Course = course });
            }
            string Course = Console.ReadLine();
            new Solution().showmax(stud, Course);
        }
        public void showmax(List<student> stud, string course)
        {
            // Write your code to find the maximum of the students mark and print the result
            int max = int.MinValue;
            student maxStudent = null;
            foreach (student s in stud)
            {
                if (s.Mark > max && s.Course.Equals(course))
                {
                    max = s.Mark;
                    maxStudent = s;
                }
            }
            Console.WriteLine(maxStudent.Name);

        }
    }
}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/

/*
using System;
using System.Text;
namespace hello
{
    class solu
    {
        static void Main(string[] args)
        {
            String ss = Console.ReadLine();
            string bb=ss.Replace("an", "the");
            Console.WriteLine(bb.ToString());
        }
    }
}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/


/*
using System;
using System.Collections.Generic;
class Item
{
    private int itemId;
    private string itemType;
    private string itemcato;
    private int itemPrice;
    private int itemqnt;



    public int ItemId { get => itemId; set => itemId = value; }
    public string ItemType { get => itemType; set => itemType = value; }

    public string Itemcato { get => itemcato; set => itemcato = value; }

    public int ItemPrice { get => itemPrice; set => itemPrice = value; }

    public int Itemqnt { get => itemqnt; set => itemqnt = value; }


    public Item(int itemId, string itemType, string itemcato, int itemPrice, int itemqnt)
    {
        this.itemId = itemId;
        this.itemType = itemType;
        this.itemcato = itemcato;
        this.itemPrice = itemPrice;
        this.itemqnt = itemqnt;
    }



}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/



/* //
using System;
using System.Collections.Generic;

namespace Items
{
    public class Items
    {
        private int Itemid;
        private string Name;
        private string Category;
        private int price;
        private int Quantity;

        public int ItemId { get { return this.Itemid; } set { this.Itemid = value; } }
        public string IName { get { return this.Name; } set { this.Name = value; } }
        public string Cat { get { return this.Category; } set { this.Category = value; } }
        public int Price { get { return this.price; } set { this.price = value; } }
        public int IQuantity { get { return this.Quantity; } set { this.Quantity = value; } }


        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("Item Name: " + this.Name);
            Console.WriteLine("Total cost of Items: " + (this.Quantity * this.price));
            Console.WriteLine();
        }

        public void Qupdate()
        {
            Console.WriteLine();
            Console.Write("Enter new Quantity : ");
            this.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Item Name: " + this.Name + "New Quantity: " + this.Quantity);
            Console.WriteLine();
        }


    }
    class Program
    {
        public static void Main(string[] args)
        {
            int id, price, qnt;
            string name, category;
            int n = 0;
            Console.Write("Enter No. of items you want to enter: ");
            n = Convert.ToInt32(Console.ReadLine());
            List<Items> myobj = new List<Items>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Item Id: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Item Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Item Category{small/medium/large}: ");
                category = Console.ReadLine();

                Console.Write("Enter Item Price: ");
                price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Item Quantity: ");
                qnt = Convert.ToInt32(Console.ReadLine());
                myobj.Add(new Items { ItemId = id, IName = name, IQuantity = qnt, Price = price, Cat = category });
            }

            int ch;
            do
            {
                Console.WriteLine("1.Update Item Quanity\n2.Display Items\n3.Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter Item No.");
                        int idno = Convert.ToInt32(Console.ReadLine());
                        foreach (Items I in myobj)
                        {
                            if (I.ItemId == idno)
                            {
                                I.Qupdate();
                            }
                        }
                        break;

                    case 2:
                        foreach (Items I in myobj)
                        {
                            I.display();
                        }
                        break;

                       
                }
            } while (ch <= 2);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/





/*
using System;
using System.Collections.Generic;

public class Vehical
{

    private string r_no;
    private string model;
    private string manuf;
    private DateTime date;
    private string eng_no;
    private string color;





    public string R_no { get => r_no; set => r_no = value; }
    public string Model { get => model; set => model = value; }
    public string Manuf { get => manuf; set => manuf = value; }
    public DateTime Date { get => date; set => date = value; }
    public string Eng_no { get => eng_no; set => eng_no = value; }
    public string Color { get => color; set => color = value; }





    public void Change()
    {
        Console.WriteLine();
        Console.Write("Enter new color: ");
        this.color = Console.ReadLine();

        Console.WriteLine("Registration no:"+ this.r_no);
        Console.WriteLine("Enter name of Model:"+ this.model);
        Console.WriteLine("Enter Item Manufacturar of Vehical:"+this.manuf);
        Console.WriteLine("Enter the date of Manf"+this.date);
        Console.WriteLine("Enter Engine no:"+this.eng_no);
        Console.WriteLine("New Quantity: " + this.color);


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string r_no, model, manuf, eng_no, color;
        DateTime date;
        Console.Write("Enter No. of items you want to enter: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<Vehical> veh = new List<Vehical>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Registration no: ");
            r_no = Console.ReadLine();

            Console.Write("Enter name of Model: ");
            model = Console.ReadLine();

            Console.Write("Enter Item Manufacturar of Vehical: ");
            manuf = Console.ReadLine();

            Console.Write("Enter the date of Manf: ");
            date =Convert.ToDateTime (Console.ReadLine());

            Console.Write("Enter Engine no: ");
            eng_no = Console.ReadLine();

            Console.Write("Enter the color of Vehical: ");
            color = Console.ReadLine();

            veh.Add(new Vehical { R_no=r_no, Model=model,Manuf=manuf,Date=date,Eng_no=eng_no,Color=color });
        }


        Console.WriteLine("enter registration number so we can change the color");
        string rnum = Console.ReadLine();
        foreach(Vehical v in veh)
        {
            if(v.R_no==rnum)
            {
                v.Change();
            }
        }

       
    }
}

  
*/



/*-----------------------------------------------------------------------------------------------------------------------*/




/*
using System;
using System.Collections.Generic;

public class Employee
{

    private int id;
    private string name;
    private DateTime date;
    private int salary;





    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public DateTime Date { get => date; set => date = value; }
    public int Salary { get => salary; set => salary = value; }





    public void Dispaly()
    {
        Console.WriteLine("id:"+ this.id+"name:"+this.name+"date:"+this.date+"salary"+this.salary);
    }

    public void Change()
    {
        Console.WriteLine("enter new sal:");
        this.salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("new salary"+this.salary);
    }


}


class solution
{
    public static void Main()
    {

        int id, salary;
        string name;
        DateTime date;
        int ch = 0;
        List<Employee> li = new List<Employee>();

       
        do
        {
            Console.WriteLine("1.Add Emp\n2.Change salary\n3.Delete emp\n4.Dispaly emp details");
             ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    char s;
                    do
                    {


                        Console.Write("Enter Emp id:");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Emp Name:");
                        name = Console.ReadLine();

                        Console.Write("Enter Emp date of j:");
                        date = Convert.ToDateTime(Console.ReadLine());


                        Console.Write("Enter Emp salary:");
                        salary = Convert.ToInt32(Console.ReadLine());


                        li.Add(new Employee { Id = id, Name = name, Date = date, Salary = salary });
                        Console.WriteLine("Do you want to add anoter product N/Y");
                        s = Convert.ToChar(Console.ReadLine());
                    } while (s!='N');
                    break;

                case 2:
                    Console.WriteLine("Enter Emp id");
                    id = Convert.ToInt32(Console.ReadLine());
                    foreach (Employee e in li)
                    {
                        if (e.Id == id)
                        {
                            e.Change();
                        }

                    }
                    break;

                case 3:
                    Console.WriteLine("Enter Emp id");
                    id = Convert.ToInt32(Console.ReadLine());
                    foreach (Employee e in li)
                    {
                        if (e.Id == id)
                        {
                            li.Remove(e);
                        }

                    }
                    break;

                case 4:
                    foreach (Employee e in li)
                    {
                        e.Dispaly();
                    }
                    break;
            }

        } while (ch<=4);
    }
}

*/





/*-----------------------------------------------------------------------------------------------------------------------*/




/*
//13 Feb py Q.

using System;
using System.Collections.Generic;

public class AccountHolder
{

    private int accno;
    private string accholdername;
    private string acchaddess;
    private decimal balance;
    private string acctype;





    public int Accno { get => accno; set => accno = value; }
    public string Accholdername { get => accholdername; set => accholdername = value; }

    
    public string Acchaddess { get => acchaddess; set => acchaddess = value; }
    public decimal Balance { get => balance; set => balance = value; }

    public string Acctype { get => acctype; set => acctype = value; }


    public AccountHolder(int accno, string accholdername, string acchaddes, decimal balance, string acctype)
    {
        this.accno = accno;
        this.accholdername = accholdername;
        this.accholdername = acchaddess;
        this.balance = balance;
        this.acctype = acctype;
    }
    public AccountHolder()
    {

    }

    public void Display()
    {
        Console.WriteLine(this.accno.ToString());
       Console.WriteLine(this.accholdername);
        Console.WriteLine(this.acchaddess);
        Console.WriteLine(this.balance);
        Console.WriteLine( this.acctype);
    }
}

 class Bank
{
    List<AccountHolder> li = new List<AccountHolder>();
    
   
    public void addAccountHolder()
    {
        int accno;
        string accholdername, acchaddes, acctype;
        decimal balance;

        Console.WriteLine("enter acc no:");
        accno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter accholder name");
        accholdername = Console.ReadLine();
        Console.WriteLine("Enter acc holder Address");
        acchaddes = Console.ReadLine();
        Console.WriteLine("Enter balance");
        balance = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Acc type Saving/Cureent");
        acctype = Console.ReadLine();
        li.Add(new AccountHolder(accno,accholdername,acchaddes,balance,acctype));

    }
    public int withdraw(int accno,decimal balance)
    {
        int ac = 0;
    foreach(AccountHolder a in li)
        {
            if(a.Accno==accno)
            {
                if(a.Balance>=balance)
                {
                    a.Balance -= balance;
                    Console.WriteLine(a.Balance);
                     ac=1;
                }
                else
                {
                    ac= 2;
                }
            }
            else
            {
                ac= 0;
            }
        }
        return ac;
    }
    public int deposit(int accno,decimal balance)
    {
        int ac = 0;
        foreach (AccountHolder a in li)
        {
            if (a.Accno == accno)
            {
                a.Balance += balance;
                ac = 1;
            }
            else
            {
                ac = 0;
            }
        }
        return ac;
    }


    public AccountHolder MaxAccHolder()
    {
        AccountHolder b = new AccountHolder();
        decimal s = 0;
        foreach(AccountHolder a in li)
        {
            if(s<a.Balance)
            {
                b = a;
                s = a.Balance;
            }
        }
        return b;
    }


    public void Viewall()
    {
         foreach(AccountHolder a in li)
        {
            a.Display();
        }
    }



    public void ViewbyType(string acctype)
    {
        foreach(AccountHolder a in li)
        {
            if(a.Acctype==acctype)
            {
                a.Display();
            }
        }

    }
}

class solution
{
    public static void Main()
    {
        int ch = 0;
        Bank b = new Bank();
        int accno;
        decimal balance;
        do
        {
            Console.WriteLine("1.Add Acc holder\n2.Withdraw\n3.Deposit\n4.ViewAll\n5.View by type\n6.Max Acc holder");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    b.addAccountHolder();
                    break;
                case 2:
                    Console.Write("Enter acc no");
                    accno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter balance:");
                    balance = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(b.withdraw(accno, balance));

                    break;
                case 3:
                    Console.Write("Enter acc no");
                    accno = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter balance:");
                    balance = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(b.deposit(accno, balance));
                    break;
                case 4:
                    b.Viewall();
                    break;
                case 5:
                    Console.WriteLine("Enter Acc type");
                    string s = Console.ReadLine();
                    b.ViewbyType(s);
                    break;
                case 6:
                    AccountHolder c = b.MaxAccHolder();
                    Console.WriteLine(c.Accno.ToString(), c.Accholdername, c.Acchaddess, c.Balance, c.Acctype);
                    break;



            }

        } while (ch<=6);
         
    }
}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/




/*

using System;
using System.Collections.Generic;
public class Product
{
    private int id;
    private string name;
    private int unitstock;
    private int price;


    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int UnitStock { get => unitstock; set => unitstock = value; }
    public int Price { get => price; set => price = value; }




    public void Change()
    {
        Console.WriteLine("Enter Changed Units in stock");
        this.UnitStock= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("new Units:"+this.UnitStock);


        Console.WriteLine("Enter Changed Price");
        this.Price= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("new Price:"+this.Price);

    }
  
    public void Display()
    {
        Console.WriteLine("Product id:"+this.Id);
        Console.WriteLine("Product Name"+this.Name);
        Console.WriteLine("Units in stock"+this.UnitStock);
        Console.WriteLine("Price"+this.Price);
       
    }

  
}

class solution
{
    public static void Main()
    {

        int id, unitstock, price=0;
        string name;
        int ch = 0;
        Product pd = new Product();
        List<Product> li = new List<Product>();
        do
        {
            Console.WriteLine("1.Add Product\n2.Change units in stock and price of product\n3.Delete Product\n4.View All the Product\n5.Search Product");
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    char s;
                    do
                    {
                        Console.WriteLine("Enter id:");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Units in Stock");
                        unitstock = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Price");
                        price = Convert.ToInt32(Console.ReadLine());

                        li.Add(new Product { Id = id, Name = name, UnitStock = unitstock, Price = price });
                        Console.WriteLine("Do you want to enter another Product Y/N");
                        s = Convert.ToChar(Console.ReadLine());

                    } while (s != 'N');

                    break;

                case 2:
                    Console.WriteLine("Enter id");
                    id = Convert.ToInt32(Console.ReadLine());
                    foreach (Product p in li)
                    {
                        if (p.Id == id)
                        {
                            p.Change();
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter id");
                    id = Convert.ToInt32(Console.ReadLine());
                    foreach (Product p in li)
                    {
                        if (p.Id == id)
                        {
                            li.Remove(p);
                        }
                    }
                    break;

                case 4:
                   foreach(Product p in li)
                    {
                        p.Display();
                    }
                    break;

                case 5:
                    Console.WriteLine("Enter price");
                    price = Convert.ToInt32(Console.ReadLine());
                    foreach(Product p in li)
                    {
                        if(p.Price>price)
                        {
                            Console.WriteLine(p.Price);
                        }
                    }
                    break;


            }



        } while (ch <= 5);
    }
}

*/

/*-----------------------------------------------------------------------------------------------------------------------*/


/* 2MAR JAVA
Create a class Medicine and read the following
medicineName (String)
batchNo (String)
disease (String)
price (int)
Read a string named as requiredDisease which matches with data and returns the price of the medicine in the ascending order

INPUT :
dolo650
batch1
fever
100
dolo990
batch2
headache
101
paracetemol
batch3
bodypains
102
almox500
batch4
fever
103
fever

OUTPUT :
100
103

​ 

using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public class Medicine
    {
        private string mname;
        private string batch;
        private string disease;
        private int price;

        public string Mname { get => mname; set => mname = value; }
        public string Batch { get => batch; set => batch = value; }
        public string Disease { get => disease; set => disease = value; }
        public int Price { get => price; set => price = value; }



        public Medicine(string mname, string batch, string disease, int price)
        {
            this.mname = mname;
            this.batch = batch;
            this.disease = disease;
            this.price = price;

        }
        public Medicine()
        {

        }

        public void Change()
        {

        }
    }


    public class solution
    {
        public static void Main(string[] args)
        {
            string mname, batch, disease;
            int price;
            int n = Convert.ToInt32(Console.ReadLine());
            List<Medicine> li = new List<Medicine>();
            Medicine medicine = new Medicine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter medicine name");
                mname = Console.ReadLine();
                Console.WriteLine("Enter batch");
                batch = Console.ReadLine();
                Console.WriteLine("Enter disease");
                disease = Console.ReadLine();
                Console.WriteLine("Enter price of Medicine");
                price = Convert.ToInt32(Console.ReadLine());

                li.Add(new Medicine { Mname = mname, Batch = batch, Disease = disease, Price = price });

            }
            string searchDisease = Console.ReadLine();

            foreach (Medicine m in li)
            {
                if (m.Disease == searchDisease)
                {
                    Console.WriteLine(m.Price);
                }
            }

            //int ch = 0;


            //do
            //{
            //    Console.WriteLine("1.Search Disease and print its price\n2.Exit");
            //    ch = Convert.ToInt32(Console.ReadLine());

            //    switch (ch)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter disease");
            //            disease = Console.ReadLine();
            //            foreach (Medicine m in li)
            //            {
            //                if (m.Disease == disease)
            //                {
            //                    Console.WriteLine(m.Price);
            //                }
            //            }
            //            break;

            //        case 2:
            //            break;
            //            //  List<int> ts = sortAccodingToPrice(li, searchDisease);
            //            // for (int i = 0; i < ts.Count; i++)
            //            //{
            //            //  Console.WriteLine(ts[i]);
            //            //}
            //    }

            //    //public static List<int> sortAccodingToPrice(List<Medicine> l, string searchDisease)
            //    //{
            //    //    //List<int> temp;
            //    //    //int j = 0;
            //    //    //for (int i = 0; i < l.Count; i++)
            //    //    //{
            //    //    //    string str = l[i].Disease;
            //    //    //    if (String.Equals(str, searchDisease, StringComparison.InvariantCultureIgnoreCase))
            //    //    //    {
            //    //    //        j++;
            //    //    //    }
            //    //    //}
            //    //    //temp = new List<int>();
            //    //    //j = 0;
            //    //    //for (int i = 0; i < l.Count; i++)
            //    //    //{
            //    //    //    string str = l[i].Disease;
            //    //    //    if (String.Equals(str, searchDisease, StringComparison.InvariantCultureIgnoreCase))
            //    //    //    {
            //    //    //        temp[j++] = l[i].Price;
            //    //    //    }
            //    //    //    for (int h = 0; h < j - 1; h++)
            //    //    //    {
            //    //    //        for (int k = 0; k < j - 1; k++)
            //    //    //        {
            //    //    //            if (temp[k] > temp[k + 1])
            //    //    //            {
            //    //    //                int p = temp[k];
            //    //    //                temp[k] = temp[k + 1];
            //    //    //                temp[k + 1] = p;
            //    //    //            }
            //    //    //        }
            //    //    //    }

            //    //    //}
            //    //    foreach(Medicine m in l)
            //    //    {
            //    //        if(m.Disease==searchDisease)
            //    //        {
            //    //            return m.change();
            //    //        }
            //    //    }


            //    //}




            //} while (ch <= 2);
        }
    }
}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//java practice assessment 2 Mar
using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public class Medicine
    {
        private string mname;
        private string batch;
        private string disease;
        private int price;

        public string Mname { get => mname; set => mname = value; }
        public string Batch { get => batch; set => batch = value; }
        public string Disease { get => disease; set => disease = value; }
        public int Price { get => price; set => price = value; }



        public Medicine(string mname, string batch, string disease, int price)
        {
            this.mname = mname;
            this.batch = batch;
            this.disease = disease;
            this.price = price;

        }
        public Medicine()
        {

        }

        
    }


    public class solution
    {
        public static void Main(string[] args)
        {
            string mname, batch, disease;
            int price;
         //   int n = Convert.ToInt32(Console.ReadLine());
           
           // Medicine medicine = new Medicine();
            Medicine[] medicines = new Medicine[4];
            for (int i = 0; i <medicines.Length; i++)
            {
                Console.WriteLine("Enter medicine name");
                mname = Console.ReadLine();
                Console.WriteLine("Enter batch");
                batch = Console.ReadLine();
                Console.WriteLine("Enter disease");
                disease = Console.ReadLine();
                Console.WriteLine("Enter price of Medicine");
                price = Convert.ToInt32(Console.ReadLine());

                medicines[i] = new Medicine();
            }
            string searchDisease = Console.ReadLine();

            int[] requiredprices = sortAccordingToPrice(medicines, searchDisease);
            for(int i=0;i<requiredprices.Length;i++)
            {
                Console.WriteLine(requiredprices[i]);
            }







            //int ch = 0;


            //do
            //{
            //    Console.WriteLine("1.Search Disease and print its price\n2.Exit");
            //    ch = Convert.ToInt32(Console.ReadLine());

            //    switch (ch)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter disease");
            //            disease = Console.ReadLine();
            //            foreach (Medicine m in li)
            //            {
            //                if (m.Disease == disease)
            //                {
            //                    Console.WriteLine(m.Price);
            //                }
            //            }
            //            break;

            //        case 2:
            //            break;
            //            //  List<int> ts = sortAccodingToPrice(li, searchDisease);
            //            // for (int i = 0; i < ts.Count; i++)
            //            //{
            //            //  Console.WriteLine(ts[i]);
            //            //}
            //    }

            //    //public static List<int> sortAccodingToPrice(List<Medicine> l, string searchDisease)
            //    //{
            //    //    //List<int> temp;
            //    //    //int j = 0;
            //    //    //for (int i = 0; i < l.Count; i++)
            //    //    //{
            //    //    //    string str = l[i].Disease;
            //    //    //    if (String.Equals(str, searchDisease, StringComparison.InvariantCultureIgnoreCase))
            //    //    //    {
            //    //    //        j++;
            //    //    //    }
            //    //    //}
            //    //    //temp = new List<int>();
            //    //    //j = 0;
            //    //    //for (int i = 0; i < l.Count; i++)
            //    //    //{
            //    //    //    string str = l[i].Disease;
            //    //    //    if (String.Equals(str, searchDisease, StringComparison.InvariantCultureIgnoreCase))
            //    //    //    {
            //    //    //        temp[j++] = l[i].Price;
            //    //    //    }
            //    //    //    for (int h = 0; h < j - 1; h++)
            //    //    //    {
            //    //    //        for (int k = 0; k < j - 1; k++)
            //    //    //        {
            //    //    //            if (temp[k] > temp[k + 1])
            //    //    //            {
            //    //    //                int p = temp[k];
            //    //    //                temp[k] = temp[k + 1];
            //    //    //                temp[k + 1] = p;
            //    //    //            }
            //    //    //        }
            //    //    //    }

            //    //    //}
            //    //    foreach(Medicine m in l)
            //    //    {
            //    //        if(m.Disease==searchDisease)
            //    //        {
            //    //            return m.change();
            //    //        }
            //    //    }


            //    //}




            //} while (ch <= 2);
        }

        public static int[] sortAccordingToPrice(Medicine[] medicines,string searchDisease)
        {
            int[] temp;
            int j = 0;

            for (int i = 0; i < medicines.Length; i++)
            {
                if(medicines[i].Disease==searchDisease)
                {
                    j++;
                }
            }
            temp = new int[j];
            j = 0;
            for (int i = 0; i < medicines.Length; i++)
            {
                if (medicines[i].Disease == searchDisease)
                {
                    temp[j++] = medicines[i].Price;
                }
            }


             for (int h = 0; h < j - 1; h++)
             { 
                 for (int k = 0; k < j - 1; k++)
                 {
                     if (temp[k] > temp[k + 1])
                     {
                        int p = temp[k];
                        temp[k] = temp[k + 1];
                        temp[k + 1] = p;
                     }
                 }
             }







            return temp;
        }
    }
}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/


/*


********************************* PALINDROME(PYTHON PGM)****************************
using System;
using System.Linq;
using System.Collections.Generic;
public class sol
{
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> li = new List<string>();
        for (int i = 0; i < n; i++)
        {
            li.Add(Console.ReadLine());

        }

        foreach (string s in li)
        {
            string p = new string(s.Reverse().ToArray());
            if (s == p)
            {
                Console.WriteLine(p);
            }

        }



    }
}



***** output******
2
radar
nitish
radar






*************************************** VOWELS CONSONENTS(JAVA)*************************
using System;
using System.Linq;

public class sol
{
    public static void Main(String[] args)
    {
        int count = 0;
        int consonants = 0;
        string str = Console.ReadLine().ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                count++;
            }
            else if (str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
            {
                continue;
            }
            else
            {
                consonants++;
            }
        }
        Console.WriteLine("Number of Vowels: {0}", count);

        Console.WriteLine("Number of Consonents: {0}", consonants);

    }
}



**** OUTPUT*************8
Welcome123
Number of Vowels :3
Number of Consonents :4



****************** last element of string********************

using System;
public class solution
{
    public static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(' ');
        foreach (string s in str)
        {
            Console.Write(s[s.Length - 1]);
        }

    }
}


********** output****************
welcome home buddy
eey


*/



/*-----------------------------------------------------------------------------------------------------------------------*/





//python practice problem 10 Feb
/*
Create a class employee with attributes
  emp Id,
  emp name,
  emp role,
  emp salary

​

In the same class,define method increment_salary() which takes number as an argument, here number represents the percentage by which the salary should be incremented.
Create another class organization with attributes org_name and list of employee objects
In the same class create a method calculate_salary() which takes string and number as the input arguments.string input represents the employee role and number represents the percentage by which the salary should be incremented,return list of employee objects whose salary has incremented.

Note: use increment_salary method in this method
Input:
4
100
rajesh
developer
40000
101
ayesha
developer
41000
102
hari
analyst
45000
103
amar
manager
60000
developer
5


Output:


rajesh
42000.0
ayesha
 */

/*
using System;
using System.Collections.Generic;
public class Employee
{
   private int eid;
   private string name;
   private string role;
   private double salary;



   public int Eid { get; set; }
   public string Name { get; set; }
   public string Role { get; set; }
   public double Salary { get; set; }


   public Employee(int eid,string name,string role,int salary)
   {
       this.eid = eid;
       this.name = name;
       this.role = role;
       this.salary = salary;
   }

   public Employee()
   {

   }



   public void IncSal(int salary)
   {
       this.Salary +=this.salary*(salary/100);
       Console.WriteLine(this.Name+":"+ this.Salary);
   }




}



public class sl
{

   public static void Main(string[] args)
   {
       int eid, salary = 0 ;
       string role, name;


       List<Employee> li = new List<Employee>();
       int n = Convert.ToInt32(Console.ReadLine());
       for(int i=0;i<n;i++)
       {
           eid = Convert.ToInt32(Console.ReadLine());
           name = Console.ReadLine();
           role = Console.ReadLine();
           salary=Convert.ToInt32(Console.ReadLine());

           li.Add(new Employee { Eid = eid, Name = name, Role = role, Salary = salary }) ;
       }
      // Console.WriteLine("Enter role");
       role = Console.ReadLine();

      // Console.WriteLine("Enter new amt to be added to salary");
       salary= Convert.ToInt32(Console.ReadLine());

       foreach (Employee e in li)
       {

           if (e.Role == role)
           {
               e.IncSal(salary);
           }
       }

   }
}

*/

/*-----------------------------------------------------------------------------------------------------------------------*/



/* 
 //python practice problems pro.assessment 28 DEC

 Q1.Create a class called apartment with attributes flat-number, owner name, electicitybillamount. Create another class apartment_demo with def init(self): pass to create a method getSecondMinBill that takes the list of objects and gives the second minimum electricity bill as output.

Sample Input:
3
1000 
Hari
5000 
1001
Hena 
5002 
1002
Harsha
5001

Sample Output:
5001



using System;
using System.Collections.Generic;

public class Apartment
{
    public int flatnumber { get; set; }
    public string owner { get; set; }
    public int billAmount { get; set; }

    public Apartment(int number, string owner, int bill)
    {
        flatnumber = number;
        this.owner = owner;
        billAmount = bill;
    }

}
public class Program
{
    public static void Main()
    {
        List<Apartment> apartments = new List<Apartment>();
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int no = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            int bill = Convert.ToInt32(Console.ReadLine());
            apartments.Add(new Apartment(no, name, bill));
        }
        Console.WriteLine(getSecondMinBill(apartments));
    }

    public static int getSecondMinBill(List<Apartment> list)
    {
        int n = list.Count;
        //selection sorting in ascending order
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array 
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (list[j].billAmount < list[min_idx].billAmount)
                    min_idx = j;

            // Swap the found minimum element with the first 
            // element 
            Apartment temp = list[min_idx];
            list[min_idx] = list[i];
            list[i] = temp;
        }
        return list[1].billAmount; //returning the second smallest billAmount
    }

}
*/

/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//python practice problem 28 dec

Q2. Create a class Bill with attributes mobile number and payment bill. Create another class mobile with attributes serviceprovider, mobilenumber, dataused, payment method. Service provider may be airtel or jio.Data used is integer values in Gigabytes(GB). Payment method may be paytm, gpay, amazon and soon. Create a method calculatebill that takes the list of objects and calculates the bill and returns the list of objects of class bill with mobile number and paymentbill. 
The payment is calculated as follows: 
1. If the service provider is airtel, the bill is Rs.11 for every 1GB used and if it is jio, the bill is Rs.10 for every 1GB used. 
2.If the payment method is paytm there is a cash back of 10% of the total bill for airtel users only.The bill is calculated and rounded off after deducing the cashback value. 
 
Sample Input: 
3 
airtel 
123
16
paytm
airtel
456
10
amazon
jio
789
10
paytm

Sample Output:


(123,158)
(456,110)
(789,100)


using System;
using System.Collections.Generic;

public class Bill
{
    public int mobno { get; set; }
    public int paymentbill { get; set; }


    public Bill(int mobno,int paymentbill)
    {
        this.mobno = mobno;
        this.paymentbill = paymentbill;

    }
}


public class Mobile
{
    public string servicepro { get; set; }
    public int mobno { get; set; }
    public int Dataused { get; set; }
    public string paymentmethod { get; set; }



    public Mobile(string servicepro, int mobno, int Dataused, string paymentmethod)
    {
        this.servicepro = servicepro;
        this.mobno = mobno;
        this.Dataused = Dataused;
        this.paymentmethod = paymentmethod;

    }
    public Mobile()
    {
            
    }

    public List<Bill> Calfun(List<Mobile> l)
    {
        List<Bill> b = new List<Bill>();
        for(int i=0;i<l.Count;i++)
        {
            int billamont = 0, totalbill = 0 ;
            if (l[i].servicepro =="airtel")
            {
                billamont = l[i].Dataused * 11;
                if(l[i].paymentmethod=="paytm")
                {
                    totalbill = billamont - (int)(billamont * 0.1);
                    totalbill += -1;
                }
                else
                {
                    totalbill = billamont;
                }

            }
            else if(l[i].servicepro == "jio")
            {
                billamont = l[i].Dataused * 10;
                totalbill = billamont;
                Console.WriteLine(billamont);
                Console.WriteLine(totalbill);
            }
            b.Add(new Bill(l[i].mobno, totalbill));
         
        }
        return b;
    }
}

public class Program
{
    public static void Main()
    {
        string servicepro, paymentmethod;
        int mobno, Dataused;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Mobile> mli = new List<Mobile>();
        for(int i=0;i<n;i++)
        {
            servicepro = Console.ReadLine();
            mobno= Convert.ToInt32(Console.ReadLine());
            Dataused = Convert.ToInt32(Console.ReadLine());
            paymentmethod = Console.ReadLine();

            mli.Add(new Mobile(servicepro, mobno, Dataused, paymentmethod));
        }

        Mobile m = new Mobile();
        List<Bill> b = m.Calfun(mli);
        foreach(Bill a in b)
        {
            Console.WriteLine(a.mobno+" "+a.paymentbill);
        }
            
    }

}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/


/*
//python practice prbolems of proctored assessments 17 Dec

Q1. Create a class Payslip having attributes basicSalary,hra and ita.Create a class PaySlipDemo containing a method getHighestPF with takes list of payslip objects and return the highest PF among the objects.PF should be 12% of basic salary.

Sample Input:
2 
10000 
2000 
1000 
50000
3000 
2000 

Sample Output:
6000 


using System;
using System.Linq;
using System.Collections.Generic;
public class Payslip
{
    

    public int basicSal { get; set; }
    public int hra { get; set; }
    public int ita { get; set; }

    public Payslip(int basicSal,int hra,int ita)
    {
        this.basicSal = basicSal;
        this.hra = hra;
        this.ita = ita;
    }

    
}

public class Paydemo
{
    public Paydemo()
    {
            
    }

    public int getHighestpf(List<Payslip> l)
    {
        int max = 0;
        
        for(int i=0;i<l.Count;i++)
        {

            int temp = (int)(l[i].basicSal *0.12);
            if(temp>max)
            {
                max = temp;
            }

        }
       
        return max;
        

    }
}


public class pgm
{
    public static void Main()
    {
        int basicSal, hra, ita;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Payslip> pli = new List<Payslip>();
        for(int i=0;i<n;i++)
        {
            basicSal= Convert.ToInt32(Console.ReadLine());
            hra= Convert.ToInt32(Console.ReadLine());
            ita= Convert.ToInt32(Console.ReadLine());
            pli.Add(new Payslip(basicSal, hra, ita));

        }
        Paydemo d = new Paydemo();
        int c = d.getHighestpf(pli);
        Console.WriteLine(c);        
    }
}
*/

/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//python practice prbolems of proctored assessments 17 Dec

Q2.Create a class Stock having attributes StockName,StockSector,StockValue.Create a class StockDemo having a method getStockList with takes a list of Stock objects and a StockSector(string) and returns a list containing stocks of the given sector having value more than 500.

Sample Input:
3 
TCS
IT 
1000 
INFY 
IT 
400 
BMW 
Auto 
1200 
IT 

Sample Output:
TCS         


using System;
using System.Collections.Generic;
public class Stock
{
    public string stoname { get; set; }
    public string stosec { get; set; }
    public int stoval { get; set; }

    public Stock(string stoname, string stosec, int stoval)
    {
        this.stoname = stoname;
        this.stosec = stosec;
        this.stoval = stoval;

    }
 
}

public class stock_Demo
{
    public string getStockList(List<Stock> s,string stosec)
    {
       
        string temp=null;
        
        for (int i = 0; i < s.Count; i++)
        {
            if (s[i].stosec==stosec && s[i].stoval>500)
            {
                temp = s[i].stoname;

            }
           
        }
        return temp ;

    }
}

public class pgm
{
    public static void Main()
    {
        string stoname, stosec;
        int stoval;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Stock> sli = new List<Stock>();
        for(int i=0;i<n;i++)
        {
            stoname = Console.ReadLine();
            stosec = Console.ReadLine();
            stoval= Convert.ToInt32(Console.ReadLine());
            sli.Add(new Stock(stoname, stosec, stoval));
        }
        stock_Demo demo = new stock_Demo();
        stosec = Console.ReadLine();
        string str = demo.getStockList(sli,stosec);
        Console.WriteLine(str);


    }
}    
*/


/*-----------------------------------------------------------------------------------------------------------------------*/



/*
 //15JAN PYTHON

Q2. Class Book has 2 attributes-book_id and book_name. It has a constructor. Class Library has 3 attributes-library_id, address and a list of book objects. It has 2 functions. 1.One gets a character as input and returns the count of books starting with that character. 2.Second function takes a list of book names as input and removes those books from library if present. 
Sample Input:
3
100
C++ Programming 
200
Introduction to SQL 
300
Core Java 
C 
2
Introduction to SQL 
Python Programming

Sample Output: 
2 
C++Programming
Core Java


using System;
using System.Collections.Generic;
public class Book
{
    public int book_id { get; set; }
    public string book_name { get; set; }

    public Book(int book_id, string book_name)
    {
        this.book_id = book_id;
        this.book_name = book_name;
    }

    public Book(string book_name)
    {
        this.book_name = book_name;
    }
}
public class Library
{
    // public List<Book> s = new List<Book>();
    public int lab_id { get; set; }
    public string lab_addr { get; set; }
    public List<Book> bl { get; set; }


    public Library(int lab_id, string lab_addr, List<Book> s)
    {
        this.lab_id = lab_id;
        this.lab_addr = lab_addr;
        this.bl = s;

    }


    public int getChar(char ch)
    {
        int count = 0;
        for (int i = 0; i < bl.Count; i++)
        {
            if (bl[i].book_name[0] == ch)
            {
                count++;
            }

        }
        return count;
    }


    public void removebook(List<string> k)
    {

        for (int i = 0; i < k.Count; i++)
        {
            for (int j = 0; j < bl.Count; j++)
            {
                if (k[i].Equals(bl[j].book_name))
                {
                    bl.RemoveAt(j);
                    break;
                }

            }


        }


    }
}


public class program
{
    public static void Main()
    {
        int book_id;
        string book_name;

        int n = Convert.ToInt32(Console.ReadLine());
        List<Book> bli = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            book_id = Convert.ToInt32(Console.ReadLine());
            book_name = Console.ReadLine();
            bli.Add(new Book(book_id, book_name));

        }
        // lab_id = Convert.ToInt32(Console.ReadLine());
        //lab_addr= Console.ReadLine();
        Library l = new Library(123, "mumbai", bli);
        char ch = Convert.ToChar(Console.ReadLine());

        int c = l.getChar(ch);

        int b = Convert.ToInt32(Console.ReadLine());
        List<string> s = new List<string>();
        for (int i = 0; i < b; i++)
        {
            s.Add(Console.ReadLine());
        }
        l.removebook(s);
        Console.WriteLine(c);
        foreach (Book a in l.bl)
        {
            Console.WriteLine(a.book_name);
        }
        

    }
}

*/



/*-----------------------------------------------------------------------------------------------------------------------*/



/*

// python 2 mar tcs xplore

Given passenger ID name gender distance
In last two lines they provide the passenger ID and discount percentage 
We need to print the discount to be given for that particular passenger  if that given Id is not in the list print no name or no value
​

input :
4
101
a
f
10000
102
b
m
12000
103
c
f
45000
104
d
m
65000
101
5

output: 
discount of 101 is: 500.0


using System;
using System.Collections.Generic;
public class  Passenger
{
    public int pid { get; set; }
    public string pname { get; set; }
    public string pgender { get; set; }
    public int pdis { get; set; }

    public Passenger(int pid,string pname,string pgender,int pdis)
    {
        this.pid = pid;
        this.pname = pname;
        this.pgender = pgender;
        this.pdis = pdis;

    }
    List<Passenger> pl = new List<Passenger>();
    public double Cal_dis(double percentage, List<Passenger> pl)
    {
        double d = 0;
         foreach(Passenger p in pl)
         {
            if(p.pid==pid)
            {
               d=p.pdis * (percentage / 100);
              
            }
         }
         return d;
       


    }
}


public class pgm
{
    public static void Main()
    {
        int pid, pdis, percentage;
        double c = 0;
        string pname, pgender;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Passenger> pli = new List<Passenger>();
        for(int i=0;i<n;i++)
        {
            pid = Convert.ToInt32(Console.ReadLine());
            pname = Console.ReadLine();
            pgender = Console.ReadLine();
            pdis = Convert.ToInt32(Console.ReadLine());
            pli.Add(new Passenger(pid, pname, pgender, pdis));

        }
        pid = Convert.ToInt32(Console.ReadLine());
        percentage = Convert.ToInt32(Console.ReadLine());
        foreach(Passenger p in pli)
        {
          
            if (p.pid==pid)
            {
               c= p.Cal_dis(percentage,pli);
                Console.WriteLine(c) ;
            }
     
            
        }
        if(c<=0)
        {
            Console.WriteLine("no dis");
        }


    }
}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//java 17 DEC

Question 2:
Create solution class Implement Static method "associates forGivenTechnology" in solution class.
This method will take a string parameter as array of associate objects.
The method will return array of Associates where string parameter appears in technology
attribute(with case insensitive search) and experienceInyears should be multiple of 5.
Create class Associate with below attributes:
associate id- string
associate name- string
Technology- string
experienceInYears-int


Write getters,setters and parameterized constructor.
Create class solution with the main method.
Implement Static method - associateForgiventechnology in solution class.
This method will take a string parameter named technology along with the other parameter as array of objects.
The method will return array of associate where the string parameter appears in the technology attribute (with case insensitive search) and the experienceInyears should be multiples of 5.
This method should be called from main method and display the id of returned objects in ascending order.

Before calling this method (associateForgiventechnology) in the main method use scanner object to read values for five associate objects referring the attributes in above sequence then read value for search parameter.
Next call the method associateForgiventechnology,write the logic to print the ID's (in main method) And display result.


Input:
Alex
101
Java
15
Albert
102
Unix
20
Alferd
103
Testing
13
Alfa
104
Java
15
Almas
105
Java
29
Java // Given technology


Output:
101
104


using System;
using System.Collections.Generic;
public class Associate
{
    public int Aid { get; set; }
    public string Aname { get; set; }
    public string Atech { get; set; }
    public int Expyr { get; set; }

    public Associate(int Aid,string Aname,string Atech,int Expyr)
    {
        this.Aid = Aid;
        this.Aname = Aname;
        this.Atech = Atech;
        this.Expyr = Expyr;
    }
    

    
}


public class Solution
{
    public static void Main(string[] args)
    {
        string  Aname, Atech;
        int Expyr,Aid;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Associate> ali = new List<Associate>();
      
        for(int i=0;i<n;i++)
        {
            Aid = Convert.ToInt32(Console.ReadLine());
            Aname = Console.ReadLine();
            Atech = Console.ReadLine();
            Expyr = Convert.ToInt32(Console.ReadLine());
            ali.Add(new Associate(Aid, Aname, Atech, Expyr));
        }
         Atech = Console.ReadLine();
        List<Associate> p = associateForgiventechnology(ali,Atech);
       foreach(Associate a in p)
        {
            Console.WriteLine(a.Aid);
        }
        


    }


    public static List<Associate> associateForgiventechnology(List<Associate> l,string Atech)
    {
        List<Associate> associates = new List<Associate>();
      
        for (int i = 0; i < l.Count; i++)
        {

            if (l[i].Atech==Atech&&l[i].Expyr % 5 == 0)
            {
                associates.Add(l[i]);
            }
        }
        return associates;
    }
}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/


/*
//java 28 DEC

Create a class Movie with Attributes :
movieName String
 Company String
 Genre String
 budget int

Create setters and getters and parametrized Constructor as required
Create another class Solution with a main method and scan attributes as above sequence
ex :
aaa
Marvel
Action
250000000
and scan a search attribute 

Create a Static method getMovieByGenre which will take object array and search string as parameters and returns movies which are matching with genre(Search) having budget less than 80000000 if movie budget is above 8cr print "High Budget Movie" ( Case Senstive Search) else " Low Budget Movie"

input :
aaa
Arka
Action
250000000
bbbb
GeethaArts
Comedy
25000000
ccc
Marvel
Art
2000000
ddd
Mythri
Action
300000000
Action

Output:
High Budget Movie
High Budget Movie 


using System;
using System.Collections.Generic;
public class Movie
{
    public string Mname { get; set; }
    public string Cname { get; set; }
    public string Genre { get; set; }
    public int Budget { get; set; }

    public Movie(string Mname,string Cname,string Genre,int Budget)
    {
        this.Mname = Mname;
        this.Cname = Cname;
        this.Genre = Genre;
        this.Budget = Budget;

    }
}

public class Solution
{
    public static void Main()
    {
        string Mname, Cname, Genre,Search;
        int Budget;
        Movie[] m = new Movie[4];
        for(int i=0;i<4;i++)
        {
            Mname = Console.ReadLine();
            Cname = Console.ReadLine();
            Genre = Console.ReadLine();
            Budget = Convert.ToInt32(Console.ReadLine());

            m[i] = new Movie(Mname, Cname, Genre, Budget);

        }
        Search = Console.ReadLine().ToLower();
        getMovieByGenere(m, Search);

    }

    public static void getMovieByGenere(Movie[] m, string Search)
    {
        for(int i=0;i<4;i++)
        {
            if(m[i].Genre==Search&&m[i].Budget>80000000)
            {
                Console.WriteLine("High Budget Movie");
            }
            else if(m[i].Genre == Search && m[i].Budget < 80000000)
            {
                Console.WriteLine("Low Budget Movie");
            }
        }
    }
}
*/



/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//Java 15 Jan

Create a Sim class with 5 attributes and also write getter ,setter 
methods.

Implement a method which takes array of sim objects as first parameter , string circle 
as a second parameter  and a double ratePerSecond as third parameter.

This method should return an array of the 
objects which containing second parameter and less than the third 
parameter and also the balance value of those objects must be in descending order.

In the main  method we have to display the id attribute values of the array 

input:
1
jio
430
1.32
mumbai
2
idea
320
2.26
mumbai
3
airtel
500
2.54
mumbai
4
vodafone
640
3.21
mumbai
mumbai
3.4

output:
4
3
1
2

using System;
using System.Collections.Generic;
using System.Linq;
public class Sim
{
    public int Sid { get; set; }
    public string Sname { get; set; }
    public double Balance { get; set; }
    public double rateps { get; set; }
    public  string Circle { get; set; }

    public Sim(int Sid,string Sname,double Balance,double rateps,string Circle)
    {
        this.Sid = Sid;
        this.Sname = Sname;
        this.Balance = Balance;
        this.rateps = rateps;
        this.Circle = Circle;
    }
}

public class Solution
{
    public static void Main()
    {
        string Sname, Circle;
        int Sid;
        double Balance, rateps;
        Sim[] s = new Sim[4];
        for(int i=0;i<4;i++)
        {
            Sid = Convert.ToInt32(Console.ReadLine());
            Sname = Console.ReadLine();
            Balance = Convert.ToDouble(Console.ReadLine());
            rateps = Convert.ToDouble(Console.ReadLine());
            Circle = Console.ReadLine();

            s[i] = new Sim(Sid, Sname, Balance, rateps, Circle);
        }
        Circle = Console.ReadLine();
        rateps = Convert.ToDouble(Console.ReadLine());
        Sim[] result = find(s, Circle, rateps);
        for(int i=0;i<result.Length;i++)
        {
            Console.WriteLine(result[i].Sid);

        }
    }

    public static Sim[] find(Sim[] s,string circle,double rateps)
    {
          Sim[] temp;
          int j = 0;
        for(int i=0;i<s.Length;i++)
        {
            if (s[i].Circle == circle && s[i].rateps < rateps)
            {
                j++;
            }

        }
        temp = new Sim[j];
        j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Circle == circle && s[i].rateps < rateps)
            {
                temp[j++] = s[i];
            }
        }

        for(int i = 0; i < j - 1; i++) {
            for (int k = 0; k < j - 1; k++)
            {
                if (temp[k].Balance<temp[k + 1].Balance)
                {
                    Sim a = temp[k];
                    temp[k] = temp[k + 1];
                    temp[k + 1] = a;
                }
            }
        }
        return temp;
    }
}

  */



/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//Java 10 Feb using Array of 

Write a class named as Main. Read the following parameters
- id (int)
- name (String)
- exp (int)
- matchesPlayed (int)
- runsScored (int)

Calculate the average of the players in that innings depends upon the target(int)
- if avgRuns >=80 and <=100, print Grade A
- if avgRuns >=50 and <=79, print Grade B
- else, print Grade C

Input:
100
Sachin
5
150
13000
101
Sehwag
4
120
10000
103
Dhoni
7
110
7000
104
Kohli
15
57
4400
100

Output:
Grade A
Grade A
Grade B

using System;
using System.Collections.Generic;
public class Players
{
public int Pid { get; set; }
public string Pname { get; set; }
public int Exp { get; set; }
public int Matchesplayed { get; set; }
public int RunsScored { get; set; }

public Players(int Pid,string Pname,int Exp,int Matchesplayed,int RunsScored)
{
    this.Pid = Pid;
    this.Pname = Pname;
    this.Exp = Exp;
    this.Matchesplayed = Matchesplayed;
    this.RunsScored = RunsScored;

}

}


public class Solution
{
public static void Main()
{
    int Pid, Exp, Matchesplayed, RunsScored, target ;
    string Pname;
    Players[] p = new Players[4];
    for(int i=0;i<p.Length;i++)
    {
        Pid = Convert.ToInt32(Console.ReadLine());
        Pname = Console.ReadLine();
        Exp= Convert.ToInt32(Console.ReadLine());
        Matchesplayed= Convert.ToInt32(Console.ReadLine());
        RunsScored= Convert.ToInt32(Console.ReadLine());

        p[i] = new Players(Pid, Pname, Exp, Matchesplayed, RunsScored);
    }
    target= Convert.ToInt32(Console.ReadLine());
    double[] AvgrunRate = findavgofruns(p, target);
    for(int i=0;i<AvgrunRate.Length;i++)
    {
        if(AvgrunRate[i]>=80 && AvgrunRate[i]<=100)
        {
            Console.WriteLine("Grade A");
        }
        else if(AvgrunRate[i]>=50 && AvgrunRate[i]<=79)
        {
            Console.WriteLine("Grade B");
        }
        else
            Console.WriteLine("Grade C");
    }
}

public static double[] findavgofruns(Players[] p,int target)
{
    double[] temp;
    int j = 0;
    for(int i=0;i<p.Length;i++)
    {
        if(p[i].Matchesplayed>=target)
        {
            j++;
        }
    }
    temp = new double[j];
    j = 0;
    for (int i = 0; i < p.Length; i++)
    {
        if (p[i].Matchesplayed >= target)
        {
            temp[j] = (double)(p[i].RunsScored / p[i].Matchesplayed);
              j++;
        }

    }
    return temp;

}
}

*/





/*-----------------------------------------------------------------------------------------------------------------------*/




/*

//Java 10 Feb by using list
using System;
using System.Collections.Generic;
public class Players
{
    public int Pid { get; set; }
    public string Pname { get; set; }
    public int Exp { get; set; }
    public int Matchesplayed { get; set; }
    public int RunsScored { get; set; }

    public Players(int Pid, string Pname, int Exp, int Matchesplayed, int RunsScored)
    {
        this.Pid = Pid;
        this.Pname = Pname;
        this.Exp = Exp;
        this.Matchesplayed = Matchesplayed;
        this.RunsScored = RunsScored;

    }

}


public class Solution
{
    public static void Main()
    {
        int Pid, Exp, Matchesplayed, RunsScored, target;
        string Pname;
        List<Players> p = new List<Players>();
        // Players[] p = new Players[4];
        for (int i = 0; i < 4; i++)
        {
            Pid = Convert.ToInt32(Console.ReadLine());
            Pname = Console.ReadLine();
            Exp = Convert.ToInt32(Console.ReadLine());
            Matchesplayed = Convert.ToInt32(Console.ReadLine());
            RunsScored = Convert.ToInt32(Console.ReadLine());


            p.Add(new Players(Pid, Pname, Exp, Matchesplayed, RunsScored));
           // p[i] = new Players(Pid, Pname, Exp, Matchesplayed, RunsScored);
        }
        target = Convert.ToInt32(Console.ReadLine());
        List<double> avg = findavgofruns(p, target);
        for (int i = 0; i < avg.Count; i++)
        {
            if (avg[i] >= 80 && avg[i] <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (avg[i] >= 50 && avg[i] <= 79)
            {
                Console.WriteLine("Grade B");
            }
            else
                Console.WriteLine("Grade C");
        }
    }

    public static List<double> findavgofruns(List<Players> p, int target)
    {
        List<double> temp=new List<double>();
        
        int j = 0;
        for (int i = 0; i < p.Count; i++)
        {
            if (p[i].Matchesplayed >= target)
            {
                temp.Add(p[i].RunsScored / p[i].Matchesplayed);
            }

        }
        return temp;

    }
}

*/


/*-----------------------------------------------------------------------------------------------------------------------*/



/*
//java 13 Feb using array obj's and fun call

Create a Sim Class with following Attributes
int simId;
String customerName;
double balance;
double ratePerSecond; 
String circle;
create a public Class Solution in which take input of 5 object and then take 2 input (circle1, circle2) for circle of matches as circle1 and choose only those objects which are match with circle1.
Create a method named as transferCircle() and passed sim object and circle1, circle2 as parameter and arrange sim object in descending order as per ratePerSecond
Print the output as simId, customerName, circle, ratePerSecond.

Input:
1
raju
130
1.32
mum
2
sachin
120
2.26
ahd
3
ram
200
2.54
kol
4
shubham
640
3.21
ahd
5
kalpesh
150
1.8
ahd
ahd
kol

Output:
4 shubham kol 3.21
2 sachin kol 2.26
5 kalpesh kol 1.8

using System;
using System.Collections.Generic;
public class sim
{
    public int Simid { get; set; }
    public string Custn { get; set; }
    public double Balance { get; set; }
    public double Rateps { get; set; }
    public string Circle { get; set; }

    public sim(int Simid,string Custn,double Balance,double Rateps,string Circle)
    {
        this.Simid = Simid;
        this.Custn = Custn;
        this.Balance = Balance;
        this.Rateps = Rateps;
        this.Circle = Circle;

    }
    public sim()
    {

    }
    public sim[] transferCircle(sim[] s, string Circle1, string Circle2)
    {
        sim[] temp;
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Circle == Circle1)
            {
                j++;
            }
        }
        temp = new sim[j];
        j = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Circle == Circle1)
            {
                temp[j] = s[i];
                j++;
            }
        }

    for(int i=0;i<j-1;i++)
        {
            for(int k=0;k<j-1;j++)
            {
                if(temp[k].Rateps<temp[k+1].Rateps)
                {
                    sim a = temp[k];
                    temp[k] = temp[k + 1];
                    temp[k + 1] = a;
                }
            }
        }
        return temp;
    }     
}


public class Solution
{
    public static void Main()
    {
        int Simid; string Circle, Circle1, Circle2 ,Custname; double Rateps, Balance;
        sim[] s = new sim[5];
        sim sm = new sim();
        for (int i=0;i<s.Length;i++)
        {
            Simid = Convert.ToInt32(Console.ReadLine());
            Custname = Console.ReadLine();
            Balance = Convert.ToDouble(Console.ReadLine());
            Rateps = Convert.ToDouble(Console.ReadLine());
            Circle= Console.ReadLine();

            s[i] = new sim(Simid, Custname, Balance, Rateps, Circle);
        }
        Circle1 = Console.ReadLine();
        Circle2 = Console.ReadLine();
        
       sim[]dm= sm.transferCircle(s, Circle1, Circle2);
        for(int i=0;i<dm.Length;i++)
        {
            Console.WriteLine(dm[i].Simid+" "+dm[i].Custn+" "+dm[i].Circle+" "+dm[i].Rateps);
        }
    }
}
*/





/*-----------------------------------------------------------------------------------------------------------------------*/






/* same as above using list

using System;
using System.Collections.Generic;
public class sim
{
    public int Simid { get; set; }
    public string Custn { get; set; }
    public double Balance { get; set; }
    public double Rateps { get; set; }
    public string Circle { get; set; }

    public sim(int Simid, string Custn, double Balance, double Rateps, string Circle)
    {
        this.Simid = Simid;
        this.Custn = Custn;
        this.Balance = Balance;
        this.Rateps = Rateps;
        this.Circle = Circle;

    }
    public sim()
    {

    }
    public List<sim> transferCircle(List<sim> s, string Circle1, string Circle2)
    {
        List<sim> temp = new List<sim>();
        int j = 0;

        for (int i = 0; i < s.Count; i++)
        {
            if (s[i].Circle == Circle2)
            {
                temp.Add(s[i]);

            }
        }
        

        for (int i = 0; i < j - 1; i++)
        {
            for (int k = 0; k < j - 1; j++)
            {
                if (temp[k].Rateps < temp[k + 1].Rateps)
                {
                    sim a = temp[k];
                    temp[k] = temp[k + 1];
                    temp[k + 1] = a;
                }
            }
        }
        return temp;
    }
}


public class Solution
{
    public static void Main()
    {
        int Simid; string Circle, Circle1, Circle2, Custname; double Rateps, Balance;
        //  sim[] s = new sim[5];
        List<sim> s = new List<sim>();
        sim sm = new sim();
        for (int i = 0; i <5; i++)
        {
            Simid = Convert.ToInt32(Console.ReadLine());
            Custname = Console.ReadLine();
            Balance = Convert.ToDouble(Console.ReadLine());
            Rateps = Convert.ToDouble(Console.ReadLine());
            Circle = Console.ReadLine();

            s.Add(new sim(Simid, Custname, Balance, Rateps, Circle));
           // s[i] = new sim(Simid, Custname, Balance, Rateps, Circle);
        }
        Circle1 = Console.ReadLine();
        Circle2 = Console.ReadLine();

        List<sim> d = sm.transferCircle(s, Circle1, Circle2);
        for (int i = 0; i < d.Count; i++)
        {
            Console.WriteLine(d[i].Simid + " " + d[i].Custn + " " + d[i].Circle + " " + d[i].Rateps);
        }
    }
}




*/



/*-----------------------------------------------------------------------------------------------------------------------*/




/*
//tcs proctored assessment 2 March c#

using System;
using System.Collections.Generic;

public class BankAccount
{
    public int Custid { get; set; }
    public string CustName { get; set; }
    public string BranchName { get; set; }
    public int AccNo { get; set; }
    public string AccType { get; set; }
    public double Balance { get; set; }

    public BankAccount(int Custid, string CustName, string BranchName, int AccNo, string AccType, double Balance)
    {
        this.Custid = Custid;
        this.CustName = CustName;
        this.BranchName = BranchName;
        this.AccNo = AccNo;
        this.AccType = AccType;
        this.Balance = Balance;

    }
    public BankAccount()
    {

    }





}
public class pgm
{
    static BankAccount bankAccount = new BankAccount();
    static List<BankAccount> accounts = new List<BankAccount>();
    public static void Main()
    {
        BankAccount[] acc = new BankAccount[10];
        acc[0] = new BankAccount(12345, "aditya", "vijapur road", 10000101, "Savings", 50000);
        acc[1] = new BankAccount(67890, "raj", "ring road", 10000102, "Current", 50000);
        acc[2] = new BankAccount(90281, "mahesh", "vijapur road", 10000101, "Savings", 50000);
        acc[3] = new BankAccount(98909, "vedant", "vijapur road", 10000101, "Current", 50000);
        acc[4] = new BankAccount(00000, "ram", "ring road", 10000101, "Savings", 50000);
        acc[5] = new BankAccount(11111, "aditi", "vijapur road", 10000101, "Savings", 50000);
        acc[6] = new BankAccount(22222, "sumit", "vijapur road", 10000109, "Savings", 50000);
        acc[7] = new BankAccount(55555, "aarya", "hydrabad road", 10000101, "Current", 50000);
        acc[8] = new BankAccount(99999, "arnav", "ring road", 10000113, "Current", 50000);
        acc[9] = new BankAccount(54455, "amit", "vijapur road", 10000115, "Current", 30000);

        for (int i = 0; i < acc.Length; i++)
            accounts.Add(acc[i]);
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Withdraw();
                break;
            case 2:
                List<BankAccount> accdetails = getCustDetails();
                if (accdetails != null)
                {
                    foreach (BankAccount at in accdetails)
                    {
                        Console.WriteLine("USER {0} ({1}) At branch {2},A/C NO: {3} ({4}) has {5} as balance", at.CustName, at.Custid, at.BranchName, at.AccNo,at.AccType, at.Balance);
                    }


                }
                break;
            default:
                Console.WriteLine("WRONG CHOICE");
                break;
        }

    }
    public static void Withdraw()
    {
        int AccNo = Convert.ToInt32(Console.ReadLine());
        int Amount = Convert.ToInt32(Console.ReadLine());
        bool temp = false;
        foreach (BankAccount ac in accounts)
        {
            if (ac.AccNo == AccNo)
            {
                temp = true;
                if (ac.Balance > Amount)
                {
                    ac.Balance -= Amount;
                    Console.WriteLine("Withdrawl success! modified balance is {0}", ac.Balance);
                    break;
                }
                else
                {
                    Console.WriteLine("Account does not have sufficient balance");
                    break;
                }

            }
        }
        if (temp == false)
        {
            Console.WriteLine("Account no. was not found in database");
        }
    }


    public static List<BankAccount> getCustDetails()
    {
        List<BankAccount> b = new List<BankAccount>();
        int Custid = Convert.ToInt32(Console.ReadLine());
        foreach (BankAccount account in accounts)
        {
            if (account.Custid == Custid)
            {
                b.Add(account);
            }

        }
        if (b.Count < 1)
        {
            Console.WriteLine("Customer was not found in database!");
            return null;
        }
        else
            return b;
    }


}
*/




/*-----------------------------------------------------------------------------------------------------------------------*/





/*
//when to use dictionary over list youtube example
using System;
using System.Collections.Generic;
class pgm
{
    static void Main()
    {

        Country c1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "CAmberra" };
        Country c2 = new Country() { Code = "IND", Name = "INDIA", Capital = "NEW DELHI" };
        Country c3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "WASHINGTON D.C" };
        Country c4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "LONDON" };
        Country c5 = new Country() { Code = "RUS", Name = "RUSSIA", Capital = "MASCO" };

        List<Country> cli = new List<Country>();
        cli.Add(c1);
        cli.Add(c2);
        cli.Add(c3);
        cli.Add(c4);
        cli.Add(c5);

        string strchoice=null;

        do
        {

            Console.WriteLine("ENTER COUNTRY CODE");
            string str = Console.ReadLine().ToUpper();


            Country Resultcountry = cli.Find(Country => Country.Code == str);
            if (Resultcountry == null)
            {
                Console.WriteLine("COUNTRY CODE IS NOT VALID");
            }
            else
            {
                Console.WriteLine("NAME={0},CAPITAL={1}", Resultcountry.Name, Resultcountry.Capital);
            }

            do
            {
                Console.WriteLine("DO U WANT TO CONTINUE ? YES OR NO");
                strchoice = Console.ReadLine().ToUpper();
            } while (strchoice!="NO" && strchoice!="YES");
        } while (strchoice=="YES");

    }
}


public class Country
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Capital { get; set; }
}
*/




/*-----------------------------------------------------------------------------------------------------------------------*/


/*
//same code as above but using Dictionary  

using System;
using System.Collections.Generic;
class pgm
{
    static void Main()
    {

        Country c1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "CAmberra" };
        Country c2 = new Country() { Code = "IND", Name = "INDIA", Capital = "NEW DELHI" };
        Country c3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "WASHINGTON D.C" };
        Country c4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "LONDON" };
        Country c5 = new Country() { Code = "RUS", Name = "RUSSIA", Capital = "MASCO" };

        Dictionary<string,Country> dict = new Dictionary<string, Country>();
        dict.Add(c1.Code, c1);
        dict.Add(c2.Code, c2);
        dict.Add(c3.Code, c3);
        dict.Add(c4.Code, c4);
        dict.Add(c5.Code, c5);


        string strchoice = null;

        do
        {

            Console.WriteLine("ENTER COUNTRY CODE");
            string str = Console.ReadLine().ToUpper();


            Country Resultcountry =dict.ContainsKey(str) ? dict[str] : null ;
            if (Resultcountry == null)
            {
                Console.WriteLine("COUNTRY CODE IS NOT VALID");
            }
            else
            {
                Console.WriteLine("NAME={0},CAPITAL={1}", Resultcountry.Name, Resultcountry.Capital);
            }

            do
            {
                Console.WriteLine("DO U WANT TO CONTINUE ? YES OR NO");
                strchoice = Console.ReadLine().ToUpper();
            } while (strchoice != "NO" && strchoice != "YES");
        } while (strchoice == "YES");

    }
}


public class Country
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Capital { get; set; }
}

*/




/*-----------------------------------------------------------------------------------------------------------------------*/



//Create a method calculate_price() that takes a number quantity as an argument
//-> Check if the quantity is greater than or equal to quantity_availabe or not.
//-> If available, return price as quantity* item_price otherwise return 0.

//Create one more Class Store which takes a list as parameters.
//-> Initialize an attribute item_list that takes list of item objects.
//-> Create a method generate_bill() that takes input as a dictionary (item_name : quantity).
//-> It returns the total price of the items available in the dictionary by using the method calculate_price() in the Item Class

//Input
//3
//1
//milk
//70
//7
//2
//bread
//50
//5
//3
//jam
//60
//2
//2
//bread
//3
//jam
//1
//Output
//140
//210



/*---------------------------------------------------------------------------------------------------------------------*/

/*
//Hackathon tcs practice ss 59-60
using System;
using System.Collections.Generic;
using System.Collections;
namespace Class_List
{
    class pgm
    {
        static Employee employee = new Employee();
        static List<Employee> employeelist = new List<Employee>();
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];

            employees[0] = new Employee(1001, "David Backham", "President", Convert.ToDateTime("01-11-2018"), 2010203);
            employees[1] = new Employee(1002, "Zinedine Zindane", "Manager", Convert.ToDateTime("01-02-2016"), 1862015);
            employees[2] = new Employee(1003, "Aditya Bidkar", "Manager", Convert.ToDateTime("05-12-2019"), 1650542);
            employees[3] = new Employee(1004, "Arnav Bidkar", "Forward", Convert.ToDateTime("01-11-2001"), 2015321);
            employees[4] = new Employee(1005, "Aditi Desh", "Forword", Convert.ToDateTime("11-11-2003"), 2405021);
            employees[5] = new Employee(1006, "Daniel Vebar", "Forword", Convert.ToDateTime("10-07-2002"), 2403578);
            employees[6] = new Employee(1007, "Dan Veb", "Midfilder", Convert.ToDateTime("05-11-2006"), 1654891);
            employees[7] = new Employee(1008, "Don jack", "Midfilder", Convert.ToDateTime("01-11-2008"), 1620123);
            employees[8] = new Employee(1008, "Ab raje", "Defender", Convert.ToDateTime("01-07-2007"), 1402320);
            employees[9] = new Employee(1009, "Ter strgen", "Goalkeeper", Convert.ToDateTime("04-10-2011"), 1657801);



            for (int i = 0; i < 10; i++)
                 employeelist.Add(employees[i]);
            

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                default:
                    Console.WriteLine("WRONG CHOICE");
                    Console.ReadKey();
                    break;
                case 1:
                    //salary from user
                    int salary = Convert.ToInt32(Console.ReadLine());
                    //code to all GetEmployeeNames Method
                    ArrayList empNames = GetEmployeeNames(salary);
                    //display all names of employees
                    foreach (string employeeName in empNames)
                    {
                        Console.WriteLine(employeeName);
                    }
                    break;
                case 2:
                    //get designation from user
                    //write code to call EmployeeStatistics Method
                    //print the result in specified format
                    string Des = Console.ReadLine();
                    int count = 0;
                    int z = EmployeeStatistics(Des,out count);
                    if(z==0)
                        Console.WriteLine("No One Found!");
                    else
                    {
                        Console.WriteLine("Designation - "+Des+", "+count+"employee(s) earn "+z+"in total");
                    }
                    break;

                case 3:
                    //Get designation from user
                    //provide 20% hike for a given designation and display employee name and increased salary
                    //print the result <name>-<salary>
                    string de = Console.ReadLine();
                    foreach (Employee e in employeelist)
                    {
                        if(e.Designation.Equals(de))
                        {
                            Console.WriteLine(e.Name+"-");
                            int t =Convert.ToInt32(e.Salary * 1.2);
                            Console.WriteLine(t);
                        }
                    }
                    break;




            }

        }


        //write EmployeeStatistics Method
        public static int EmployeeStatistics(string Des,out int count)
        {
            int j = 0,s= 0;
            foreach (Employee yee in employeelist)
            {
                if(yee.Designation.Equals(Des))
                {
                    s++;
                    j += yee.Salary;
                }
            }
            count = s;
            return j;
          
        }




        //write GetEmployeeDetails Method
        public static ArrayList GetEmployeeNames(int salary)
        {
            ArrayList m = new ArrayList();
            foreach (Employee i in employeelist)
            {
                if (i.Salary > salary)
                    m.Add(i.Name);
            }
            return m;
        }



    }





    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int Salary { get; set; }



        public Employee(int EmployeeId, string Name, string Designation, DateTime DateOfJoining, int Salary)
        {
            this.EmployeeId = EmployeeId;
            this.Name = Name;
            this.Designation = Designation;
            this.DateOfJoining = DateOfJoining;
            this.Salary = Salary;

        }
        public Employee()
        {

        }
    }
}

*/



/*

//tcs hackthon 2 24aprils ss 94-96
using System;
using System.Collections.Generic;
					
public class StayWithUs
{
	public static void Main()
	{
		Hotel hotel = new Hotel();
		List<Guest> guests = new List<Guest>();
		Guest guest1 = new Guest("Shashank", 22, 3, 1, 1000);
		Guest guest2 = new Guest("Adarsh", 21, 2, 2, 2000);
		Guest guest3 = new Guest("Nikhil", 21, 5, 5, 5000);
		
		guests.Add(guest1);
		hotel.Singleroomcount--;
		guests.Add(guest2);
		hotel.Classicroomcount--;
		guests.Add(guest3);
		hotel.Deluxeroomcount--;
		
		int choice = Convert.ToInt32(Console.ReadLine());
		
		if(choice == 1)
			foreach(Guest guest in guests)
				Console.WriteLine(guest.Name+" ("+guest.Age+") + "+(guest.Inmatecount-1)+", "+guest.Duration+" day(s) - "+guest.Rent);
		
		else if(choice == 2)
		{
			string name = Console.ReadLine();
			DateTime dob = DateTime.Parse(Console.ReadLine());
			DateTime checkout = DateTime.Parse(Console.ReadLine());
			int inmates = Convert.ToInt32(Console.ReadLine());
			int rent = Convert.ToInt32(Console.ReadLine());
			bool flag = true;
			
			int age = DateTime.Now.Year - dob.Year;
			if(DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day))
				age--;
			
			if(age <= 18)
			{
				flag = false;
				Console.WriteLine("Guest is too young to accommodate.");
			}
			
			int duration = checkout.Day-DateTime.Today.Day;
			if(duration <= 0)
			{
				flag = false;
				Console.WriteLine("Duration should be greater than 0.");
			}
			if(inmates<1)
			{
				flag = false;
				Console.WriteLine("There should be atleast 1 guest.");
			}
			if(inmates>5)
			{
				flag = false;
				Console.WriteLine("Guests should not be more than 5.");
			}
			if(rent <= 0)
			{
				flag = false;
				Console.WriteLine("Invalid amount.");
			}
			if(flag)
			{
				if(inmates <= 5 && hotel.Classicroomcount != 0 && hotel.Singleroomcount != 0 && hotel.Deluxeroomcount != 0)
				{
					Guest g = new Guest(name,age,duration,inmates,rent);
					guests.Add(g);
					Console.WriteLine(name+" was added to the guest list.");
					if(inmates == 1) hotel.Singleroomcount--;
					else if(inmates <= 3) hotel.Classicroomcount--;
					else hotel.Deluxeroomcount--;
				}
				else
					Console.WriteLine(name+" cannot be added as no rooms are available.");
			}
		}
		else if(choice == 3)
		{
			Console.WriteLine("Single Rooms - "+hotel.Singleroomcount);
			Console.WriteLine("Classic Rooms - "+hotel.Classicroomcount);
			Console.WriteLine("Deluxe Rooms - "+hotel.Deluxeroomcount);
		}
		else
		{
			string name = Console.ReadLine();
			DateTime dob = DateTime.Parse(Console.ReadLine());
			int age = DateTime.Now.Year - dob.Year;
			if(DateTime.Now.Month < dob.Month || (DateTime.Now.Month == dob.Month && DateTime.Now.Day < dob.Day))
				age--;
			bool flag = true;
			Guest removed = null;
			foreach(Guest g in guests)
			{
				if(g.Name == name && g.Age == age)
				{
					if(g.Inmatecount == 1) hotel.Singleroomcount--;
					else if(g.Inmatecount <= 3) hotel.Classicroomcount--;
					else if(g.Inmatecount <= 5) hotel.Deluxeroomcount--;
					Console.WriteLine("To remove: "+name+" ("+age+") + "+(g.Inmatecount-1)+", "+g.Duration+" day(s) - "+g.Rent);
					removed = g;
					flag = false;
				}
			}
			guests.Remove(removed);
			if(flag)
				Console.WriteLine("The guest with "+name+" aged "+age+" was not found.");
		}
	}
}

class Hotel
{
	public int Singleroomcount {get; set;}
	public int Classicroomcount {get; set;}
	public int Deluxeroomcount {get; set;}
	
	public Hotel()
	{
		Singleroomcount = 5;
		Classicroomcount = 3;
		Deluxeroomcount = 2;
	}
}

class Guest
{
	public string Name {get; set;}
	public int Age {get; set;}
	public int Duration {get; set;}
	public int Inmatecount {get; set;}
	public int Rent {get; set;}
	
	public Guest(string name, int age, int duration, int inmates, int rent)
	{
		Name = name;
		Age = age;
		Duration = duration;
		Inmatecount = inmates;
		Rent = rent;
	}
}


*/






/*
//py hackthon 24april ss80 in pc

using System;
using System.Linq;
using System.Collections.Generic;
namespace ss
{
   public class Project
    {
        public int projectId { get; set; }
        public string  Pname { get; set; }
        public int Manhr { get; set; }
        public List<string> technology { get; set; }
        public int AvgpCost { get; set; }



        public Project(int projectId, string Pname, int Manhr, List<string> technology)
        {
            this.projectId = projectId;
            this.Pname = Pname;
            this.Manhr = Manhr;
            this.technology = technology;
            this.AvgpCost = 0;

        }
        public Project()
        {

        }
        public int CalProjCost(int rate)
        {
           int projCost = this.Manhr * rate;
            return projCost;
        }
    }



   public class Organisation
    {
        public string OrgName { get; set; }
        List<Project> projlist { get; set; }


        public Organisation(string OrgName,List<Project> projlist)
        {
            this.OrgName = OrgName;
            this.projlist = projlist;
        }

        public Project ProAvgCostTechnology(int projectId, int rate)
        {
            Project found = null;
           //   int c = 0;
            foreach (var p in projlist)
            {
                if (p.projectId == projectId)
                {
                   p.AvgpCost=p.CalProjCost(rate) / p.technology.Count();
                    found = p;
                    
                }
            }
            return found;
        }
    }

    class solution
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Project> li = new List<Project>();
            int projectId, Manhr;
            string Pname,technology1;
            List<string> technology = new List<string>() ;
            Project p = new Project();
            for (int i = 0; i < n; i++)
            {
                projectId = Convert.ToInt32(Console.ReadLine());
                Pname = Console.ReadLine();
                Manhr = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < c; j++)
                {
                    technology1 = Console.ReadLine();
                    technology.Add(technology1);

                }

                li.Add(new Project(projectId, Pname, Manhr, technology));
            }
                Organisation o = new Organisation("ABC",li);
                projectId = Convert.ToInt32(Console.ReadLine());
                int rate= Convert.ToInt32(Console.ReadLine());
                Project avgpj =o.ProAvgCostTechnology(projectId, rate);
           
           if(avgpj==null)
           {
                Console.WriteLine("No project exists");
           
           }
           else
           {
             Console.WriteLine(avgpj.projectId+" "+avgpj.Pname+" "+avgpj.Manhr+" ["+string.Join(", ",avgpj.technology.ToArray())+"]"+avgpj.AvgpCost);
           }

          



        }
    }
}

*/















/*
//java Hackthon 2nd april ss86 in pc

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ss
{
    public class Phone
    {
        public int Phoneid { get; set; }
        public string Os { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }

        public Phone(int Phoneid, string Os, string Brand, int Price)
        {
            this.Phoneid = Phoneid;
            this.Os = Os;
            this.Brand = Brand;
            this.Price = Price;

        }
        public Phone()
        {

        }
    }


    class Solution
    {
        static void Main()
        {
            int Phoneid, Price = 0 ;
            string Os, Brand=null;
            int n = Convert.ToInt32(Console.ReadLine());
            Phone[] P = new Phone[n];
            Phone PH = new Phone();
            for (int i = 0; i < n; i++)
            {
                Phoneid= Convert.ToInt32(Console.ReadLine());
                Os = Console.ReadLine().ToLower();
                Brand = Console.ReadLine();
                Price= Convert.ToInt32(Console.ReadLine());

                P[i] = new Phone(Phoneid, Os, Brand, Price);
            }
            Brand = Console.ReadLine().ToLower();
            Os = Console.ReadLine().ToLower();
            int BrandPrice = FindPriceForGivenBrand(P, Brand);
           if(BrandPrice!=0)
                Console.WriteLine(BrandPrice);
           else
                Console.WriteLine("The given Brand is not Available");
            Phone arr = getPhoneidBasedonOs(Os, P);
            if(arr!=null)
                Console.WriteLine(arr.Phoneid);
            else
                Console.WriteLine("No phones ara availabe in this range");
            


        }

        public static int FindPriceForGivenBrand(Phone[] p,string Brand)
        {
            int sum = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if(p[i].Brand.ToLower()==Brand.ToLower())
                {
                    sum += p[i].Price;
                }
                else
                    sum = 0;
            }
            return sum;

        }



        public static Phone getPhoneidBasedonOs(string Os,Phone[] P)
        {
            int temp=0;
            int i = 0;
            for ( i = 0; i < P.Length; i++)
            {
                if(P[i].Os==Os && P[i].Price >= 50000)
                {
                    temp++;
                    break;
                }
                
            }
            if (temp != 0)
                return P[i];
            else
                return null;


                
        }
    }
}
*/







/*
//java screenshot 79  90
using System;
using System.Collections.Generic;
namespace ss
{
    public class Question
    {
        public int QId { get; set; }
        public int Coption { get; set; }
        public string Status { get; set; }
        public int Score { get; set; }


        public Question(int QId, int Coption, int Score)
        {
            this.QId = QId;
            this.Coption = Coption;
            this.Status = "Not Answered";
            this.Score = Score;
        }

    }

    public class QuestionPaper
    {
        public int PaperId { get; set; }
        public List<Question> questionlist { get; set; }


        public QuestionPaper(int PaperId, List<Question> questionlist)
        {
            this.PaperId = PaperId;
            this.questionlist = questionlist;
        }
        public void CheckSolutions(Dictionary<int, int> Answers)
        {
            foreach (Question i in questionlist)
            {
                if (Answers.ContainsKey(i.QId))
                {
                    if (Answers[i.QId] == i.QId)
                        i.Status = "Correct";
                    else
                        i.Status = "Incorrect";

                }

            }

        }
        public string FindResult()
        {
            int studentscore = 0;
            int totalscore = 0;
            foreach (var i in questionlist)
            {
                totalscore += i.Score;
                if (i.Status == "Correct")
                    studentscore += i.Score;
                else
                    studentscore -= ((i.Score * 10) / 100);

            }
            double percentage = studentscore * 100 / totalscore;
            if (percentage > 80)
                return "Pass";
            else
                return "Fail";
        }
    }


    class Solution
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Question> qli = new List<Question>();
            for (int i = 0; i < n; i++)
            {
                int QId = Convert.ToInt32(Console.ReadLine());
                int Coption = Convert.ToInt32(Console.ReadLine());
                int Score = Convert.ToInt32(Console.ReadLine());
                qli.Add(new Question(QId, Coption, Score));
            }
            QuestionPaper qp = new QuestionPaper(12398, qli);

            Dictionary<int, int> Answers = new Dictionary<int, int>();
            int ans = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ans; i++)
            {
                int ques = Convert.ToInt32(Console.ReadLine());
                int option = Convert.ToInt32(Console.ReadLine());
                Answers.Add(ques, option);
            }
            qp.CheckSolutions(Answers);
            foreach (Question a in qp.questionlist)
            {
                Console.WriteLine(a.QId + " " + a.Status);
            }
            Console.WriteLine(qp.FindResult());





        }
    }

}
*/








/*

//java ss 94,95,96
using System;
using System.Linq;
using System.Collections.Generic;
public class Player
{
    public int Pid { get; set; }
    public string Skill { get; set; }
    public string Level { get; set; }
    public int Points { get; set; }


    public Player(int Pid,string Skill,string Level,int Points)
    {
        this.Pid = Pid;
        this.Skill = Skill;
        this.Level = Level;
        this.Points = Points;
    }



}
public class solution
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Player[] p = new Player[n];
        int Pid, Points;
        string Skill, Level;
        for (int i = 0; i < n; i++)
        {
             Pid = Convert.ToInt32(Console.ReadLine());
             Skill = Console.ReadLine();
             Level = Console.ReadLine();
             Points = Convert.ToInt32(Console.ReadLine());
            p[i] = new Player(Pid, Skill, Level, Points);
        }
        string Skill1 = Console.ReadLine().ToLower();
        string level = Console.ReadLine().ToLower();
        int result = findpointsForGivenSkill(p,Skill1);
        Player result1 = getPlayerBasedOnLevel(p, Skill1, level);
        if(result!=0)
            Console.WriteLine(result);
        else
            Console.WriteLine("The Given Skill is Not Available");
        if(result1!=null)
            Console.WriteLine(result1.Pid);
        else
            Console.WriteLine("No player is Available With Specified Level & skill");

    }
    public static int findpointsForGivenSkill(Player[] p,string Skill)
    {
        int sum = 0;
        foreach (var it in p)
        {
            if (it.Skill.ToLower() == Skill)
            {
                sum += it.Points;
            }
        }
        return sum;
    }
    public static Player getPlayerBasedOnLevel(Player[] p,string skill,string level)
    {
        
        foreach (var item in p)
        {
            if (item.Skill.ToLower() == skill && item.Level.ToLower() == level && item.Points >= 20)
            {
                return item;   
            }
            
        }
        return null; 
    }
}

*/






/*
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            List<Guest> guestlist = new List<Guest>();

            Guest guest1 = new Guest("Rini", 25, 4, 2, 20000);
            hotel.Classicroomcount--;
            Guest guest2 = new Guest("Aswin", 25, 2, 4, 15000);
            hotel.Deluxeroomcount--;
            Guest guest3 = new Guest("Sajras", 25, 10, 2, 50000);
            hotel.Classicroomcount--;

            guestlist.Add(guest1);
            guestlist.Add(guest2);
            guestlist.Add(guest3);

            int choice = Convert.ToInt32(Console.ReadLine());
            // Enter your code for performing the 5 operations View all, View by date, Adding, Display available rooms and Deleting
           
            int flag = 0;
            switch (choice)
            {
                case 1:
                    foreach (Guest guest in guestlist)
                        Console.WriteLine("{0} ({1}) + {2}, {3} day(s) - {4}", guest.Name, guest.Age, guest.Inmatecount - 1, guest.Duration, guest.Rent);
                    Console.ReadKey();
                    break;

                case 2:
                    string name = Console.ReadLine();
                    DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
                    int age = (DateTime.Today).Year - dateofbirth.Year;
                    if (age < 18)
                    {
                        Console.WriteLine("Guest is too young to accommodate.");
                        Console.ReadKey();
                        break;
                    }
                    DateTime checkoutdate = Convert.ToDateTime(Console.ReadLine());
                    int duration = (checkoutdate - DateTime.Today).Days;
                    if (duration < 1)
                    {
                        Console.WriteLine("Duration should be greater than 0.");
                        Console.ReadKey();
                        break;
                    }
                    int noofguests = Convert.ToInt32(Console.ReadLine());
                    if (noofguests < 1)
                    {
                        Console.WriteLine("There should be atleast 1 guest.");
                        Console.ReadKey();
                        break;
                    }
                    if (noofguests > 5)
                    {
                        Console.WriteLine("Guests should not be more than 5.");
                        Console.ReadKey();
                        break;
                    }
                    int rent = Convert.ToInt32(Console.ReadLine());
                    if (rent < 1)
                    {
                        Console.WriteLine("Invalid amount.");
                        Console.ReadKey();
                        break;
                    }
                    Guest newguest = new Guest(name, age, duration, noofguests, rent);
                    if (noofguests == 1)
                    {
                        if (hotel.Singleroomcount != 0)
                            hotel.Singleroomcount--;
                        else
                        {
                            Console.WriteLine("{0} cannot be added as no rooms are available.", newguest.Name);
                            Console.ReadKey();
                            break;
                        }
                    }
                    else if (noofguests <= 3)
                    {
                        if (hotel.Classicroomcount != 0)
                            hotel.Classicroomcount--;
                        else
                        {
                            Console.WriteLine("{0} cannot be added as no rooms are available.", newguest.Name);
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        if (hotel.Deluxeroomcount != 0)
                            hotel.Deluxeroomcount--;
                        else
                        {
                            Console.WriteLine("{0} cannot be added as no rooms are available.", newguest.Name);
                            Console.ReadKey();
                            break;
                        }
                    }
                    guestlist.Add(newguest);
                    Console.WriteLine("{0} was added to the guest list.", newguest.Name);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Deluxe Rooms - " + hotel.Deluxeroomcount);
                    Console.WriteLine("Classic Rooms - " + hotel.Classicroomcount);
                    Console.WriteLine("Single Rooms - " + hotel.Singleroomcount);
                    Console.ReadKey();
                    break;

                case 4:
                    name = Console.ReadLine();
                    dateofbirth = Convert.ToDateTime(Console.ReadLine());
                    age = (DateTime.Today).Year - dateofbirth.Year;
                    flag = 0;
                    foreach (Guest guests in guestlist)
                    {
                        if (name == guests.Name && age == guests.Age)
                        {
                            Console.WriteLine("To remove: {0} ({1}) + {2}, {3} day(s) - {4}", guests.Name, guests.Age, guests.Inmatecount - 1, guests.Duration, guests.Rent);
                            if (guests.Inmatecount == 1)
                                hotel.Singleroomcount++;
                            else if (guests.Inmatecount <= 3)
                                hotel.Classicroomcount++;
                            else
                                hotel.Deluxeroomcount++;
                            guestlist.Remove(guests);
                            Console.WriteLine("Removed successfully.");
                            flag++;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine("The guest with name \"{0}\" aged {1} was not found.", name, age);
                    Console.ReadKey();
                    break;
            }
           
        }
    }

    // Create class Hotel as specified. Create constructor and use public properties.
   
    class Hotel
    {
        public int Singleroomcount { get; set; }
        public int Classicroomcount { get; set; }
        public int Deluxeroomcount { get; set; }


        public Hotel()
        {
            Singleroomcount = 5;
            Classicroomcount = 3;
            Deluxeroomcount = 2;
        }
    }
   

    // Create class Guest as specified. Create constructor and use public properties.
   
    class Guest
    {

        public Guest(string name, int age, int duration, int inmatecount, int rent)
        {
            this.Name = name;
            this.Age = age;
            this.Duration = duration;
            this.Inmatecount = inmatecount;
            Checkindate = DateTime.Now;
            Checkoutdate = Checkindate.AddDays(duration);
            this.Rent = rent;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Duration { get; set; }
        public int Inmatecount { get; set; }
        public DateTime Checkindate { get; set; }
        public DateTime Checkoutdate { get; set; }
        public int Rent { get; set; }
    }

}

*/




/*
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            List<Guest> guestlist = new List<Guest>();

            Guest guest1 = new Guest("Rini", 25, 4, 2, 20000);
            hotel.Classicroomcount--;
            Guest guest2 = new Guest("Aswin", 25, 2, 4, 15000);
            hotel.Deluxeroomcount--;
            Guest guest3 = new Guest("Sajras", 25, 10, 2, 50000);
            hotel.Classicroomcount--;

            guestlist.Add(guest1);
            guestlist.Add(guest2);
            guestlist.Add(guest3);

            int choice = Convert.ToInt32(Console.ReadLine());
            // Enter your code for performing the 5 operations View all, View by date, Adding, Display available rooms and Deleting
            switch(choice)
            {
                case 1:
                    foreach (Guest item in guestlist)
                    {
                        //  Console.WriteLine($"{item.Name} ({item.Age}) + {item.Inmatecount-1},{item.Duration}(s)-{item.Rent}");
                        Console.WriteLine("{0} ({1}) +{2},{3} day(s)-{4}", item.Name, item.Age, item.Inmatecount - 1,item.Duration,item.Rent);
                    }
                    break;
                case 2:
                    string name = Console.ReadLine();
                    DateTime dateofbirth = Convert.ToDateTime(Console.ReadLine());
                    DateTime checkoutdate = Convert.ToDateTime(Console.ReadLine());
                    int inmatecount = Convert.ToInt32(Console.ReadLine());
                    int rent= Convert.ToInt32(Console.ReadLine());
                    int age = (DateTime.Today).Year - dateofbirth.Year;
                    if(age<18)
                    {
                        Console.WriteLine("Guest is too young to accommodate");
                        break;
                    }
                    int duration = (checkoutdate-DateTime.Today).Days;
                    if (duration < 1)
                    {
                        Console.WriteLine("Duration should be greater than 0.");
                        Console.ReadKey();
                        break;
                    }
                    int noofguests = Convert.ToInt32(Console.ReadLine());
                    if (noofguests < 1)
                    {
                        Console.WriteLine("There should be atleast 1 guest.");
                        Console.ReadKey();
                        break;
                    }
                    if (noofguests > 5)
                    {
                        Console.WriteLine("Guests should not be more than 5.");
                        Console.ReadKey();
                        break;
                    }
                    if(rent<1)
                    {
                        Console.WriteLine("Invalid Amounts");
                        break;
                    }
                    Guest guest = new Guest(name, age, duration, inmatecount, rent);
                    if(inmatecount==1)
                    {
                        if (hotel.Singleroomcount != 0)
                            hotel.Singleroomcount--;
                        else
                            Console.WriteLine(" {0} cannot be added as no rooms are available",guest.Name);
                        break;
                    } 
                    else if(inmatecount<=3)
                    {
                        if (hotel.Classicroomcount != 0)
                            hotel.Classicroomcount--;
                        else
                            Console.WriteLine(" {0} cannot be added as no rooms are available", guest.Name);
                        break;
                    }
                    else
                    {
                        if (hotel.Deluxeroomcount != 0)
                            hotel.Deluxeroomcount--;
                        else
                        {
                            Console.WriteLine(" {0} cannot be added as no rooms are available", guest.Name);
                            break;
                        }
                    }
                    guestlist.Add(guest);
                    Console.WriteLine("{0} was added to the guest list.",guest.Name);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Deluxe Rooms - " + hotel.Deluxeroomcount);
                    Console.WriteLine("Classic Rooms - " + hotel.Classicroomcount);
                    Console.WriteLine("Single Rooms - " + hotel.Singleroomcount);
                    Console.ReadKey();
                    break;
                case 4:
                    name = Console.ReadLine();
                    dateofbirth = Convert.ToDateTime(Console.ReadLine());
                    age = (DateTime.Today).Year - dateofbirth.Year;
                    int flag = 0;
                    foreach (Guest item in guestlist)
                    {
                        if(item.Name==name && item.Age==age)
                        {
                            Console.WriteLine("To remove: {0} ({1}) + {2}, {3} day(s) - {4}", item.Name, item.Age, item.Inmatecount - 1, item.Duration, item.Rent);
                            if (item.Inmatecount == 1)
                                hotel.Singleroomcount++;
                            else if (item.Inmatecount <= 3)
                                hotel.Classicroomcount++;
                            else
                                hotel.Deluxeroomcount++;
                            guestlist.Remove(item);
                            Console.WriteLine("Removed successfully.");
                            flag++;
                            break;
                        


                        }
                    }
                    if(flag==0)
                        Console.WriteLine("The guest with name \"{0}\" aged {1} was not found.", name, age);
                    break;






            }



        }
    }
}


// Create class Hotel as specified. Create constructor and use public properties.

class Hotel
{
    public int Singleroomcount { get; set; }
    public int Classicroomcount { get; set; }
    public int Deluxeroomcount { get; set; }


    public Hotel()
    {
        Singleroomcount = 5;
        Classicroomcount = 3;
        Deluxeroomcount = 2;
    }
}


// Create class Guest as specified. Create constructor and use public properties.

class Guest
{

    public Guest(string name, int age, int duration, int inmatecount, int rent)
    {
        this.Name = name;
        this.Age = age;
        this.Duration = duration;
        this.Inmatecount = inmatecount;
        Checkindate = DateTime.Now;
        Checkoutdate = Checkindate.AddDays(duration);
        this.Rent = rent;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public int Duration { get; set; }
    public int Inmatecount { get; set; }
    public DateTime Checkindate { get; set; }
    public DateTime Checkoutdate { get; set; }
    public int Rent { get; set; }
}

*/





/*

//solved for practice
using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime;

public class Employee
{
    public int Eid { get; set; }
    public string  Name { get; set; }
    public string Designation { get; set; }
    public DateTime DateofJ { get; set; }
    public int Salary { get; set; }



    public Employee(int Eid, string Name, string Designation, DateTime DateofJ, int Salary)
    {
        this.Eid = Eid;
        this.Name = Name;
        this.Designation = Designation;
        this.DateofJ = DateofJ;
        this.Salary = Salary;
    }
    public Employee()
    {

    }
}

class program
{
    static Employee employee = new Employee();
    static List<Employee> employeelist = new List<Employee>();
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[10];

        employees[0] = new Employee(1001, "David Backham", "President", Convert.ToDateTime("01-11-2018"), 2010203);
        employees[1] = new Employee(1002, "Zinedine Zindane", "Manager", Convert.ToDateTime("01-02-2016"), 1862015);
        employees[2] = new Employee(1003, "Aditya Bidkar", "Manager", Convert.ToDateTime("05-12-2019"), 1650542);
        employees[3] = new Employee(1004, "Arnav Bidkar", "Forward", Convert.ToDateTime("01-11-2001"), 2015321);
        employees[4] = new Employee(1005, "Aditi Desh", "Forword", Convert.ToDateTime("11-11-2003"), 2405021);
        employees[5] = new Employee(1006, "Daniel Vebar", "Forword", Convert.ToDateTime("10-07-2002"), 2403578);
        employees[6] = new Employee(1007, "Dan Veb", "Midfilder", Convert.ToDateTime("05-11-2006"), 1654891);
        employees[7] = new Employee(1008, "Don jack", "Midfilder", Convert.ToDateTime("01-11-2008"), 1620123);
        employees[8] = new Employee(1008, "Ab raje", "Defender", Convert.ToDateTime("01-07-2007"), 1402320);
        employees[9] = new Employee(1009, "Ter strgen", "Goalkeeper", Convert.ToDateTime("04-10-2011"), 1657801);



        for (int i = 0; i < 10; i++)
            employeelist.Add(employees[i]);


        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            default:
                Console.WriteLine("WRONG CHOICE");
                break;
            case 1:
                int salary = Convert.ToInt32(Console.ReadLine());
                ArrayList al = GetEmployeeDetails(salary);
                foreach (string it in al)
                {
                    Console.WriteLine(it);
                }
                break;
            case 2:
                string designation = Console.ReadLine();
                int count = 0;
                int z = EmployeeStatistics(designation, out count);
                if(count==0)
                    Console.WriteLine("NO one Found");
                //else
                //    {
                //        Console.WriteLine("Designation - "+Des+", "+count+"employee(s) earn "+z+"in total");
                //    }
                break;
            case 3:
                string designation2 = Console.ReadLine();
                foreach (Employee item in employeelist)
                {
                    
                    if(item.Designation.Equals(designation2))
                    {
                        Console.WriteLine(item.Name);
                       int j =(item.Salary * 20) / 100;
                        Console.WriteLine(j+item.Salary);
                    }
                }
                break;
        }


    }

    public static ArrayList GetEmployeeDetails(int salary)
    {
        ArrayList m = new ArrayList();
        foreach (Employee item in employeelist)
        {
            if (item.Salary > salary)
                  m.Add(item.Name);
        }
        return m;
    }

    public static int EmployeeStatistics(string designation,out int count)
    {
        int s = 0, j = 0;
        foreach (Employee item in employeelist)
        {
            if(item.Designation.Equals(designation))
            {
                s++;
                j += item.Salary;
            }
        }
        count = s;
        return j;
    }
}

*/




/*    //python OPA ss availabel
using System;
using System.Collections.Generic;
public class Professor
{
    public int ProfId { get; set; }
    public string ProfName { get; set; }
    public Dictionary<string,int> SubjectsDict { get; set; }


    public Professor(int ProfId, string ProfName, Dictionary<string, int> SubjectsDict)
    {
        this.ProfId = ProfId;
        this.ProfName = ProfName;
        this.SubjectsDict = SubjectsDict;
    }
}
public class University
{
    public int getTotalExperience(List<Professor> pli,int ProfId)
    {
        int TotalEXP = 0;
        foreach (Professor item in pli)
        {
            if(item.ProfId==ProfId)
            {
                foreach (var i in item.SubjectsDict.Values)
                {
                    TotalEXP += i;
                }
                
            }
                
                
        }
        return TotalEXP;
    }
    public Professor SeletSeniorProfBySubject(List<Professor> pli,string sub1)
    {
        Professor c = null;
        int max = 0;
        foreach (Professor item in pli)
        {
            if(item.SubjectsDict.ContainsKey(sub1))
            {
                if (item.SubjectsDict[sub1] > max)
                {
                    max = item.SubjectsDict[sub1];
                    c = item;
                }
                   
            }
        }
        return c;

    }
}

public class Solution
{
   public static void Main()
    {
        int n = 4;
        int ProfId = 0;
        string ProfName;
        List<Professor> pli = new List<Professor>();
        for (int i = 0; i < n; i++)
        {
            Dictionary<string, int> SubjectsDict = new Dictionary<string, int>();

            ProfId = Convert.ToInt32(Console.ReadLine());
            ProfName = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < k; j++)
            {
                string sub = Console.ReadLine(); 
                int exp= Convert.ToInt32(Console.ReadLine());
                SubjectsDict.Add(sub, exp);
            }
            pli.Add(new Professor(ProfId, ProfName, SubjectsDict));
        }
        University u = new University();
        int c=u.getTotalExperience(pli,ProfId);
        Console.WriteLine(c);

        string sub1 = Console.ReadLine();
        Professor v=  u.SeletSeniorProfBySubject(pli, sub1);

        if(v==null)
            Console.WriteLine("NONE");
        else
        {
            Console.Write(v.ProfId + " " + v.ProfName+" ");
            foreach (var item in v.SubjectsDict.Keys)
            {
                Console.Write("{"+item+" "+v.SubjectsDict[item]+"}");
            }
        }

    }
}
*/






/*
//python opa 22 may ss Availabel
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Doctor
{
    public int DocId { get; set; }
    public string DocName { get; set; }
    public string Specialization { get; set; }
    public int ConsultationFee { get; set; }

    public Doctor(int DocId, string DocName, string Specialization, int ConsultationFee)
    {
        this.DocId = DocId;
        this.DocName = DocName;
        this.Specialization = Specialization;
        this.ConsultationFee = ConsultationFee;

    }
    public Doctor()
    {

    }
  
}

public class Hospital
{
    public Dictionary<int,Doctor> DocDB { get; set; }
    public Hospital(Dictionary<int,Doctor> DocDB)
    {
        this.DocDB = DocDB;
    }

    public List<Doctor> SearchDocByName(string DocName)
    {
        List<Doctor> dli = new List<Doctor>();
        
            foreach (var a in DocDB.Values)
            {
                if (a.DocName == DocName)
                {
                    dli.Add(a);
                }
                
            }


        if (dli.Count == 0)
        {
            return null;

        }
        else
            return dli;



    }

    public int CalculateConsultantFeeBySpecialization(string Spel)
    {
        int l = 0;
        foreach (var item in DocDB.Values)
        {
            if(item.Specialization==Spel)
            {
                l += item.ConsultationFee;
            }
        }
        if (l == 0)
        {
            return 0;
        }
        else
            return l;
            
       

    }



}

public class Solution
{
    static void Main()
    {
        int DocId, ConsultationFee = 0;
        string DocName, Specialization;
        int n = Convert.ToInt32(Console.ReadLine());
        List<Doctor> Dli = new List<Doctor>();
        Doctor d = new Doctor();
        Dictionary<int, Doctor> Dict = new Dictionary<int, Doctor>();

        for (int i = 0; i < n; i++)
        {
            DocId = Convert.ToInt32(Console.ReadLine());
            DocName = Console.ReadLine();
            Specialization = Console.ReadLine();
            ConsultationFee = Convert.ToInt32(Console.ReadLine());
            d = new Doctor(DocId,DocName,Specialization,ConsultationFee);
            Dict.Add(i,d);

        }
        Hospital h = new Hospital(Dict);
        DocName = Console.ReadLine();
        Specialization = Console.ReadLine();
        var li2=h.SearchDocByName(DocName);

        int e=h.CalculateConsultantFeeBySpecialization(Specialization);
        if(li2.Count!=0)
            foreach (var item in li2)
            {
                Console.WriteLine(item.DocId);
                Console.WriteLine(item.DocName);
                Console.WriteLine(item.Specialization);
                Console.WriteLine(item.ConsultationFee);
            }
        else
            Console.WriteLine("No Doctor Exists With The Given Doctor Name");
        if(e!=0)
            Console.WriteLine(e);
        else
            Console.WriteLine("No Doctor with Given Specilization");

    }
}
*/








/*


//c# opa 21may
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        //prewritten code by hacker rank
        List<Department> departments = new List<Department>
        {
            new Department() {DepartmentID=1, DepartmentName="EEE", Location="Mumbai"},
            new Department() {DepartmentID=2, DepartmentName="ECE", Location="Chennai"},
            new Department() {DepartmentID=3, DepartmentName="CSE", Location="Mumbai"},
            new Department() {DepartmentID=4, DepartmentName="IT", Location="Chennai"}
        };

        List<Student> studentList = new List<Student>();
        studentList.Add(new Student("Priya", 23, 1));
        studentList.Add(new Student("Madhu", 25, 2));
        studentList.Add(new Student("Asha", 24, 1));
        studentList.Add(new Student("Arpit", 23, 1));
        studentList.Add(new Student("Bhavik", 25, 4));
        studentList.Add(new Student("Kamala", 23, 2));

        int choice = Convert.ToInt32(Console.ReadLine());
        //write ur code
        switch (choice)
        {
            case 1:
                {
                    foreach (Student stud in studentList)
                    {
                        string location = "";
                        string name = "";
                        foreach (Department dept in departments)
                        {
                            if (dept.DepartmentID == stud.Department)
                            {
                                location = dept.Location;
                                name = dept.DepartmentName;
                            }
                        }
                        Console.WriteLine(stud.Name + " (" + stud.Age + ") - Department : " + name + "," + location);
                    }
                    break;
                }
            case 2:
                {
                    string name = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age < 18)
                    {
                        Console.WriteLine(name + " is too young to join.");
                        break;
                    }
                    else if (age > 25)
                    {
                        Console.WriteLine(name + " is too old to join.");
                        break;
                    }
                    string deptName = Console.ReadLine();
                    string deptLoc = Console.ReadLine();
                    int deptId = 0;

                    foreach (Department dept in departments)
                    {
                        if (dept.DepartmentName==deptName && dept.Location==deptLoc)
 -                           deptId = dept.DepartmentID;
                             break;
                    }

                    if (deptId == 0)
                    {
                        Console.WriteLine("Department does not exist.");
                        break;
                    }
                    if (deptId == 1)
                    {
                        Console.WriteLine("Student limit exceeded");
                        break;
                    }
                    studentList.Add(new Student(name, age, deptId));
                    Console.WriteLine(name + " has been added successfully.");
                    foreach (Student stud in studentList)
                        Console.WriteLine(stud.Name + " (" + stud.Age + ") - Department : " + deptName);
                    break;
                }
        }
    }
}
class Department
{
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; }
    public string Location { get; set; }

    public Department() { }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Department { get; set; }

    public Student(string name, int age, int dept)
    {
        Name = name;
        Age = age;
        Department = dept;
    }
}



*/



/*
//OPA 5 june(java)
using System;
using System.Collections.Generic;
using System.Linq;
public class Movie
{
    public int MovieId { get; set; }
    public string Director { get; set; }
    public int Rating { get; set; }
    public int Budget { get; set; }

    public Movie(int MovieId, string Director, int Rating, int Budget)
    {
        this.MovieId = MovieId;
        this.Director = Director;
        this.Rating = Rating;
        this.Budget = Budget;
    }
}

public class Solution
{
    public static void Main()
    {
        Movie[] M = new Movie[4];
        for (int i = 0; i < 4; i++)
        {
            int MovieId = Convert.ToInt32(Console.ReadLine());
            string Director = Console.ReadLine();
            int Rating= Convert.ToInt32(Console.ReadLine());
            int Budget= Convert.ToInt32(Console.ReadLine());

            M[i] = new Movie(MovieId, Director, Rating, Budget);
        }

        string Director1 = Console.ReadLine();
        int Rating1 = Convert.ToInt32(Console.ReadLine());
        int Budget1 = Convert.ToInt32(Console.ReadLine());
        int ans = FindAvgBudgetByDirector(M, Director1);
        if(ans>0)
        {
            Console.WriteLine(ans);
        }
        else
            Console.WriteLine("Sorry- The given Director has not yet direct any movie ");

        
        Movie Mo = GetMovieByRatingBudget(M,Rating1,Budget1);
        if(Mo!=null)
        {
            Console.WriteLine(Mo.MovieId);
        }
       else
            Console.WriteLine("Sorry - No movie is availabel with the specified rating and budget requirement ");
    }

    public static int FindAvgBudgetByDirector(Movie[] M,string Director)
    {
        int avg, a = 0, j = 0; ;
        for (int i = 0; i < M.Length; i++)
        {
            if(M[i].Director.Equals(Director,StringComparison.OrdinalIgnoreCase))
            {
                a += M[i].Budget;
                j++;
            }
        }
        if (j > 0)
        {
            avg = a / j;
            return avg;
        }
        else
            return 0;
    }

    public static Movie GetMovieByRatingBudget(Movie[] M,int Rating1, int Budget1)
    {
        Movie mov = null ;

        //foreach (var item in M)
        //{
        //    if((item.Rating==Rating1) && (item.Budget==Budget1) && (item.Budget % item.Rating==0))
        //    {

        //        mov = item;
        //        return mov;
        //    }
        //}
        for (int i = 0; i < M.Length; i++)
        {
            if((M[i].Rating==Rating1) && (M[i].Budget==Budget1) && (M[i].Budget%M[i].Rating==0))
            {
                mov = M[i];
                return mov;
            }
        }
        return null;
    }
}


*/







/*
//c# opa 12 june ss availabel 130 & 131

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userlist = new List<User>();

            User user1 = new User("Aragorn", 34, "Rivendell");
            User user2 = new User("Legolas", 29, "Mirkwood");
            User user3 = new User("Gimli", 31, "Helms Deep");
            User user4 = new User("Boromir", 33, "Gondor");
            User user5 = new User("Gandalf", 69, "Lonely Mountain");

            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);
            userlist.Add(user4);
            userlist.Add(user5);

            List<Order> orderlist = new List<Order>();

            for (int i = 0; i < 13; i++)
            {
                string name = Console.ReadLine();
                DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
                int quantity = Convert.ToInt32(Console.ReadLine());
                int price = Convert.ToInt32(Console.ReadLine());
                string address = Console.ReadLine();
                Order order = new Order(name, orderdate, quantity, price, address);
                orderlist.Add(order);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            // Click the "..." next to "using System" statement to view the code            
            // Write your code below to performing the 3 operations
            // 1. Take in new Orders
            // 2. Display the 5 most expensive
            // 3. Display all orders made by users to a different address
            switch (choice)
            {
                case 1:
                    {
                        string name = Console.ReadLine();
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        DateTime today = DateTime.Now;
                        if (date > today)
                        {
                            Console.WriteLine("Order date should not be a future date");
                            break;
                        }
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        if (quantity < 1)
                        {
                            Console.WriteLine("There should be atleast 1 item");
                            break;
                        }
                        int price = Convert.ToInt32(Console.ReadLine());
                        if (price <= 0)
                        {
                            Console.WriteLine("Price is invalid");
                            break;
                        }
                        string address = Console.ReadLine();
                        Order newOrder = new Order(name, date, quantity, price, address);
                        orderlist.Add(newOrder);
                        Console.WriteLine("New order has been placed successfully");
                        break;
                    }
                case 2:
                    {
                        orderlist.Sort();
                        print(orderlist);
                        break;
                    }

                case 3:
                    {
                        orderlist.Sort((a, b) => a.orderdate.CompareTo(b.orderdate));
                        for (int i = 0; i < orderlist.Count; i++)
                        {
                            Order o = orderlist[i];
                            for (int j = 0; j < userlist.Count; j++)
                            {
                                if (o.name.Equals(userlist[j].name))
                                {
                                    if (!o.address.Equals(userlist[j].address))
                                    {
                                        Console.WriteLine(o.name + " ordered " + o.quantity + " item(s) on " + o.orderdate + " to " + o.address + " instead of " + userlist[j].address);
                                    }
                                }
                            }
                        }
                        break;

                    }



            }



        }

        public static void print(List<Order> orderlist)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(orderlist[i].Name + " - On " + orderlist[i].OrderDate + ", " + orderlist[i].Quantity + " item(s) worth " + orderlist[i].Price + " to " + orderlist[i].Address);
            }
        }
    }

    // Create class User as specified. Create constructor and use public properties.

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public User(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }

    // Create class Order as specified. Create constructor and use public properties.

    class Order 
    {
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }

        public Order(string name, DateTime date, int quantity, int price, string address)
        {
            Name = name;
            OrderDate = date.Date;
            Quantity = quantity;
            Price = price;
            Address = address;
        }

      
    }

}
*/




/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userlist = new List<User>();

            User user1 = new User("Aragorn", 34, "Rivendell");
            User user2 = new User("Legolas", 29, "Mirkwood");
            User user3 = new User("Gimli", 31, "Helms Deep");
            User user4 = new User("Boromir", 33, "Gondor");
            User user5 = new User("Gandalf", 69, "Lonely Mountain");

            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);
            userlist.Add(user4);
            userlist.Add(user5);

            List<Order> orderlist = new List<Order>();

            for (int i = 0; i < 13; i++)
            {
                string name = Console.ReadLine();
                DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
                int quantity = Convert.ToInt32(Console.ReadLine());
                int price = Convert.ToInt32(Console.ReadLine());
                string address = Console.ReadLine();
                Order order = new Order(name, orderdate, quantity, price, address);
                orderlist.Add(order);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            // Click the "..." next to "using System" statement to view the code            
            // Write your code below to performing the 3 operations
            // 1. Take in new Orders
            // 2. Display the 5 most expensive
            // 3. Display all orders made by users to a different address
            
            switch(choice)
            {
                case 1:
                    string name = Console.ReadLine();
                    DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
                    DateTime today = DateTime.Now;
                    if(orderdate>today)
                    {
                        Console.WriteLine("Order date should not be a future date");
                        break;
                    }
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    if(quantity<1)
                    {
                        Console.WriteLine("There should be atleast 1 item");
                        break;

                    }
                    int price = Convert.ToInt32(Console.ReadLine());
                    if(price<=0)
                    {
                        Console.WriteLine("price is invalid");
                        break;

                    }
                    string address = Console.ReadLine();
                    Order myorder = new Order(name, orderdate, quantity, price, address);
                    orderlist.Add(myorder);
                    Console.WriteLine("New oeder has been placed successfully");


                    break;
                case 2:
                    List<Order> Sortedorder = orderlist.OrderByDescending(n => n.Price).ToList();
                    foreach (Order item in Sortedorder.Take(5))
                    {
                        Console.WriteLine(item.Name + " - On " + item.OrderDate + ", " + item.Quantity + " item(s) worth " + item.Price + " to " + item.Address);
                    }
                    break;
                case 3:
            
                    List<Order> so2 = orderlist.OrderBy(m => m.OrderDate).ToList();
                    foreach (Order o in so2 )
                    {
                        User user = userlist.Find(x => x.Name.Contains(o.Name));
                        if(o.Address!=user.Address)
                        {
                              Console.WriteLine(o.Name + " ordered " + o.Quantity + " item(s) on " + o.OrderDate + " to " + o.Address + " instead of " + user.Address);
                        }
                    }
                    //forech(order o in orderlist)
                    //{
                    //    forech(user u in userlist)
                    //{
                    //    if(o.name==u.name)
                    //{
                    //    if(u.address!=u.address)
                    //{
                    //    Console.WriteLine(o.Name + " ordered " + o.Quantity + " item(s) on " + o.OrderDate + " to " + o.Address + " instead of " + u.Address);
                    //}
                    //}
                    //}

                    //}
                    break;
            }


        }

       
    }

    // Create class User as specified. Create constructor and use public properties.

   public class User
   {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public User(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }

    // Create class Order as specified. Create constructor and use public properties.

   public class Order
   {
        public string Name { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }

        public Order(string name, DateTime date, int quantity, int price, string address)
        {
            Name = name;
            OrderDate = date.Date;
            Quantity = quantity;
            Price = price;
            Address = address;
        }


    }

}





*/


/*
using System;
class sol
{
    static void Main()
    {
        string add = Console.ReadLine();
        DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
        int check = DateTime.Compare(orderdate, DateTime.Today);
        Console.WriteLine(check);
    }
}
*/





using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string productName = Console.ReadLine();
                string category = Console.ReadLine();
                if (category == "Goods")
                {
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    float unitPrice = Convert.ToInt32(Console.ReadLine());
                    int id = manager.AddProduct(productName, category, unitPrice, quantity);
                }
                else
                {
                    float unitPrice = Convert.ToInt32(Console.ReadLine());
                    int id = manager.AddProduct(productName, category, unitPrice);
                }
            }

            int choice = Convert.ToInt32(Console.ReadLine());
            // Enter code for handling 4 operations
            switch (choice)
            {
                case 1:
                    string ProductName = Console.ReadLine();
                    string category = Console.ReadLine();
                    if (category == "Goods")
                    {
                        int quantity1 = Convert.ToInt32(Console.ReadLine());
                        float unitPrice1 = Convert.ToInt32(Console.ReadLine());
                        int id = manager.AddProduct(ProductName, category, unitPrice1, quantity1);

                        if(id==0)
                        {
                            Console.WriteLine("Product already exists can not add again");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The product " + ProductName + " has been added with product id " + id);
                            break;
                        }
                    }
                    else if(category=="Services")
                    {
                        float unitPrice1 = Convert.ToInt32(Console.ReadLine());
                        int id = manager.AddProduct(ProductName, category, unitPrice1);
                        if (id == 0)
                        {
                            Console.WriteLine("Product already exists can not add again");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The product " + ProductName + " has been added with product id " + id);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong category!");
                        break;

                    }
                    break;
                case 2:
                    int productid = int.Parse(Console.ReadLine());
                    int quantity = int.Parse(Console.ReadLine());
                    float unitPrice = Convert.ToInt32(Console.ReadLine());
                    Product pp = manager.UpdateProduct(productid, quantity, unitPrice);
                    Console.WriteLine(pp == null ? "Product does not exist, cannot modify" : "The product " + pp.productName + " has been updated with quantity " + pp.quantity + " and unit price" + pp.unitPrice);
                    break;

                case 3:
                    string category2 = Console.ReadLine();
                    if(category2!="Goods" && category2!="Services" )
                    {
                        Console.WriteLine("Wrong category!");
                        break;

                    }
                    else
                    {
                        List<Product> prods = manager.ViewProducts(category2);
                        if(category2=="Goods")
                        {
                            Console.WriteLine("Category: Goods,Tax:12%");
                            foreach (Product prod in prods)
                                Console.WriteLine($"{prod.productid}, {prod.productName}: {prod.quantity} left, unit price: {prod.unitPrice}, total price: {prod.totalPrice}");
                        }
                        else
                        {
                            Console.WriteLine("Category: Services, Tax = 10%");
                            foreach (Product prod in prods)
                                Console.WriteLine($"{prod.productid}, {prod.productName}: {prod.quantity} left, unit price: {prod.unitPrice}, total price: {prod.totalPrice}");

                        }



                    }
                    break;
                case 4:
                    int goods, services;
                    manager.Statistics(out goods, out services);
                    if (goods != 0 && services != 0)
                    {
                        Console.WriteLine($"Category: Goods, Products: {goods}");
                        Console.WriteLine($"Category: Services, Products: {services}");
                    }
                    else Console.WriteLine("No products found");
                    break;


                    //break;
            }



        }
    }

    // Create class Product as per given specification
    public class Product
    {
        public int productid { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public float unitPrice { get; set; }
        public float tax { get; set; }
        public float totalPrice { get; set; }

        public Product(int productid, string productName, string category, int quantity, float unitPrice,float tax,float TotalPrice)
        {
            this.productid = productid;
            this.productName = productName;
            this.category = category;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.tax =category=="Goods" ? 0.12f * unitPrice : 0.10f * unitPrice;
            this.totalPrice = unitPrice + tax;

        }

        public Product(int productid, string productName, string category, float unitPrice, int quantity)
        {
            this.productid = productid;
            this.productName = productName;
            this.category = category;
            this.unitPrice = unitPrice;
            this.quantity = quantity;



        }


    }



    // Create class ProductManager as per given specification.
    // Write methods that will perform operations handled in solution1.

    public class ProductManager
    {
        List<Product> products { get; set; }
        public int Productid = 100;

        public int AddProduct(string productName,string category,float unitPrice,int quantity=0)
        {
            if (products.Exists(x => x.productName == productName))
            {
                return 0;
            }
            else
                products.Add(new Product(++Productid, productName, category, unitPrice, quantity));
            return Productid;
            
        }

      public Product UpdateProduct(int Pid,int qnt,float uPrice)
      {
            Product p = products.Find(c => c.productid == Pid);
            if(p!=null)
            {
                qnt = p.quantity;
                uPrice = p.unitPrice;
            }
            return p;
      }
        
        public List<Product> ViewProducts(string category)
        {
            List<Product> pp = null;
            pp = products.FindAll(x => x.category == category);
            return pp;

        }

        public void Statistics(out int goods, out int services)
        {
            goods = products.FindAll(x => x.category == "Goods").Count;
            services = products.FindAll(x => x.category == "Services").Count;
        }

    }



}