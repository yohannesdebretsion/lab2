using System;
namespace lab2;

class PersonDB
{

    public string Name
    {
        get;
        set;
    }
    public HashSet<string> Phonenumber
    {
        get;
        set;
    }
    public PersonDB(string name)
    {
        this.Name = name;
        Phonenumber = new HashSet<string>();
    }
    public void AddEntry(string phone)
    {
        // foreach (var phonecheck in Phonenumber)
        // {
        //     if (phonecheck == phone)
        //     {
        //         Console.WriteLine("sorry The phone number is already exist");
        //         return;
        //     }

        // }  
        if (Phonenumber.Add(phone))
        {
            Console.WriteLine("Phone Number is aded successfully");
        }
        else
        {
            Console.WriteLine("Sorry The Number is Already Exist");
        }



    }
    public void FindPhones()
    {
        Console.WriteLine($"Name: {Name}");
        if (Phonenumber.Count == 0)
        {
            Console.WriteLine("have no phone number");
        }
        else
        {
            foreach (string phone in Phonenumber)
            {


                Console.WriteLine($"Phone number: {phone}");


            }
        }

    }

    public void RemoveEntry(string phone)
    {
        if (Phonenumber.Remove(phone))
        {
            Console.WriteLine("Phone Number is Removed successfully");
        }
        else
        {
            Console.WriteLine("the phone u entered is not belong to " + Name);
        }

    }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        if (Phonenumber.Count == 0)
        {
            Console.WriteLine("have no phone number");
        }
        else
        {
            foreach (string phone in Phonenumber)
            {


                Console.WriteLine($"Phone number: {phone}");


            }
        }

    }



}