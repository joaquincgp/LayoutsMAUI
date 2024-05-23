namespace TallerClaseJoaquinChacon;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}
    public void GoToStackLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}