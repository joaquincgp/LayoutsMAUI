namespace TallerClaseJoaquinChacon;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    public void GoToGridLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayout());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}