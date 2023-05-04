using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioRestRND.Controllers
{

    public class PersonaRND
    {
        public int idFuente;
        public string nombre;
        public string apellido;
        public string curp;
        public string fechaNacimiento;
        public string delito;
    }
    public class ValuesController : ApiController
    {


        public PersonaRND Buscar(string nombre, string apellido, string curp, string fechanacimiento)
        {
            PersonaRND persona = new PersonaRND();
            persona.idFuente = 2;
            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.curp = curp;
            persona.fechaNacimiento = fechanacimiento;
            persona.delito = "robo";

            return persona;
        }

        public String Get(int idFuente)
        {
            string res = string.Empty;

            List<PersonaRND> persona = new List<PersonaRND>();
            PersonaRND personaItem = new PersonaRND();
            personaItem.idFuente = 2;
            personaItem.nombre = "Francisco";
            personaItem.apellido = "Rios";
            personaItem.curp = "wew324";
            personaItem.fechaNacimiento = "04052023";
            personaItem.delito = "robo";

            persona.Add(personaItem);
            personaItem = new PersonaRND();

            personaItem.idFuente = 2;
            personaItem.nombre = "Luis";
            personaItem.apellido = "Aldama";
            personaItem.curp = "wqeq2424242";
            personaItem.fechaNacimiento = "04012023";
            personaItem.delito = "fraude";

            persona.Add(personaItem);

            res = Newtonsoft.Json.JsonConvert.SerializeObject(persona);


            return res;
        }
    }
}
