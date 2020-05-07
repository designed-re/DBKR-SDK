using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;
using Newtonsoft.Json;

namespace Sample
{
    public class CurrentBot
    {
        public static async Task Run(string token)
        {
            var res = new Bot(token).CurrentBot;
            Console.WriteLine($"{JsonConvert.SerializeObject(res, Formatting.Indented)}");
            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
