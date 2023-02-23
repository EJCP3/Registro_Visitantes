using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades_test;
using Capa_Datos_test;

namespace CapaLogicaNegocio_test
{
    [TestClass]
    public class N_Aula
    {
      
        D_Aula d_Aula = new D_Aula();

        //Insertar Aula
        [TestMethod]
        public void insertAulaN(E_Aula e_Aula)
        {
            d_Aula.insertAula(e_Aula);
        }
        //Actualizar aula

        [TestMethod]
        public void updateAulaN(E_Aula e_Aula, String newId)
        {
            d_Aula.updateAula(e_Aula, newId);
        }
        //Listar aulas por ID

        [TestMethod]
        public List<E_Aula> listarPorIdN(String buscar)
        {
            return d_Aula.listarPorId(buscar);
        }
        //Listar Aulas por Edificio

        [TestMethod]
        public List<E_Aula> listarPorEdificioN(int buscar)
        {
            return d_Aula.listarPorEdificio(buscar);
        }
        //Eliminar aulas
        [TestMethod]
        public void deleteAulaN(E_Aula e_Aula)
        {
            d_Aula.deleteAula(e_Aula);
        }
    }
}

