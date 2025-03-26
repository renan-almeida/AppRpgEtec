using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Personagens;

public partial class CadastroPersonagem : ContentPage
{
	private CadastroPersonagemViewModel cadViewModel;
	public CadastroPersonagem()
	{
        InitializeComponent();
		
		cadViewModel = new CadastroPersonagemViewModel();
		BindingContext = cadViewModel;
		Title = "Novo Personagem";
	}
}