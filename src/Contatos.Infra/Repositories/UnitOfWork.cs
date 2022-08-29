﻿using Contatos.Domain.Interfaces;
using Contatos.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.Infra.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _context;

		public UnitOfWork(AppDbContext context)
		{
			_context = context;
		}

		public async Task Commit()
		{
			await _context.SaveChangesAsync();
		}
	}
}
