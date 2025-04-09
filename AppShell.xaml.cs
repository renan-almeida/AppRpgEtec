using AppRpgEtec.ViewModels.Armas;
using AppRpgEtec.ViewModels.Personagens;
using AppRpgEtec.Views.Armas;

namespace AppRpgEtec
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("cadPersonagemView", typeof(CadastroPersonagemViewModel));
        }
    }
}
