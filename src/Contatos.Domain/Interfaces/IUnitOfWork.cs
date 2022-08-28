using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
	public interface IUnitOfWork
	{
		Task Commit();
	}
}
