using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Artista
    {

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.ArtistaGetAll().ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Artista artista = new ML.Artista();

                            artista.IdArtista = registro.IdArtista;
                            artista.Nombre = registro.Nombre;
                            artista.ApellidoPaterno = registro.ApellidoPaterno;
                            artista.ApellidoMaterno = registro.ApellidoMaterno;
                            artista.FechaNacimiento = registro.FechaNacimiento;
                            artista.NombreArtistico = registro.NombreAtistico;
                             

                            result.Objects.Add(artista);

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

        public static ML.Result GetById (int idArtista)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.ArtistaGetById(idArtista).SingleOrDefault();

                    if (query != null)
                    {
                        ML.Artista artista = new ML.Artista();

                        artista.Nombre = query.Nombre;
                        artista.ApellidoPaterno = query.ApellidoPaterno;
                        artista.ApellidoMaterno = query.ApellidoMaterno;
                        artista.FechaNacimiento = query.FechaNacimiento;
                        artista.NombreArtistico = query.NombreAtistico;

                        result.Object = artista;

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

        public static ML.Result Update(ML.Artista artista)
        {
            ML.Result result = new ML.Result();


            try
            {
                using(DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {
                    var query = context.ArtistaUpdate(artista.IdArtista, artista.Nombre, artista.ApellidoPaterno, artista.ApellidoMaterno, artista.FechaNacimiento, artista.NombreArtistico);
                
                    if(query > 0)
                    {
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

        public static ML.Result Add(ML.Artista artista)
        {
            ML.Result result = new ML.Result();


            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {
                    var query = context.ArtistaUpdate(artista.IdArtista, artista.Nombre, artista.ApellidoPaterno, artista.ApellidoMaterno, artista.FechaNacimiento, artista.NombreArtistico);

                    if (query > 0)
                    {
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

        public static ML.Result Delete (int idArtista)
        {
            ML.Result result = new ML.Result();


            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {
                    var query = context.ArtistaDelete(idArtista);

                    if (query > 0)
                    {
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
