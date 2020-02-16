using System;

namespace TemHorario.Core.Domain.Client.Entities
{
    public class Client : Entity
    {
        protected Client() { }
        public Client(string name, string lastName, string email)
        {
            RegisterDate = DateTime.UtcNow;
            Name = name;
            LastName = lastName;
            Email = email;
            InicitalValidate();
        }

        protected sealed override void InicitalValidate()
        {
            //TODO validar dados do cliente
            if (!Email.Contains("@"))
            {
                AddError("Email invalido");
            }
        }

        protected bool UpdatePassword(string validationCode)
        {
            if (validationCode != ValidationCode)
            {
                AddError("Codigo incorreto");
                return false;
            }

            ValidationCode = null;
            return true;
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ValidationCode { get; set; }
    }
}
