using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    public abstract class YukTasit : IYük
    {
        public float Kapasite { get; set; }
        public float YakitTüketim { get; set; }

        public YukTasit(float Kapasite, float YakitTüketim)
        {
             this.Kapasite = Kapasite;
            this.YakitTüketim = YakitTüketim;
        }

        public virtual float GetVerim()
        {
            return Kapasite / YakitTüketim;
        }
    }
}
