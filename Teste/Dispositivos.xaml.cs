using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dispositivos : ContentPage
    {
        public Dispositivos()
        {
            InitializeComponent();
        }

        public void CriaListaDispositivos()
        {
            //var adapter = DependencyService.Resolve<IbluetoothAdapter>();
            //lvBondedDevices.ItemSource = adapter.BondedDevices;
        }
    }
}