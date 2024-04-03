using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest.Models
{
    public class SwapiModel
    {
        private double height;
        private double mass;
        private DateTime created;
        private DateTime edited;

        public string Name { get; set; }

        public double Height
        { 
            get
            {
                return this.height;
            } 
            set 
            {
                this.height = Convert.ToDouble(value);
            } 
        }

        public double Mass
        {
            get
            {
                return this.mass;
            }
            set
            {
                this.mass = Convert.ToDouble(value);
            }
        }

        public string Hair_Color { get; set; }

        public string Skin_Color { get; set; }

        public string Eye_Color { get; set; }

        public string Birth_Year { get; set; }

        public string Gender { get; set; }

        public string HomeWorld { get; set; }

        public string[] Films { get; set; }

        public string[] Species { get; set;}

        public string[] Vehicles { get; set;}

        public string[] Starships { get; set; }

        public DateTime Created
        {
            get
            {
                return this.created;
            }
            set
            {
                this.created = Convert.ToDateTime(value);
            }
        }

        public DateTime Edited
        {
            get
            {
                return this.edited;
            }
            set
            {
                this.edited = Convert.ToDateTime(value);
            }
        }

        public string Url { get; set; }


        //       "name": "Luke Skywalker",
        //"height": "172",
        //"mass": "77",
        //"hair_color": "blond",
        //"skin_color": "fair",
        //"eye_color": "blue",
        //"birth_year": "19BBY",
        //"gender": "male",
        //"homeworld": "https://swapi.dev/api/planets/1/",
        //"films": [
        //	"https://swapi.dev/api/films/2/",
        //	"https://swapi.dev/api/films/6/",
        //	"https://swapi.dev/api/films/3/",
        //	"https://swapi.dev/api/films/1/",
        //	"https://swapi.dev/api/films/7/"
        //],
        //"species": [
        //	"https://swapi.dev/api/species/1/"
        //],
        //"vehicles": [
        //	"https://swapi.dev/api/vehicles/14/",
        //	"https://swapi.dev/api/vehicles/30/"
        //],
        //"starships": [
        //	"https://swapi.dev/api/starships/12/",
        //	"https://swapi.dev/api/starships/22/"
        //],
        //"created": "2014-12-09T13:50:51.644000Z",
        //"edited": "2014-12-20T21:17:56.891000Z",
        //"url": "https://swapi.dev/api/people/1/"
    }
}
