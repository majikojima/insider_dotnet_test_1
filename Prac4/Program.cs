// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string fish = Console.ReadLine();

// Console.WriteLine($"{fish}ですか");

Console.WriteLine("さかな博士「あなたの好きな魚はなんですか？」");
string fish = Console.ReadLine();

if (fish == "サバ")
{
    Console.WriteLine("さかな博士「結婚してください。」");
} 
else if (fish == "うなぎ") 
{
    Console.WriteLine("うなぎ将軍「よくも俺の仲間を！！」");
}
else
{
    Console.WriteLine(@$"さかな博士「{fish}…ですか。私はサバのほうが美味しいと思いますがね。では。」");
}