using System;

namespace Prac5
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("さかな博士「あなたの好きな魚はなんですか？」");

            string fish = Console.ReadLine();
            while(fish != "saba"){
                fish = Console.ReadLine();
            }
            
            Console.WriteLine("さかな博士「やはり魚と言ったらサバに限りますよね。」");
        }
    }
}