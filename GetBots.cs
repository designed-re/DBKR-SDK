using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;

namespace Sample
{
    public class GetBots
    {
        public static async Task Run()
        {
            Console.WriteLine("불러올 페이지를 입력해주세요. 기본: 1");
            int a = int.Parse(Console.ReadLine());
            var res = await Api.GetBotsAsync(a);
            
            Console.WriteLine($"Code: {res.Code} TotalPage: {res.TotalPage}\n");

            foreach (var b in res.Bots)
            {
                Console.WriteLine($"Name: {b.Name} Intro: {b.Intro} | Category: {string.Join(", ", b.Category)}");
            }

            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
