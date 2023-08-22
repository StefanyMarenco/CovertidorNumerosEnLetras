
string[] unidades =
{
   "",
    "Uno",
    "Dos",
    "Tres",
    "Cuatro",
    "Cinco",
    "Seis",
    "Siete",
    "Ocho",
    "Nueve",
};
String[] decenas =
{
    "Diez",
    "Veinte",
    "Treinta",
    "Cuarenta",
    "Cincuenta",
    "Sesenta",
    "Setenta",
    "Ochenta",
    "Noventa",

};
string[] especiales =
{
"",
"Once",
"Doce",
"Trece",
"Catorce",
"Quince",
"Dieciseis",
"Diecisiete",
"Dieciocho",
"Diecinueve",
};
String[] centenas =
{
    "",
    "Ciento",
    "Doscientos",
    "Trescientos",
    "Cuatrocientos",
    "Quinientos",
    "Seisciento",
    "Setecientos",
    "Ochocientos",
    "Novecientos",

};
int numero;
    Console.Write("Ingrese un numero entre 0y 9999: ");
while (true)
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero >= 0 && numero <= 9999)
        {
            string numeroEnLetras =
                ConvertirNumeroEnLetras(numero);
            Console.WriteLine($"El numero {numero} en letras es: {numeroEnLetras}");
        }
        else
    {
        Console.WriteLine("El numero ingresado esta fuera del rango valido");
    }
    }
    else
    {
        Console.WriteLine("Entrada no valida." +
            "Por favor ingrese un numero valido");
    }
   
    

string ConvertirNumeroEnLetras(int numero)
    
{
    if (numero == 0)
        return "Cero";

    string numeroEnLetras = "";
    // Procesar las unidades de millar

    int unidadesDeMillar = numero / 1000;
    if (unidadesDeMillar > 0)
    {
        if (unidadesDeMillar == 1)
            numeroEnLetras = "Mil";
        else
            numeroEnLetras += unidades[unidadesDeMillar]
            + "Mil";
        numero %= 1000;
    }
  

// procesar las centnas
int parteCentena = numero / 100;
if (parteCentena > 0)
{
    numeroEnLetras += centenas[parteCentena] + " ";
        numero %= 100;
}


    //procesar las decenas y unidades
    
    if (numero >= 11 && numero <= 19)
    {
        numeroEnLetras += especiales[numero - 10];
    }
    else
    {
        int decena = numero / 10;
        if (decena > 0)
        {
            numeroEnLetras += decenas[decena];
            if (numero % 10 > 0)
            {
                numeroEnLetras += "Y" + unidades[numero % 10];
            }
        }
        else if (numero % 10 > 0)
        {
            numeroEnLetras += unidades[numero % 10];
        }
    }
    {
       return numeroEnLetras;
    }
}