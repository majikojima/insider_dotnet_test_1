using System;

namespace Prac8
{
    enum Command
    {
        Gu = 0,
        Choki = 1,
        Pa = 2
    }

    enum Result
    {
        Win,
        Lose,
        Draw
    }

    class Program
    {
        static Result Janken(Command me, Command enemy)
        {
            if (me == enemy) return Result.Draw;

            if ((me == Command.Gu && enemy == Command.Choki)
                || (me == Command.Choki && enemy == Command.Pa)
                || (me == Command.Pa && enemy == Command.Gu))
            {
                return Result.Win;
            }

            return Result.Lose;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("じゃんけんしようぜ！");

            const int MAX_LIFE = 5;

            var life = MAX_LIFE;
            var enemysLife = MAX_LIFE;

            while (life != 0 && enemysLife != 0)
            {
                // 相手の手
                var random = new Random();
                var enemy = (Command)random.Next(0, 3);

                // 自分の手
                var parseResult = Enum.TryParse(Console.ReadLine(), out Command me);
                if (!parseResult)
                {
                    Console.WriteLine("そんな手はねぇ！");
                    continue;
                }

                var result = Janken(me, enemy);
                switch (result)
                {
                    case Result.Win:
                        Console.WriteLine("ぐはあぁ！！！");
                        enemysLife--;
                        break;
                    case Result.Lose:
                        Console.WriteLine("オラアアア！！！");
                        life--;
                        break;
                    default:
                        Console.WriteLine("あいこでしょ？");
                        break;
                }
                Console.WriteLine($"[自分の体力：{life} / {MAX_LIFE}] [敵のライフ：{enemysLife} / {MAX_LIFE}]");
            }

            if (life == 0) Console.WriteLine("てめぇの負けだ。でなおしてまいれ。");
            if (enemysLife == 0) Console.WriteLine("俺の負けだよ…死にます。");
        }
    }
}
