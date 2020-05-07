using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("DBKR에서 발급받은 토큰을 입력해주세요.");
            var token = Console.ReadLine();
            
            R:
            Console.Clear();
            Console.WriteLine("BOT");
            Console.WriteLine("1.서버수 업데이트");
            Console.WriteLine("2.투표 확인");
            Console.WriteLine("3.현재 봇 정보 불러오기");
            Console.WriteLine("\nAPI");
            Console.WriteLine("4.봇 목록 불러오기");
            Console.WriteLine("5.아이디로 봇 정보 불러오기");
            Console.WriteLine("6.봇 검색하기");
            Console.WriteLine("7.카테고리로 봇 불러오기");

            Console.WriteLine("번호를 입력해주세요.");

            int mode = int.Parse(Console.ReadLine());

            switch (mode)
            {
                case 1:
                    await UpdateServerCount.Run(token);
                    goto R;
                case 2:
                    await FetchVote.Run(token);
                    goto R;
                case 3:
                    await CurrentBot.Run(token);
                    goto R;
                case 4:
                    await GetBots.Run();
                    goto R;
                case 5:
                    await GetBotbyId.Run();
                    goto R;
                case 6:
                    await SearchBot.Run();
                    goto R;
                case 7:
                    await FilterCategory.Run();
                    goto R;

                default:
                    goto R;
            }
        }
    }
}
