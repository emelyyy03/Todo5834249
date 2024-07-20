using Todo5834249.Data;
using Todo5834249.Models;

namespace Todo5834249.View;

[QueryProperty("Item", "Item")]

public partial class TodoItemPage : ContentPage
{
    TodoItem item;

    public TodoItem Item
    {
        get => BindingContext as TodoItem;
        set => BindingContext = value;
    }

    TodoItemDatabase database;

	public TodoItemPage(TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();
        database = todoItemDatabase;
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(item.Name))
        {
            await DisplayAlert("Nombre requierido", "Porfavor ingrese nombre", "OK");
            return;
        }

        await database.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        if (Item.ID == 0)
            return;
        await database.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}