﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    class NaseljenoMesto : IModelBase
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string PttOznaka { get; set; }
        public Drzava drzava { get; set; }
        private ICollection<AnalitikaIzvoda> _izvodi;
        internal ICollection<AnalitikaIzvoda> Izvodi
        {
            get
            {
                return _izvodi;
            }

            set
            {
                _izvodi = value;
            }
        }

       
    }
}