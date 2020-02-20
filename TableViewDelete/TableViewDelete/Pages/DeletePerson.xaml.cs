using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TableViewDelete.Classes;

namespace TableViewDelete.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePerson : ContentPage
    {
        //public List<Person> Personss { get; set; } = new List<Person>();
        
        //Person selectedPerson;
        public DeletePerson()
        {
            InitializeComponent();
            personList.ItemsSource = MainPage.Persons;
            /*new List<Person>();
            {
                Persons = new List<Person>;
                new Person {Login="login1", Pass="Samsung", Tel="48000", Email ="fsd"},
                new Person {Login="login2", Pass="Huawei", Tel="35000",Email ="jhdsfjh"},
                new Person {Login="login3", Pass="HTC", Tel="42000", Email = "dsadsa" },
                new Person {Login="login4", Pass="Apple", Tel="52000", Email = "fsdfsdf" }
            };*/
            this.BindingContext = this;
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Person selectedPerson = e.Item as Person;
            if (selectedPerson != null)
            {
                //await DisplayAlert("Вы выбрали сорудника", $"{selectedPerson.Login}", "OK");
                bool result = await DisplayAlert("Подтвердить действие", "Вы хотите удалить сотрудника?", "Да", "Нет");
                if (result)
                {
                    //var resultlist = Persons.ToList();
                    var itemToRemove = MainPage.Persons.Single(r => r.Login == selectedPerson.Login);
                    MainPage.Persons.Remove(itemToRemove);
                    personList.ItemsSource = null;
                    personList.ItemsSource = MainPage.Persons;
                    //Persons.Remove(selectedPerson);
                    //await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Удалить" : "Отменить"), "OK");

                }
                    
            }
                
        }
    }   
}