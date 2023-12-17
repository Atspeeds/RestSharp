using RestSharpCourses.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestSharpCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsersContext users = new UsersContext();



            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("");



            Console.WriteLine("List Users:");
            foreach (var item in users.GetUser())
            {
                Console.Write($"UserName: {item.UserName} --- Emaile: {item.Email} ---  ID:  {item.KeyId} \n \n");
            }



            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("");



            Console.Write("Get User ID: ");
            int idUser = Console.Read();
            Console.WriteLine("List Users:");
            var user = users.GetUser(idUser);
            Console.Write($"UserName: {user.UserName} --- Emaile: {user.Email} ---  ID:  {user.KeyId}");



            Console.WriteLine("_____________________________________________________________________");

           
        }
    }
}
