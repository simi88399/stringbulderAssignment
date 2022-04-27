using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "[{\"TaxTypeName\":\"QST\",\"Percentage\":4.000},{\"TaxTypeName\":\"MSTATTax\",\"Percentage\":5.000}]";



            var details = JsonConvert.DeserializeObject<dynamic>(str);
            var builder = new StringBuilder();
            foreach (var item in details)
            {
                
                builder.Append(item.TaxTypeName);
                builder.Append(":");
                builder.Append(item.Percentage);
                builder.Append("%");
                builder.Append("+");
          };
            var result = builder.Remove(18, 1);
            Console.WriteLine("Total GST: {0}", result);


            Console.ReadLine();
        }
    }
    }

