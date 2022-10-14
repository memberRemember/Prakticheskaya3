
// ФЛ СТУДИО
Console.WriteLine("         -=-=-=-=-=-=-=-=- УПРАВЛЕНИЕ -=-=-=-=-=-=-=-");
Console.WriteLine("         =            2  3     5  6  7              =");
Console.WriteLine("         =           Q  W  E  R  T  Y  U            =");
Console.WriteLine("         = Переключение между октавами: F1, F2, F3  =");
Console.WriteLine("         -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("                                                     ");
Console.WriteLine("         Выберите октаву!");

int[] ThirdOktava = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
int[] FourthOktava = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
int[] FiftOktava = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
int[] Buffer = new int[12];
bool NegrPashet = true;

while (NegrPashet == true)
{
    ConsoleKeyInfo klavisha = Console.ReadKey();
    Console.Clear();
    ChooseOktava(klavisha, Buffer, ThirdOktava, FourthOktava, FiftOktava);
}

// -=-=-= тут методы =-=-=-

// СМЕНА ОКТАВЫ

void ChooseOktava(ConsoleKeyInfo klavisha, int[] Buff, int[] ThirdOktava, int[] FourthOktava, int[] FiftOktava)
{
    bool NegrPashet = true;

    if (klavisha.Key == ConsoleKey.F1)
    {
        Buffer = ThirdOktava;
        Console.WriteLine("-=-=-=-=- Вы выбрали 3 октаву -=-=-=-=-");
    }

    else if (klavisha.Key == ConsoleKey.F2)
    {
        Buffer = FourthOktava;
        Console.WriteLine("-=-=-=-=- Вы выбрали 4 октаву -=-=-=-=-");
    }

    else if (klavisha.Key == ConsoleKey.F3)
    {
        Buffer = FiftOktava;
        Console.WriteLine("-=-=-=-=- Вы выбрали 5 октаву -=-=-=-=-");
    }
    else if (klavisha.Key == ConsoleKey.Escape)
    {
        NegrPashet = false;
    }
    else
    {
        DJeban(klavisha, Buffer);
    }
}

// ПРОИГРЫВАНИЕ ЗВУКОВ
void DJeban(ConsoleKeyInfo klavisha, int[] Buffer)
{
    if (klavisha.Key == ConsoleKey.Q)
    {
        Console.Beep(Buffer[0], 500);
    }

    else if (klavisha.Key == ConsoleKey.D2)
    {
        Console.Beep(Buffer[1], 500);
    }

    else if (klavisha.Key == ConsoleKey.W)
    {
        Console.Beep(Buffer[2], 500);
    }

    else if (klavisha.Key == ConsoleKey.D3)
    {
        Console.Beep(Buffer[3], 500);
    }

    else if (klavisha.Key == ConsoleKey.E)
    {
        Console.Beep(Buffer[4], 500);
    }

    else if (klavisha.Key == ConsoleKey.R)
    {
        Console.Beep(Buffer[5], 500);
    }

    else if (klavisha.Key == ConsoleKey.D5)
    {
        Console.Beep(Buffer[6], 500);
    }

    else if (klavisha.Key == ConsoleKey.T)
    {
        Console.Beep(Buffer[7], 500);
    }

    else if (klavisha.Key == ConsoleKey.D6)
    {
        Console.Beep(Buffer[8], 500);
    }

    else if (klavisha.Key == ConsoleKey.Y)
    {
        Console.Beep(Buffer[9], 500);
    }

    else if (klavisha.Key == ConsoleKey.D7)
    {
        Console.Beep(Buffer[10], 500);
    }

    else if (klavisha.Key == ConsoleKey.U)
    {
        Console.Beep(Buffer[11], 500);
    }

    else
    {
        Console.WriteLine("Промазал!");
    }
}