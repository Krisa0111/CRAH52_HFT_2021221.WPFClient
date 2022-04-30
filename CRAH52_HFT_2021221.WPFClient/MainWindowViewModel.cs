using CRAH52_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAH52_HFT_2021221.WPFClient
{
    public class MainWindowViewModel
    {
        public RestCollection<Clubs> Clubs { get; set; }
        public MainWindowViewModel()
        {
            Clubs = new RestCollection<Clubs>("http://localhost:30907/", "clubs");
        }
    }
}
