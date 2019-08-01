using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Test.Mocks;
using System;

namespace PaymentContext.Test.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Pablo";
            command.LastName = "Ferreira";
            command.Document = "99999999999";
            command.Email = "hello@personalizesoftware.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "1234654987";
            command.PaymentNumber = "123121";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "PERSONALIZE SOFTWARE";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "contato@personalize.com";
            command.Street = "rua tal";
            command.Number = "171";
            command.Neighborhood = "bairro tal";
            command.City = "São José do Rio Preto";
            command.State = "SP";
            command.Country = "Brasil";
            command.ZipCode = "15270000";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
