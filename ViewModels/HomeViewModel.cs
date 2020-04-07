using System;
using System.Collections.Generic;
using Application.Models;

namespace Application.ViewModels
{
	public class HomeViewModel
	{
		public string Title { get; set; }
		public List<Pie> Pies { get; set; }
	}
}
