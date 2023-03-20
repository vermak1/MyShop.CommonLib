using System;

namespace MyShop.CommonLib
{
    public class ActionsProvider
    {
        public static String ChooseAvailableActionsBeforeLogin()
        {
            Int32 code = -1;
            while (code == -1)
                code = AskUserForCommandBeforeLogin();

            switch(code)
            {
                case 0:
                    String mail = CommandParamsProvider.CreateForLogin();
                    return CommandFactory.CreateLoginCommandJson(mail);
                case 1:
                    CustomerInfo customerInfo = CommandParamsProvider.CreateForCreateCustomer();
                    return CommandFactory.CreateCreateCustomerCommandJson(customerInfo);

                default:
                    throw new ArgumentException("Can't find available command to provide");
            }
        }
        private static void PrintActionsBeforeLogin()
        {
            Console.WriteLine("You can either login or create new customer" +
                            "\n0 - Login" +
                            "\n1 - Creating new customer");
        }

        private static Int32 AskUserForCommandBeforeLogin()
        {
            PrintActionsBeforeLogin();
            String input = Console.ReadLine();

            if (Int32.TryParse(input, out Int32 code) && (code == 1 || code == 0))
                return code;
            else
            {
                Console.WriteLine("Invalid input, choose one from existing options");
                return -1;
            }
        }

        public static void ChooseAvailableActionsAfterLogin()
        {
            throw new NotImplementedException();
        }


    }
}
