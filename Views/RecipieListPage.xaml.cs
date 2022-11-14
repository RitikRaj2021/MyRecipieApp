using App1.Data;
using App1.Models;
using System.Text;
using System.Threading.Tasks;

namespace App1.Views;



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipieListPage : ContentPage
    {
        public RecipieListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            RecipieItemDatabase database = await RecipieItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipieItemPage
            {
                BindingContext = new RecipieItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new RecipieItemPage
                {
                    BindingContext = e.SelectedItem as RecipieItem
                });
            }
        }
    }
