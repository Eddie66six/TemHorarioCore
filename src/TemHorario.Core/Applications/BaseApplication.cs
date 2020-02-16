using System;
using System.Collections.Generic;
using System.Text;
using TemHorario.Core.Domain;

namespace TemHorario.Core.Applications
{
    public class BaseApplication : ErrorEvent
    {
        private readonly IUnitOfWork _unitOfWork;
        public BaseApplication(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected bool Commit()
        {
            return _unitOfWork.Commit();
        }
    }
}