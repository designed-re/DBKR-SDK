using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBKR_SDK;
using Newtonsoft.Json;

namespace Sample
{
    public class FilterCategory
    {
        public static async Task Run()
        {
            Console.WriteLine(string.Join(", ", Enum.GetNames(typeof(Category))));
            Console.WriteLine("검색을 위한 카테고리를 입력해주세요.");
            string query = Console.ReadLine();

            Console.WriteLine("검색을 위한 페이지를 입력해주세요. 잘모르신다면 1");
            int page = int.Parse(Console.ReadLine());


            var res = await Api.SearchBotAsync(query, page);
            Console.WriteLine($"{JsonConvert.SerializeObject(res.Data, Formatting.Indented)}");
            Console.WriteLine("아무키를 입력해 메인으로 돌아가세요.");
            Console.ReadLine();
        }
    }
}
