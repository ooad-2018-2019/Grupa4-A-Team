﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_lections.Models
{
    public class Kandidat : KandidatDekorater, IUcesnik
    {
        private int brojGlasova;

        //veze sa ostalim tabelama, 1:1 veza sa Profil,  1:m veza sa glasackim listicem, m:n veza sa BirackoMjesto
        public int ProfilId { get; set; }
        public virtual Profil Profil { get; set; }

        public int GlasackiListicId { get; set; }
        public virtual GlasackiListic GlasackiListic { get; set; }


        public virtual ICollection<BirackoMjestoKandidat> BirackoMjestoKandidati { get; set; }

        public void DodajGlas()
        {
            throw new NotImplementedException();
        }

        public void PrijaviIzbore(int idIzbora, int idListica)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}