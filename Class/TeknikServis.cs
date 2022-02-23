using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Class
{
    class TeknikServis
    {
        private static ICihaz _cihaz;
          
        public TeknikServis(ICihaz cihaz)
        {
            _cihaz = cihaz;
        }

        public void CihazYenileme()
        {
            _cihaz.CihazTemizligi();
            _cihaz.KasaDegisimi();
        }

        public void Onarim()
        {
            _cihaz.ParcaDegisimi();
            _cihaz.CihazTemizligi();
        }
    }
}
