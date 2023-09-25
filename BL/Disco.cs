using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Disco
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.DiscoGetAll().ToList();

                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Disco disco = new ML.Disco();

                            disco.IdDisco = registro.IdDisco;
                            disco.Titulo = registro.Titulo;
                            disco.Año = registro.Anio;
                            disco.Duracion = registro.Duracion;
                            disco.Ventas = registro.Ventas;
                            disco.Disponibilidad = registro.Disponibilidad;

                            disco.Artista = new ML.Artista();
                            disco.Artista.IdArtista = registro.IdArtista;
                            disco.Artista.Nombre = registro.NombreArtista;
                            disco.Artista.NombreArtistico = registro.NombreAtistico;

                            disco.Distribuidora = new ML.Distribuidora();
                            disco.Distribuidora.IdDistribuidora = registro.IdDistribuidora;
                            disco.Distribuidora.Nombre = registro.NombreDistribuidora;

                            disco.Genero = new ML.Genero();
                            disco.Genero.IdGenero = registro.IdGenero;
                            disco.Genero.Nombre = registro.NombreGenero;


                            result.Objects.Add(disco);

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

        public static ML.Result GetById(int idDisco)

        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {
                    var query = context.DiscoGetById(idDisco).SingleOrDefault();

                    if (query != null)
                    {
                        ML.Disco disco = new ML.Disco();

                        disco.IdDisco = query.IdDisco;
                        disco.Titulo = query.Titulo;
                        disco.Duracion = query.Duracion;
                        disco.Año = query.Anio;
                        disco.Ventas = query.Ventas;
                        disco.Disponibilidad = query.Disponibilidad;

                        disco.Artista = new ML.Artista();
                        disco.Artista.IdArtista = query.IdArtista;
                        disco.Artista.Nombre = query.NombreArtista;
                        disco.Artista.NombreArtistico = query.NombreAtistico;

                        disco.Genero = new ML.Genero();
                        disco.Genero.IdGenero = query.IdGenero;
                        disco.Genero.Nombre = query.NombreGenero;

                        disco.Distribuidora = new ML.Distribuidora();
                        disco.Distribuidora.IdDistribuidora = query .IdDistribuidora;
                        disco.Distribuidora.Nombre = query.NombreDistribuidora;

                        result.Object = disco;

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

        public static ML.Result Add (ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.DiscoAdd(disco.Titulo, disco.Duracion, disco.Año, disco.Ventas, disco.Disponibilidad,
                                                disco.Artista.IdArtista, disco.Genero.IdGenero, disco.Distribuidora.IdDistribuidora);

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
            catch(Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }


            return result;
        }

        public static ML.Result Update(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.DiscoUpdate(disco.IdDisco, disco.Titulo, disco.Duracion, disco.Año, disco.Ventas, disco.Disponibilidad,
                                                disco.Artista.IdArtista, disco.Genero.IdGenero, disco.Distribuidora.IdDistribuidora);

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

        public static ML.Result Delete(int idDisco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.BRodriguezPruebaTecnica2CompletaEntities context = new DLEF.BRodriguezPruebaTecnica2CompletaEntities())
                {

                    var query = context.DiscoDelete(idDisco);

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
