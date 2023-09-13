using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_U4_W3_D3
{
    public class Pizza
    {
        private string Nome { get; set; }
        private double Prezzo { get; set; }
        public double Totale { get; set; }
        private List<Ingrediente> IngredientiList { get; set; } = new List<Ingrediente>();

        public Pizza(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
            Totale = prezzo;
        }

        public void addIngrediente(Ingrediente ingrediente)
        {
            Totale += ingrediente.Prezzo;
            IngredientiList.Add(ingrediente);
        }

        public string stampaPizza()
        {
            string pizzaoutput = "";
            pizzaoutput += $"<p> Pizza {Nome}, pagata {Prezzo}€ </p> <ul>";
            if(IngredientiList.Count > 0)
            {
                foreach (Ingrediente ingrediente in IngredientiList)
                    pizzaoutput += $"<li> Con aggiunta di {ingrediente.Nome}, pagato {ingrediente.Prezzo}€ </li>";
                pizzaoutput += $"</ul> <p>Totale costo pizza: {Totale}€ </p> <br>";
            }
            return pizzaoutput;
        }

    }

    public class Ingrediente
    {
        public string Nome { get; set; }
        public double Prezzo { get; set; } 

        public Ingrediente(string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}