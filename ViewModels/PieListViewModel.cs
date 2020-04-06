using System;
using System.Collections.Generic;
using Application.Models;

namespace Application.ViewModels
{
	public class PieListViewModel
	{
		public IEnumerable<Pie> Pies { get; set; }
		public string CurrentCategory { get; set; }
	}
}
