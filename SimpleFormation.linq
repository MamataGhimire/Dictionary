<Query Kind="Program" />

void Main()
{
	Dictionary<string,string>food=new Dictionary<string,string>();
	food.Add("hari","eats apple");
	food.Add("neha","eats banana");
	food.Add("maisha","eats mango");
	Console.WriteLine(food);
	
	Console.WriteLine("hari"+" "+ food["hari"]);
	Console.WriteLine("neha"+" "+ food["neha"]);
	Console.WriteLine("maisha"+" "+ food["maisha"]);
}

// You can define other methods, fields, classes and namespaces here