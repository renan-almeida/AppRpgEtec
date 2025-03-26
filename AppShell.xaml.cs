using AppRpgEtec.ViewModels.Personagens;

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
