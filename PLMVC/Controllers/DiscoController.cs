using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class DiscoController : Controller
    {
        // GET: Disco
        public ActionResult GetAll()
        {
            ML.Result result = BL.Disco.GetAll();
            ML.Disco disco = new ML.Disco();

            if (result.Correct)
            {               
                disco.Discos = result.Objects;
            }
            return View(disco);
        }


        [HttpGet]
        public ActionResult Form(int? idDisco)
        {
            ML.Disco disco = new ML.Disco();
            disco.Artista = new ML.Artista();
            disco.Distribuidora = new ML.Distribuidora();
            disco.Genero = new ML.Genero();

            ML.Result resultArtista = BL.Artista.GetAllEF();
            ML.Result resultGenero = BL.Genero.GetAllEF();
            ML.Result resultDistribuidora = BL.Distribuidora.GetAllEF();

            if (idDisco != null) 
            {
                ML.Result resultUpdate = BL.Disco.GetById(idDisco.Value);

                if (resultUpdate.Correct)
                {
                    disco = (ML.Disco)resultUpdate.Object;
                    disco.Artista.Artistas = resultArtista.Objects;
                    disco.Genero.Generos = resultGenero.Objects;
                    disco.Distribuidora.Distribuidoras = resultDistribuidora.Objects;
                }
                return View(disco);
            }
            else
            {
                disco.Artista.Artistas = resultArtista.Objects;
                disco.Genero.Generos = resultGenero.Objects;
                disco.Distribuidora.Distribuidoras = resultDistribuidora.Objects;
                return View(disco);
            }      
        }

        [HttpPost]
        public ActionResult Form(ML.Disco disco)
        {
            ML.Result result = new ML.Result();

            if (disco.IdDisco == 0)
            {
                result = BL.Disco.Add(disco);

                if (result.Correct)
                {
                    ViewBag.Message = "INSERTADO CORRECTAMENTE";
                }
                else
                {
                    ViewBag.Message = "ERROR, RESGISTRO NO INSERTADO";
                }

            }
            else
            {
                result = BL.Disco.Update(disco);

                if (result.Correct)
                {
                    ViewBag.Message = "ACTUALIZACION EXITOSA";
                }
                else
                {
                    ViewBag.Message = "ERROR, REGISTRO NO ACTUALIZADO";
                }

            }

            return PartialView("Modal");
        }

        public ActionResult Delete (int idDisco)
        {
            ML.Result result = BL.Disco.Delete(idDisco);

            if (result.Correct)
            {
                ViewBag.Message = "REGISTRO ELIMINADO EXITOSAMENTE";
            }
            else
            {
                ViewBag.Message = "ERROR, REGISTRO NO ELIMINADO";
            }

            return PartialView("Modal");
        }
    }
}