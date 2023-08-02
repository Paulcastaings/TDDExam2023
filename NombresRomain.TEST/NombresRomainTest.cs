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

        [Fact]
        public void Test2()
        {
            // ETANT DONNE le chiffre 2
            const uint chiffreArabe = 2;

            // QUAND on le converti en nombres romains
            var nombreRomain = ConvertNombresRomain.Convertir(chiffreArabe);

            // ALORS j'obtiens II
            Assert.Equal("II", nombreRomain);
        }
        [Fact]
        public void Test3()
        {
            // ETANT DONNE le chiffre 3
            const uint chiffreArabe = 3;

            // QUAND on le converti en nombres romains
            var nombreRomain = ConvertNombresRomain.Convertir(chiffreArabe);

            // ALORS j'obtiens III
            Assert.Equal("III", nombreRomain);
        }
        [Fact]
        public void Test4()
        {
            // ETANT DONNE le chiffre 4
            const uint chiffreArabe = 4;

            // QUAND on le converti en nombres romains
            var nombreRomain = ConvertNombresRomain.Convertir(chiffreArabe);

            // ALORS j'obtiens IV
            Assert.Equal("IV", nombreRomain);
        }
    }
}
