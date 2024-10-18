using System.ComponentModel.Design;

Console.WriteLine("Выбирете систему исчисления из кторой хотите преобразовать число в деситичную (от 2 до 10)"); 
    int q1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Выбирете систему исчисления в которую хотите преобразовать число (от 2 до 10)");
int q2 = Convert.ToInt32(Console.ReadLine());

if (q1 < 2 || q1 > 10 || q2 < 2 || q2 > 10) 
{
    Console.WriteLine("Cистема исчисления должно быть в пределах от 2 до 10");
    return;
}

Console.WriteLine($"Введите число которое хотите преобразовать из системы исчисления {q1} в десятичную и из нее в {q2}");
bool oi = true;
string x = Console.ReadLine();
int y = Convert.ToInt32(x);
int b = Convert.ToInt32(x);
while (b>0) 
{
    y = b % 10;
    b = b / 10;
    if (y > q1) 
    {
        Console.WriteLine($"Число {x} должно быть в системе исчисления {q1}");
        oi = false;
        break;
    }
}
if (oi)
{int value = ConvertToDec(x, q1);

string result = ConvertFromDec(value, q2);

Console.WriteLine($"Число {x} в СС {q1} ровна: {value} что в СС {q2} ровна: {result}");
static int ConvertToDec(string x, int baseFrom)
{
    int val = 0;
    for (int i = 0; i < x.Length; i++)
    {
        val *= baseFrom;
        val += (x[i] - '0');
    }
    return val;
}

static string ConvertFromDec(int value, int baseTo)
    {
        if (value == 0) return "0";
        string result = "";
        while (value > 0)
        {
            int remainder = value % baseTo;
            result = remainder.ToString() + result;
            value /= baseTo;
        }
        return result;
    }
}





