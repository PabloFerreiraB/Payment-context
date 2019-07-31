using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;
using System.Text.RegularExpressions;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(ValidateCPForCNPJ(number), "Document.Number", "Documento inválido")
                );
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }


        public bool ValidateCPForCNPJ(string document)
        {
            return Regex.IsMatch(document, @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
        }
    }
}
