using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostoGasolina.Model
{
    public class GeraId
    {
        public Guid Id { get; private set; }

        protected GeraId(Guid id)
        {
            Id = id;
        }
    }
}
