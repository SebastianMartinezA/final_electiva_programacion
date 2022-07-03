using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

using Negocio;

namespace WebApplication1.Pages
{
    public class BusquedaModel : PageModel
    {
        private DireccionTransito dt;
        public void OnGet()
        {
            dt = new DireccionTransito();
        }

        public void OnLoad()
        {
            dt = new DireccionTransito();
        }

        private string patente;

        public string Patente { get => patente; set => patente = value; }

        public IActionResult OnPost()
        {
            string patente = Request.Form["patente"];

            Vehiculo? vehi = dt.Vehiculos.FirstOrDefault(v => v.Patente == patente);
            if (vehi != null)
            {
                if (vehi.Incidentes.Count > 1)
                {
                    return RedirectToPage("/Infracciones", new { patente = patente });
                }
            }
            return RedirectToPage("/Error", new { patente = patente });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMemoryCache();
            services.AddMvc();
        }
    }
}
