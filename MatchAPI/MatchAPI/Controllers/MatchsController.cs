using MatchAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MatchAPI.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    public class MatchsController : ApiController
    {
        //Declaramos el repo para recuperar lista de partidos
        // GET: api/Matchs
        public IEnumerable<Match> Get()
        {
            var repo = new MatchsRepository();
            List<Match> matchList = repo.Retrieve();

            return matchList;

        }

        //Declaramos el repo para recuperar partidos por id
        // GET: api/Matchs?idpartido=id
        public IEnumerable<Match> GetId(int idpartido)
        {
            var repo = new MatchsRepository();
            List<Match> betList = repo.RetrieveById(idpartido);

            return betList;

        }
        //Lee partidos
        // GET: api/Matchs/5
        public Match Get(int id)
        {

            return null;
        }

        //Crear apuestas
        // POST: api/Matchs
        public void Post([FromBody]Match bet)
        {
            //var repo = new MatchsRepository();
            //repo.Save(bet);
        }

        //Modificar mercado
        // PUT: api/Matchs/5
        public void Put(Boolean isOver, [FromBody]Market market)
        {
            var repo = new MatchsRepository();
            repo.InsertBet(isOver, market);
        }

        //Eliminar por id
        // DELETE: api/Matchs/5
        public void Delete(int id)
        {
        }
    }
}