using System;
using System.Collections.Generic;
namespace lab2;

class Program
{
    static void Main()
    {

        /*  Dictionary<string, HashSet<string>> person = new Dictionary<string, HashSet<string>>();
          person.Add(
              "Yohannes",
              new HashSet<string>()

          );

          person["Yohannes"] = new HashSet<string>
          {
              "0933793230",
              "011994",
              "2321323",
              };
          person["john"] = new HashSet<string>
          {
              "0933793230",
              "011994",
              "2321323",
              };
          person["Yohannes"].Add("123444");
          foreach (var Listofp in person)
          {
              Console.WriteLine(Listofp.Key + " " + " has those phone numbers");
              foreach (var EP in Listofp.Value)
              {
                  Console.WriteLine("-" + EP);
              }
          }*/
        //PersonDB T1 = new PersonDB("Yohannes");
        // PersonDB T2 = new PersonDB("Suleman");
        //this phone is a dictionary which contains a key which the name of the person and an object as to containe the phone numbers of the person
        Dictionary<string, PersonDB> phone =
            new Dictionary<string, PersonDB>()
            {
                ["Yohannes"] = new PersonDB("Yohannes"),
                ["Suleman"] = new PersonDB("Suleman"),
                ["John"] = new PersonDB("John"),
                ["Bob"] = new PersonDB("Bob"),

            };
        while (true)
        {
            Console.WriteLine("What do you want to Do");
            Console.WriteLine("1. To add Phone numbers");
            Console.WriteLine("2. To Find Phone numbers of The person");
            Console.WriteLine("3. To Remove Phone numbers");
            Console.WriteLine("4. To Display ALL Phone numbers");
            Console.WriteLine("5. To Exit From The Program");
            string? key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("Enter name You want To Add Phone number");
                    string? name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Name Can't be Empity");
                    }
                    else if (phone.ContainsKey(name))
                    {
                        Console.WriteLine("Enter The Phone Number");
                        string? Phonenumber = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(Phonenumber))
                        {
                            Console.WriteLine("pohne cannot be Empity");
                        }
                        else
                        {
                            phone[name].AddEntry(Phonenumber);

                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry The name you Entered isn't Element of our Member");

                    }
                    break;
                case "2":
                    Console.WriteLine("enter name ");
                    string? findperson = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(findperson))
                    {
                        Console.WriteLine("Name Can't be Empity");
                    }
                    else if (phone.ContainsKey(findperson))
                    {
                        phone[findperson].FindPhones();
                    }
                    else
                    {
                        Console.WriteLine("Sorry The name you Entered is not element of telephone domain");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter name of The Person");
                    string? namer = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(namer))
                    {
                        Console.WriteLine("Name Can't be Empity");
                    }
                    else if (phone.ContainsKey(namer))
                    {
                        Console.WriteLine("Enter Phone Number to be Removed");
                        string? Phonenumber = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(Phonenumber))
                        {
                            Console.WriteLine("pohne cannot be Empity");
                        }
                        else
                        {
                            phone[namer].RemoveEntry(Phonenumber);

                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry The name you Entered isn't Element of our Member");

                    }
                    break;
                case "4":
                    foreach (var person in phone)
                    {

                        person.Value.Display();
                        Console.WriteLine();
                    }
                    break;
                case "5":
                    Console.WriteLine("Your Exiting From The Program");
                    return;
                default:
                    Console.WriteLine("Try Another Key");
                    break;

            }


        }
    }
}
