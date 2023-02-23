using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaLogicaNegocio
{
        
        public class N_Aula
        {
        D_Aula d_Aula = new D_Aula();
        //Insertar Aula

       
        public void insertAulaN(E_Aula e_Aula)
        {
            d_Aula.insertAula(e_Aula);
        }
        //Actualizar aula
       
        public void updateAulaN(E_Aula e_Aula, String newId)
        {
            d_Aula.updateAula(e_Aula, newId);
        }
        //Listar aulas por ID
      
        public List<E_Aula> listarPorIdN(String buscar)
        {
            return d_Aula.listarPorId(buscar);
        }
        //Listar Aulas por Edificio
      
        public List<E_Aula> listarPorEdificioN(int buscar)
        {
            return d_Aula.listarPorEdificio(buscar);
        }
        //Eliminar aulas

        public void deleteAulaN(E_Aula e_Aula)
        {
            d_Aula.deleteAula(e_Aula);
        }
    }
}
