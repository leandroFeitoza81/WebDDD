using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos.Domain.Models
{
	public abstract class BaseEntity
	{
		public int Id { get; private set; }
	}
}
