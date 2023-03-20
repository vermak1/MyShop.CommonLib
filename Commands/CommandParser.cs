using System;
using Newtonsoft.Json;

namespace MyShop.CommonLib
{
    public class CommandParser
    {
        public static CommandInfo GetCommandFromJson(String jsonString)
        {
            if (String.IsNullOrEmpty(jsonString))
                throw new ArgumentException(nameof(jsonString));

            return JsonConvert.DeserializeObject<CommandInfo>(jsonString);
        }
    }
}
