using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;

namespace Sample
{
    public class UpdateServerCount
    {
        public static async Task Run(string token)
        {
            var bot = new Bot(token);

            Console.WriteLine("새로 업데이트할 서버수를 입력해주세요");
            int s = int.Parse(Console.ReadLine());

            var res = await bot.UpdateServerCountAsync(s);

            Console.WriteLine($"Code: {res.Code} Messasge: {res.Message}");
            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
