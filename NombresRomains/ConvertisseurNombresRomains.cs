public class ConvertisseurNombresRomains
{
    public static string Convertir(int chiffre)
    {
        if (chiffre < 1 || chiffre > 50)
        {
            throw new ArgumentOutOfRangeException(nameof(chiffre));
        }

        if (chiffre == 1) return "I";
        if (chiffre == 4) return "IV";
        if (chiffre == 5) return "V";
        if (chiffre == 9) return "IX";
        if (chiffre == 10) return "X";
        if (chiffre == 40) return "XL";
        if (chiffre == 50) return "L";

        if (chiffre >= 10)
        {
            return "X" + Convertir(chiffre - 10);
        }
        else
        {
            return new string('I', chiffre);
        }
    }
}
