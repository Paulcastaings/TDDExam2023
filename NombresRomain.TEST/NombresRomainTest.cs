namespace NombresRomain.TEST
{
    public class NombresRomainTest
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE le chiffre 1
            const uint chiffreArabe = 1;

            // QUAND on le converti en nombres romains
            var nombreRomain = ConvertNombresRomain.Convertir(chiffreArabe);

            // ALORS j'obtiens I
            Assert.Equal("I", nombreRomain);
        }
    }
}