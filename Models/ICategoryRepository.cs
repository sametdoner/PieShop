using System;
using System.Collections.Generic;

namespace Application.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> Categories { get; }	
	}
}
