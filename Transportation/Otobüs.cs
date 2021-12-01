using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Otobüs : YolcuTasit
    {
        public string Model { get; set; }


        public Otobüs(string Model, float Kapasite, float YakitTüketim, int ID) :base(Kapasite,YakitTüketim)
        {
            this.Model = Model;

        }
        public override float GetVerim()
        {
            return 0f;
        }
    }
}
