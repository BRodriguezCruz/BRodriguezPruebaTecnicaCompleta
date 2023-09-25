using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class ArtistaController : Controller
    {
        // GET: Artista
        public ActionResult GetAll()
        {
            ML.Artista artista = new ML.Artista();
            ML.Result result = BL.Artista.GetAllEF();

            if (result.Correct )
            {
                artista.Artistas = result.Objects;
            }

            return View(artista);
        }

        [HttpGet]
        public ActionResult Form(int? idArtista)
        {
            ML.Artista artista = new ML.Artista();

            if ( idArtista != null )
            {
                
                ML.Result resultArtista = BL.Artista.GetById(idArtista.Value);

                if (resultArtista.Correct)
                {
                    artista = (ML.Artista)resultArtista.Object;
                }
            }
            return View(artista);
        }

        [HttpPost]  
        public ActionResult Form(ML.Artista artista)
        {

            if (artista.IdArtista == 0)
            {
                ML.Result result = BL.Artista.Add(artista);

                if (result.Correct )
                {
                    ViewBag.Message = "REGISTRO AGREGADO EXITOSAMENTE";
                }
                else
                {
                    ViewBag.Message = "ERROR, REGISTRO NO AGREGADO";
                }
            }
            else
            {
                ML.Result result = BL.Artista.Update(artista);

                if (result.Correct)
                {
                    ViewBag.Message = "REGISTRO ACTUALIZADO EXITOSAMENTE";
                }
                else
                {
                    ViewBag.Message = "ERROR, REGISTRO NO ACTUALIZADO";
                }
            }

            return PartialView("Modal");
        }


        public ActionResult Delete (int idArtista)
        {
            ML.Result result = BL.Artista.Delete(idArtista);

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