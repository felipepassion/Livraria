using Niu.Nutri.Core.Application.DTO.Validators;

namespace Core.Application.DTO.Tests
{
    using Xunit;
    public class TelefoneValidadorTeste
    {
        [Theory(DisplayName = @"DADO um conjunto de n�meros de telefone em diferentes formatos
                                QUANDO a fun��o de valida-los � chamada
                                ENT�O todos os n�meros devem ser considerados v�lidos")]
        [InlineData("(11) 1234-5678")]
        [InlineData("(11) 91234-5678")]
        [InlineData("11 91234-5678")]
        [InlineData("21969791929")]
        public void ValidarNumbersValidosTeste(string Number)
        {
            var resultado = PhoneNumberValidator.IsValid(Number);
            Assert.True(resultado, $"O n�mero {Number} deveria ser v�lido.");
        }

        [Theory(DisplayName = @"DADO um conjunto de n�meros de telefone em diferentes formatos
                                QUANDO a fun��o de valida-los � chamada
                                ENT�O todos os n�meros devem ser considerados inv�lidos")]
        [InlineData("12345678")] // Faltando DDD
        [InlineData("912345678")] // Faltando DDD
        [InlineData("11 12345-56789")] // D�gito extra
        [InlineData("11 91234-5678a")] // Caractere inv�lido
        [InlineData("(11) 1234")] // Faltando d�gitos
        [InlineData("(11) 912345")] // Faltando d�gitos
        public void ValidarNumbersInvalidosTeste(string Number)
        {
            var resultado = PhoneNumberValidator.IsValid(Number);
            Assert.False(resultado, $"O n�mero {Number} deveria ser inv�lido.");
        }

        [Theory(DisplayName = @"DADO um campo de telefone vazio ou nulo
                                QUANDO a fun��o de validar o n�mero � chamada
                                ENT�O todos os n�meros devem ser considerados inv�lidos")]
        [InlineData(" ")]
        [InlineData(null)]
        public void ValidarNumbersVaziosTeste(string Number)
        {
            var resultado = PhoneNumberValidator.IsValid(Number);
            Assert.False(resultado, "N�meros vazios ou nulos deveriam ser inv�lidos.");
        }

        [Theory(DisplayName = @"DADO um DDD v�lido de um N�mero
                                QUANDO a fun��o de validar o DDD � chamada
                                ENT�O o DDD do n�mero deve ser v�lido")]
        [InlineData("(11) 91234-5678")]
        [InlineData("(21) 91234-5678")]
        [InlineData("(31) 1234-5678")]
        [InlineData("(41) 1234-5678")]
        // Adicione mais DDDs v�lidos aqui
        public void ValidarDDDsValidosTeste(string Number)
        {
            var resultado = PhoneNumberValidator.IsValid(Number);
            Assert.True(resultado, $"O DDD do n�mero {Number} deveria ser v�lido.");
        }

        [Theory(DisplayName = @"DADO um DDD inv�lido de um N�mero
                                QUANDO a fun��o de validar o DDD � chamada
                                ENT�O o DDD do n�mero deve ser inv�lido")]
        [InlineData("(00) 91234-5678")]
        [InlineData("(10) 1234-5678")]
        [InlineData("(20) 1234-5678")]
        [InlineData("(30) 1234-5678")]
        [InlineData("(22) 9 2131-233")]
        // Adicione mais DDDs inv�lidos aqui
        public void ValidarDDDsInvalidosTeste(string Number)
        {
            var resultado = PhoneNumberValidator.IsValid(Number);
            Assert.False(resultado, $"O DDD do n�mero {Number} deveria ser inv�lido.");
        }
    }

}