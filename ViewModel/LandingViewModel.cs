using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using House.Model;
using House.Service;
using House.View;

namespace House.ViewModel
{
    public class LandingViewModel:BaseViewModel
    {
        public List<string> Sections => new List<string> { "Tendance", "Populaire", "Acheter", "Louer" };

        public List<Property> Properties => PropertyService.AllProperties;

        public Property? SelectedProperty { get; set; }

      
         public ICommand PropertySelected => new Command(obj => {
            if(SelectedProperty != null)
             
                 Application.Current?.MainPage?.Navigation.PushAsync(new DetailsPage(SelectedProperty));
             
            SelectedProperty = null;
             
           
        });
         
         
    }
}
