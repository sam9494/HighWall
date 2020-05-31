using System;
using System.Collections.Generic;
using System.Text;
using HighWall.Core.Model;

namespace HighWall.Core.Service
{
    public interface ICapitalismService
    {
        HomeViewModel GetHomeViewModel();
    }

    public class CapitalismService : ICapitalismService
    {
        private const string Slogan = "Free Market";
        private const string Capitalist = "David";


        public HomeViewModel GetHomeViewModel()
        {
            return new HomeViewModel()
            {
                Slogan = Slogan,
                Capitalist = Capitalist 
            };
        }

    }
}
