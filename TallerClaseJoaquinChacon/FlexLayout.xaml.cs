namespace TallerClaseJoaquinChacon;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    public void GoToAbsoluteLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }
}