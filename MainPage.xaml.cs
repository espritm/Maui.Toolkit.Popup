using CommunityToolkit.Maui.Views;
using Maui.Toolkit.Popup.Controls;

namespace Maui.Toolkit.Popup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		MyPopup myPopup = new MyPopup();

		this.ShowPopupAsync(myPopup);
    }
}


