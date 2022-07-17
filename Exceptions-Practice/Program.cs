using Exceptions_Practice.Authentication;
using Exceptions_Practice.Exceptions;
using Exceptions_Practice.Models;
using System;
using System.Collections.Generic;

namespace Exceptions_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // FindAll methodunu MyList class-na yazmisam. Mainde Homework regionunda cagirmisam.

            #region Homework
            //MyList<int> nums = new MyList<int>();

            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);
            //nums.Add(1);

            //nums.Clear();
            //nums.Add(1);

            //nums.GetAll();

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            //nums.AddRange(list);

            //nums.GetAll();

            //MyList<string> names = new MyList<string>();

            //names.Add("Emil");
            //names.Add("Seid");
            //names.Add("Orxan");

            //var result = names.Find(m => m == "Orxan");

            //Console.WriteLine(result);

            //MyList<string> names = new MyList<string>();

            //names.Add("Emil");
            //names.Add("Seadet");
            //names.Add("Orxan");
            //names.Add("Emil");

            //var result = names.FindAll(m => m == "Emil");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exceptions
            //try
            //{
            //    int a = 5;
            //    int b = 0;

            //    var result = a / b;

            //    int[] arr = new int[3];

            //    arr[7] = 8;
            //}
            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("extra information");
            //}

            //Divide(18, 3);

            //List<string> list = new List<string>() { "Emil", "Seadet", "Orxan" };

            //string searchText = "Emil";

            //FindName(list, searchText);
            #endregion

            #region AccountException
            //Login("emilaa@code.eu.az", 12345);
            #endregion
        }

        #region Exceptions
        //public static void FindName(List<string> names, string name)
        //{
        //    try
        //    {
        //        if (!names.Contains(name))
        //        {
        //            throw new FindNameException("Not found name");
        //        }

        //        Console.WriteLine("Found");

        //        var data = names.Find(m => m == name);

        //        if (data is null) throw new FindNameException("Not found name");

        //        Console.WriteLine("Found");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public static void Divide(int num1, int num2)
        //{
        //    try
        //    {
        //        if (num2 == 2)
        //        {
        //            throw new DivideException("Num 2 cant equal 2");
        //        }

        //        Console.WriteLine(num1 / num2);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}
        #endregion

        #region AccountException
        //public static void Login(string email, int password)
        //{
        //    try
        //    {
        //        if (email == "emilaa@code.edu.az" && password != 12345)
        //        {
        //            throw new AccountException("Wrong password");
        //        }

        //        Console.WriteLine("Successful login");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}
        #endregion
    }
}
