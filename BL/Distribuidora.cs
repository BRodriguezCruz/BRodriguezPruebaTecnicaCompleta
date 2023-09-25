using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Distribuidora
    {

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.DistribuidoraGetALL().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {              
                        foreach (var registro in query)
                        {
                            ML.Distribuidora distribuidora = new ML.Distribuidora();

                            distribuidora.IdDistribuidora = registro.IdDistribuidora;
                            distribuidora.Nombre = registro.Nombre;

                            result.Objects.Add(distribuidora);

                        }

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                    }

                }

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }

            return result;
        }

    }
}
