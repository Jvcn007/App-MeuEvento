namespace MeuEvento.Views;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ResultadoEvento());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new StartPage());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}