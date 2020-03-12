using System.Collections.Generic;

namespace Cities
{
    public class Row
    {
        public string Country {get;set;}
        public string State {get;set;}
        public string Name {get;set;}
        public int Population {get;set;}
    }

    public class Country
    {
        public Country() {}
        public Country(string name, List<State> states)
        {
            Name = name;
            States = states;
        }
        public string Name {get;set;}
        public List<State> States {get;set;} = new List<State>();
    }

    public class State
    {
        public State() {}
        public State(string name, List<City> cities)
        {
            Name = name;
            Cities = cities;
        }
        public string Name {get;set;}
        public List<City> Cities {get;set;} = new List<City>();
    }

    public class City
    {
        public City() {}
        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }
        public string Name {get;set;}
        public int Population {get;set;}
    }
}