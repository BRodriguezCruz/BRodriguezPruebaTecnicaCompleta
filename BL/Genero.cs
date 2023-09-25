using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Genero
    {
        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.GeneroGetALL().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Genero genero = new ML.Genero();

                            genero.IdGenero = registro.IdGenero;
                            genero.Nombre = registro.Nombre;

                            result.Objects.Add(genero);

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
