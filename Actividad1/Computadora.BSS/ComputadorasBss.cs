using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.DAL;
using Computadora.MODELOS;

namespace Computadora.BSS
{
    public class ComputadorasBss
    {
        ComputadorasDal dal = new ComputadorasDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadorasDal();
        }
    }
}
