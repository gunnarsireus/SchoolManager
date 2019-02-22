using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.Data;
using Api.DAL;
using Api.Models;
using Microsoft.EntityFrameworkCore;


namespace Api.Data
{
	public class CompanyRepository : Repository<Company>, ICompanyRepository
	{
		public CompanyRepository(ApiContext context) : base(context)
		{
		}

		public ApiContext ApiContext => Context as ApiContext;

	}
}
