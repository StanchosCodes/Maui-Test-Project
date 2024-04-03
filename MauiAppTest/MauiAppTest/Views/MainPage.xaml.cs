using MauiAppTest.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace MauiAppTest.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        SwapiModel swapiModel;

        public MainPage()
        {
            InitializeComponent();
            this.swapiModel = new SwapiModel();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnRequestClicked(object sender, EventArgs e)
        {
            //string desiredUrl = await DisplayPromptAsync("Type the url you want to send GET request to. If you don`t you will see Luke Skywalker!", "Url");

            string baseUrl = "https://swapi.dev/api/people/1";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                //if (!String.IsNullOrEmpty(desiredUrl))
                //{
                //    baseUrl = desiredUrl;
                //}

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, baseUrl);
                HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var swapiModel = await responseMessage.Content.ReadFromJsonAsync<Models.SwapiModel>();
                    swapiModel!.Species = swapiModel.Species.Append("https://swapi.dev/api/species/1/").ToArray();

                    BindingContext = swapiModel;

                    await DisplayAlert("Hello", $"Your request resulted in Status Code: {responseMessage.StatusCode}", "Ok");
                }
                else
                {
                    await DisplayAlert("Hello", $"Your request resulted in Status Code: {responseMessage.StatusCode}", "Ok");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

}
