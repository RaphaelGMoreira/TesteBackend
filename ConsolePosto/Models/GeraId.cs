using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePosto.Models
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
