using Xunit;
using NombresRomains; // Assurez-vous d'avoir le bon espace de noms pour ConvertisseurNombresRomains

namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(22, "XXII")]
        [InlineData(23, "XXIII")]
        [InlineData(24, "XXIV")]
        [InlineData(25, "XXV")]
        [InlineData(26, "XXVI")]
        [InlineData(27, "XXVII")]
        [InlineData(28, "XXVIII")]
        [InlineData(29, "XXIX")]
        [InlineData(30, "XXX")]
        [InlineData(31, "XXXI")]
        [InlineData(32, "XXXII")]
        [InlineData(33, "XXXIII")]
        [InlineData(34, "XXXIV")]
        [InlineData(35, "XXXV")]
        [InlineData(36, "XXXVI")]
        [InlineData(37, "XXXVII")]
        [InlineData(38, "XXXVIII")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(42, "XLII")]
        [InlineData(43, "XLIII")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(46, "XLVI")]
        [InlineData(47, "XLVII")]
        [InlineData(48, "XLVIII")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        public void TestConversions(uint chiffre, string attendu)
        {
            // ETANT DONNE le chiffre <chiffre>
            // QUAND on le convertit en nombres romains
            var nombreRomain = ConvertisseurNombresRomains.Convertir((int)chiffre);

            // ALORS on obtient le résultat attendu
            Assert.Equal(attendu, nombreRomain);
        }
    }
}
