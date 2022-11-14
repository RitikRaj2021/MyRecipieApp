//Access to the views folder
using App1.Views;

namespace App1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //Load up the RecipieListPage as the first page when the application starts
        MainPage = new NavigationPage(new RecipieListPage());
     
    }
}
