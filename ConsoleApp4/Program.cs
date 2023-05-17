//Составить программу, определяющую общее число удалений и
//общее штрафное время каждой из хоккейных команд во время игры
//(игроки удаляются на 2, 5 или 10 мин). Окончание игры моделировать вводом числа 0

int deletionsammount = 0;//кол-во удалений
int penaltytime = 0;//штрафное время
int n = 1;
while (n!=0)
{
    n =int.Parse(Console.ReadLine());//ввод штрафного времени, пока не будет введен 0
    deletionsammount += 1;
    penaltytime += n;
}
deletionsammount -= 1;
Console.WriteLine("Общее число удалений: "+ deletionsammount);
Console.WriteLine("Общее штрафное время: "+ penaltytime);