using System;
using Newtonsoft.Json;

namespace MyShop.CommonLib
{
    internal class CommandFactory
    {
        public static String CreateLoginCommandJson(String mail)
        {
            if (String.IsNullOrEmpty(mail))
                throw new ArgumentException(nameof(mail));

            CommandInfo command = new CommandInfo()
            {
                CommandType = ECommandType.Login,
                CustomerInfo = new CustomerInfo()
                {
                    Mail = mail
                }
            };
            return JsonConvert.SerializeObject(command);
        }

        public static String CreateCreateCustomerCommandJson(CustomerInfo customerInfo)
        {
            if (customerInfo == null)
                throw new ArgumentException(nameof(customerInfo));

            CommandInfo command = new CommandInfo()
            {
                CommandType = ECommandType.CreateCustomer,
                CustomerInfo = customerInfo
            };
            return JsonConvert.SerializeObject(command);
        }

    }
}
