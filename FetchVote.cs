using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;

namespace Sample
{
    public class FetchVote
    {
        public static async Task Run(string token)
        {
            var bot = new Bot(token);

            Console.WriteLine("투표상태를 확인할 유저의 아이디를 입력해주세요.");
            ulong s = ulong.Parse(Console.ReadLine());

            var res = await bot.FetchVoteAsync(s);
            Console.WriteLine($"Code: {res.Code} Voted: {res.Voted}");
            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
