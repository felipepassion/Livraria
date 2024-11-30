using Niu.Nutri.Core.Application.Validators;

namespace Niu.Nutri.Users.Domain.Tests
{
    public class UsersTest
    {
        [Theory(DisplayName = @"DADO um número de CPF
                                QUANDO a função de validar o CPF é chamada
                                ENTÃO o resultado deve ser verdadeiro para CPFs válidos e falso para CPFs inválidos")]
        [InlineData("529.982.247-25", true)] // CPF válido
        [InlineData("111.111.111-11", false)] // CPF com números repetidos
        [InlineData("123.456.789-01", false)] // CPF inválido 
        [InlineData("529A982B24C", false)] // CPF inválido 
        [InlineData(null, false)] // Nulo 
        [InlineData("", false)] // Nulo
        [InlineData(" ", false)] // Nulo 
        [InlineData("529.982.247", false)] // Digitos faltantes
        [InlineData("529.982.247-251", false)] // Digitos a mais
        public void TestCpf(string cpf, bool esperado)
        {
            Assert.Equal(esperado, CpfValidator.ValidCPF(cpf));
        }
    }
}
