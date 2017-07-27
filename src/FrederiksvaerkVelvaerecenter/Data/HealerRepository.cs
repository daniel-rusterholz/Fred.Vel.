using FrederiksvaerkVelvaerecenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrederiksvaerkVelvaerecenter.Data
{
    public class HealerRepository
    {
        private static Healer[] _healers = new Healer[]
        {
            new Healer()
            {
                Id = 1,
                Name = "Lise Rusterholz",
                Treatments = new string[]
                {
                    "Reference 1",
                    "Reference 2",
                    "Reference 3",
                    "Reference 4",
                },
                Phone = "20722748",
                Email = "lise@biopaten.dk",
                Web = "www.biopaten.dk"
            },
            new Healer()
            {
                Id = 2,
                Name = "Søren Kinnerup",
                Treatments = new string[]
                {
                    "Reference 1",
                    "Reference 2",
                    "Reference 3",
                    "Reference 4",
                },
                Phone = "20722748",
                Email = "lise@biopaten.dk",
                Web = "www.biopaten.dk"
            },
            new Healer()
            {
                Id = 3,
                Name = "Kaja Sandfuss",
                Treatments = new string[]
                {
                    "Reference 1",
                    "Reference 2",
                    "Reference 3",
                    "Reference 4",
                },
                Phone = "20722748",
                Email = "lise@biopaten.dk",
                Web = "www.biopaten.dk"
            },
            new Healer()
            {
                Id = 2,
                Name = "Body Hour",
                Treatments = new string[]
                {
                    "Reference 1",
                    "Reference 2",
                    "Reference 3",
                    "Reference 4",
                },
                Phone = "20722748",
                Email = "lise@biopaten.dk",
                Web = "www.biopaten.dk"
            }
        };
        public Healer[] GetHealers()
        {
            return _healers;
        }
    }
}