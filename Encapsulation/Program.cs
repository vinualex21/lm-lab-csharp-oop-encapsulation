﻿// See https://aka.ms/new-console-template for more information
using Encapsulation.Models;

const string MY_ACCOUNT_NUMBER = "ABCDEFG123";

//DODGY BANK ACCOUNT
Console.WriteLine("--- DODGY BANK ACCOUNT ---\n");
Console.WriteLine("Mmm...I spot a dodgy bank account! Let's make one!");
DodgyBankAccount myDodgyBankAccount = new(MY_ACCOUNT_NUMBER);

Console.WriteLine("What is my current balance?");
myDodgyBankAccount.GetAccountBalanceDetails();

Console.WriteLine("Let's deposit an amount of 30");
myDodgyBankAccount.DepositAmount(30);
myDodgyBankAccount.GetAccountBalanceDetails();

Console.WriteLine("Wow! Looks like we get a reward of 50 when we deposit an amount");

Console.WriteLine("Let's be naughty and add rewards without depositing!");
myDodgyBankAccount.AddReward();
myDodgyBankAccount.AddReward();
myDodgyBankAccount.AddReward();
myDodgyBankAccount.GetAccountBalanceDetails();

Console.WriteLine("Wow! We're rich!");

Console.WriteLine("Let's make a lot of money right now! Let's change the account balance directly!");
myDodgyBankAccount.AccountBalance = 1000000;
myDodgyBankAccount.GetAccountBalanceDetails();
Console.WriteLine("😻 Weeeeee!!!!\n");

//SECURE BANK ACCOUNT
Console.WriteLine("--- SECURE BANK ACCOUNT ---\n");
Console.WriteLine("Mmm...let's make a secure bank account!");
SecureBankAccount mySecureBankAccount = new(MY_ACCOUNT_NUMBER);

Console.WriteLine("What is my current balance?");
mySecureBankAccount.DisplayAccountBalanceDetails();

Console.WriteLine("Let's deposit an amount of 30");
mySecureBankAccount.DepositAmount(30);
mySecureBankAccount.DisplayAccountBalanceDetails();

Console.WriteLine("Wow! Looks like we get a reward of 50 when we deposit an amount");

Console.WriteLine("Let's be naughty and add rewards without depositing!");
Console.WriteLine("Oh no :( It looks like we can't do this - it's too secure!");
//mySecureBankAccount.AddReward();
//mySecureBankAccount.AddReward();
//mySecureBankAccount.AddReward();
mySecureBankAccount.DisplayAccountBalanceDetails();

Console.WriteLine("Let's make a lot of money right now! Let's change the account balance directly!");
Console.WriteLine("Oh no :( It looks like we can't do this - it's too secure!");
//mySecureBankAccount._accountBalance = 1000000;
mySecureBankAccount.DisplayAccountBalanceDetails();
Console.WriteLine("😹 Well I guess that's secure!");

//WEATHER REPORT
WeatherReporter weatherReporter = new("London", 18);
weatherReporter.PrintFahrenheitWeatherReport();

weatherReporter = new("California", 31);
weatherReporter.PrintCelciusWeatherReport();