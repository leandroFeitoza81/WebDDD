using Contatos.Domain.Interfaces;
using Contatos.Domain.Models;
using Contatos.Infra.Context;
using Contatos.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos.Application.DI
{
	public class Initializer
	{
		public static void Configure(IServiceCollection services, string connection)
		{
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

			services.AddScoped(typeof(IRepository<Contato>, typeof(ContatoRepository)));
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped(typeof(ContatoService));
			services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
		}
	}
}
