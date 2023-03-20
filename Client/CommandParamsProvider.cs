using System;


namespace MyShop.CommonLib
{
    internal class CommandParamsProvider
    {
        public static String CreateForLogin()
        {
            return AskForMail();
        }

        public static CustomerInfo CreateForCreateCustomer()
        {
            String firstName = AskForStringParam("first name");
            String lastName = AskForStringParam("last name");
            String address = AskForStringParam("address");
            String city = AskForStringParam("city");
            String number = AskForStringParam("number");
            String mail = AskForMail();

            return new CustomerInfo()
            {
                FirstName = firstName,
                LastName = lastName,
                Mail = mail,
                Address = address,
                City = city,
                Number = number
            };
        }

        private static String AskForStringParam(String param)
        {
            Console.WriteLine("Enter your {0}:", param);
            String name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("{0} is not valid, try again:", param);
                name = Console.ReadLine();
            }
            return name;
        }

        private static String AskForMail()
        {
            Console.WriteLine("Enter your mail to login:");
            String mail = Console.ReadLine();
            while (!VerifyMail(mail))
            {
                Console.WriteLine("Email is not valid, try again:");
                mail = Console.ReadLine();
            }
            return mail;
        }

        private static Boolean VerifyMail(String mail)
        {
            if (String.IsNullOrEmpty(mail))
                return false;
            if (!mail.Contains("@"))
                return false;
            return true;
        }
    }
}
