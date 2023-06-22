﻿//“To create a solution to the Fizz Buzz problem, using C#, that is built using Reflection and which
//demonstrates a clean, Test Driven approach using SOLID design principles.”
//Again the problem you are looking to solve is:
//“Given a range of numbers, loop through each number and output the following:
// If the number is divisible by 3 then output the word Fizz instead of the number.
// If the number is divisible by 5 then output the word Buzz instead of the number.
// If the number is divisible by both 3 and 5 then output the word Fizzbuzz instead of the
//number.
// If none of the above conditions are met then output the number.
//For the purpose of this test you should use a range of 1 to 100. Output of the results should be to a
//console window.”

using FizzBuzzService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<FBService>();
    })
    .Build();

var fizzBuzzService = host.Services.GetRequiredService<FBService>();

var output = fizzBuzzService.Run(100);

foreach (var item in output)
{
    Console.WriteLine(item);
}