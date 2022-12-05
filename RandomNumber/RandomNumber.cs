Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 10; i++)
{
    int myRandumNum = rnd.Next(0, 11); //geneeritakse väärtusi 0 - 10
    randomSum = randomSum+ myRandumNum;
    Console.WriteLine($"My random number is: {myRandumNum}");
}

Console.WriteLine($"Random sum total is: {randomSum}");