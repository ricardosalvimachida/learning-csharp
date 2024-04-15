#region Aula1
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// //int Result = Random.Next(); Essa linha da erro pq estamos chamando um método stateful (instancia) e não stateless (estático), ele precisa do new para um nova instancia
// //Uma nova instancia de uma classe recebe o nome de objeto

#endregion


#region Aula 2
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

#endregion

#region Desafio
//https://learn.microsoft.com/pt-pt/training/modules/csharp-call-methods/5-challenge
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue,secondValue);

// Console.WriteLine(largerValue);
#endregion

#region if Else
//Exercicio 1
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15)
//     Console.WriteLine("You win!");
// else
//     Console.WriteLine("You lose!");

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Exercicio 2 - Desafio

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
    Console.WriteLine("Your subscription has expired.");
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
    Console.WriteLine("Your subscription will expire soon. Renew now!");

if (discountPercentage > 0)
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
#endregion
