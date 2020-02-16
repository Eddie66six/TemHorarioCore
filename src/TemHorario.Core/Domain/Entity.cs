using System;

namespace TemHorario.Core.Domain
{
    public abstract class Entity : ErrorEvent
    {
        protected  abstract void InicitalValidate();
        public DateTime RegisterDate { get; set; }
    }
}
