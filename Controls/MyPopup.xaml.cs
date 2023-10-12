using CommunityToolkit.Maui.Views;

namespace Maui.Toolkit.Popup.Controls;

public partial class MyPopup : CommunityToolkit.Maui.Views.Popup
{
	public MyPopup()
	{
		InitializeComponent();

		TitleLabel.Text = "Hi community";
		DescriptionLabel.Text = "Enjoy your development <3";
		AcceptButton.Text = "Go";

		AcceptButton.Clicked += (s, a) =>
		{
			Close();
		};
    }
}
