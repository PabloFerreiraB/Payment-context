using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Test.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        // Passo 1 - Fazer com que todos testes falhar | Assert.Fail();
        // Passo 2 - Fazer com que todos testes retornar sucesso
        // Passo 3 - Refator o código de teste

        [TestMethod]
        public void ShoulReturnErrorWhenCNPJIsInvalid() // Deve retornar erro quando o CNPJ for inválido
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        //[DataTestMethod]
        //[DataRow("76524455000178")]
        //[DataRow("43442116000193")]
        //[DataRow("85403512000151")]
        public void ShoulReturnErrorWhenCNPJIsValid() // Deve retornar sucesso quando o CNPJ for válido
        {
            var doc = new Document("85403512000151", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShoulReturnErrorWhenCPFIsInvalid() // Deve retornar erro quando o CPF for inválido
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShoulReturnErrorWhenCPFIsValid() // Deve retornar sucesso quando o CPF for válido
        {
            var doc = new Document("38804005807", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}
