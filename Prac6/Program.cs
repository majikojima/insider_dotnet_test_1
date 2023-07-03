// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var r = new Random();
var ans = r.Next(0,101);
// Console.Write(r.Next(0, 101));
while(true){
    Console.Write("好きな文字を入力してね：");
    var res = Console.ReadLine();
    var result = int.TryParse(res, out int num);

    if(result == false){
        continue;
    }

    if(ans == num){
        Console.WriteLine($"正解です ans={ans}");
        return;
    }
    else if(ans < num){
        Console.WriteLine("でっかいです");
    }
    else if(ans > num){
        Console.WriteLine("ちっちゃいです");
    }
}
