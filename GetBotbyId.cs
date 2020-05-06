using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;
using Newtonsoft.Json;

namespace Sample
{
    public class GetBotbyId
    {
        public static async Task Run()
        {
            Console.WriteLine("정보를 불러올 봇의 아이디를 입력해주세요.");
            ulong id = ulong.Parse(Console.ReadLine());

            var res = await Api.GetBotByIdAsync(id);
            Console.WriteLine($"{JsonConvert.SerializeObject(res.Data, Formatting.Indented)}");
            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
