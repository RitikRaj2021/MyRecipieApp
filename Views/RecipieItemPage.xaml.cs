//Giving access to the Models folder
using App1.Models;
//Giving access to the Data folder
using App1.Data;


namespace App1.Views;


    //Helps to improve speed and preformace of the applciaiton when starting
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipieItemPage : ContentPage
    {
        public RecipieItemPage()
        {
            InitializeComponent();
        }

        //When the data is saved the page will navigate backt to the main page
        async void OnSaveBtnClicked(object sender, EventArgs e)
        {
            var recipieItems = (RecipieItem)BindingContext;
            RecipieItemDatabase recipie_Data_base = await RecipieItemDatabase.Instance;
            await recipie_Data_base.SaveItemAsync(recipieItems);
            await Navigation.PopAsync();
        }

        //When the delete button is cliked and the item is deleted the page is navigated back to the mainpage 
        async void OnDeleteBtnClicked(object sender, EventArgs e)
        {
            var recipieItems = (RecipieItem)BindingContext;
            RecipieItemDatabase recipie_Data_base = await RecipieItemDatabase.Instance;
            await recipie_Data_base.DeleteItemAsync(recipieItems);
            await Navigation.PopAsync();
        }
        
        //When the cancel button is Clicked it navigates back to the recepie list 
        async void OnCancelBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
