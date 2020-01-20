using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTVandCalculator
{
    public class Television : ITelevision
    {
        public bool Allume { get; set; }
        public int VolumeSonnore { get; set; }
        public Television()
        {
            Allume = false;
            VolumeSonnore = 0;

        }

        

        public void AllumerTV()
        {
            Allume = true;
        }
        public void EteindreTV()
        {
            Allume = false;
        }

        public void AugmenterSon()
        {
            if(VolumeSonnore < 100)
            {
                VolumeSonnore ++;
            }

        }
        public void BaisserSon()
        {
            if (VolumeSonnore > 0)
            {
                VolumeSonnore --;
            }
        }
    }
}
