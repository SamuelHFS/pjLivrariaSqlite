using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pjLivrariaSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Apresentacao : ContentPage
    {
        public Apresentacao()
        {
            InitializeComponent();

            //Criar pagina apresentacao
//lb1.Text += "\nCódigo: " + Application.Current.Properties["Codigo"].ToString();
        }
    }
}