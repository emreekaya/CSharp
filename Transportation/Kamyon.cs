using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Kamyon:YukTasit
    {
        public string Model { get; set; }


        public Kamyon(string Model, float Kapasite, float YakitTüketim) : base(Kapasite, YakitTüketim)
        {
            this.Model = Model;

        }
        public override float GetVerim()
        {
            return 0f;
        }
    }
}
