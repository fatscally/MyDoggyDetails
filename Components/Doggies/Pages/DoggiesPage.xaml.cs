using MyDoggyDetails.ViewModels;

namespace MyDoggyDetails.Pages;

public partial class DoggiesPage : ContentPage
{

    DoggiesViewmodel vm;
	public DoggiesPage(DoggiesViewmodel vm)
	{
		InitializeComponent();

        this.vm = vm;
        BindingContext = this.vm;

        

       // GetDogsAge();
    }


    //private void GetDogsAge()
    //{

    //    AgeCalculator dogCalc = new(DogDob.Date);

    //    lblDogsAge.Text = dogCalc.FormattedAge();
    //    lblDogsAgeInDays.Text = "(" + dogCalc.TotalDogDays.ToString() + " days)";

    //}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        // GetDogsAge();
    }

    private void DogButton_Clicked(object sender, EventArgs e)
    {
        //vm.SelectedDoggy = vm.Doggies[0];
        //GetDogsAge();
    }

    private void DogDob_DateSelected(object sender, DateChangedEventArgs e)
    {
        //GetDogsAge();
    }





}