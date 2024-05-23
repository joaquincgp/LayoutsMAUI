namespace TallerClaseJoaquinChacon;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    public void GoToFlexLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }
}