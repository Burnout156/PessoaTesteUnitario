using ConsoleTeste;

namespace TesteUnitarioIdade
{
    [TestClass]
    public class PessoaTeste
    {

        [TestMethod]
        public void TesteIdade()
        {
            Random random = new Random();
            Pessoa pessoa = new Pessoa(random.Next(-5, 120));
            pessoa.VerificarIdade();
            Assert.IsTrue(pessoa.SaberIdade > -1 && pessoa.SaberIdade < 110);
        }
    }
}