/*
- Задача 74:
    
    4 друга должны посетить 12 пабов, в котором
     выпить по британской пинте пенного напитка. До каждого бара идти 
    примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга 
    лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3
     литра, это их максимум. Необходимо выяснить, до скольки баров смогут 
    дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет.
     И сколько всего времени будет потрачено на выпивку.
*/

double[] men = new double[4];
double pint = 0.568;
double timeDrunk = 15;
double timeWalk = new Random().Next(15,20);

for (int i = 0; i < men.Length; i++)
{
    men[0] = 1.1 / pint;
    men[1] = 1.5 / pint;
    men[2] = 2.2 / pint;
    men[3] = 3.3 / pint;
    men[i] = Convert.ToInt32(men[i]);
    if (men[i] <= 5)
        Console.WriteLine($"{men[i]} бара, пройдёт {i + 1}й мужик");
    else 
        Console.WriteLine($"{men[i]} баров, пройдёт {i + 1}й мужик");
}

for (int i = 0; i < men.Length; i++)
{
    if (men[i] == 0 && men[i] == 1)
    {
        men[i] *= timeDrunk;
        Console.WriteLine(men[i]);
    }
    else
    {
        men[i] = ((men[i] - 1) * timeWalk) + (men[i] * timeDrunk);
        men[i] = Convert.ToInt32(men[i]);
        Console.WriteLine($"За {men[i]} мин напьёться {i+1}й мужик") ;
    }
}




