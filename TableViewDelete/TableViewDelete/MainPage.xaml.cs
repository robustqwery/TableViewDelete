using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TableViewDelete.Classes;
using TableViewDelete.Pages;


namespace TableViewDelete
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int i = 0;
        //List<Person> pers = new List<Person>();
        public static List<Person> Persons { get; set; } = new List<Person>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            string _login = (string)loginCell.Text;
            string _pass = (string)passCell.Text;
            string _tel = (string)telCell.Text;
            string _email = (string)emailCell.Text;
            Person reg = new Person(_login, _pass, _tel, _email);
            Persons.Add(reg);
            DisplayAlert("Вы успешно зарегистрированы!", $"Пользователь № {i + 1} \n Логин: {Persons[i].Login} \n Пароль: {Persons[i].Pass} \n Телефон: {Persons[i].Tel} \n Email: {Persons[i].Email}", "ОK");
            i++;            
        }

        private async void toCommonPageBtn_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new DeletePerson());
            DeletePerson deletePerson = new DeletePerson();
            await Navigation.PushAsync(deletePerson);
            //deletePerson.Personss = Persons;
        }

        
    }
}
