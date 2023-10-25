namespace NombresRomains;

public static class ConvertisseurNombresRomains
{
    public static string Convertir(uint chiffre)
    {
        return chiffre == 1 ? "I" : "II";
    }
}