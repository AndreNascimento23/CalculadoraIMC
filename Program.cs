Console.Clear();

double kg, altura, imc;

Console.WriteLine("---Calculadora de IMC---");

Console.Write("\nDigite seu peso em kg.....: ");
kg = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite sua altura em metro: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (kg>700 || kg<10 || altura<.30)
{
     Console.WriteLine("Peso ou Altura invalida");
}    
else  
{
    imc = kg / (altura * altura);
    if (imc<17)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Diagnostico: Muito abaixo do peso");
        Console.ResetColor();
    }
    else if (imc<18.5)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Diagnostico: Abaixo do peso");
        Console.ResetColor();
    }
    else if (imc<25)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Diagnostico: Peso normal");
        Console.ResetColor();
    }
    else if (imc<30)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Diagnóstico: Acima do peso");
        Console.ResetColor();
    }
    else if (imc<35)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Diagnóstico: Obesidade |");
        Console.ResetColor();
    }
    else if (imc<40)
    {        
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Diagnóstico: Obesidade ||");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"Seu IMC é {imc:N} kg/m². \n");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Diagnóstico: Obesidade |||");
        Console.ResetColor();
    }
}
