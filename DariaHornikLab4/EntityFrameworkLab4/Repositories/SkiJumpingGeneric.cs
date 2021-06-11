using EntityFrameworkLab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLab4.Repositories
{
    class SkiJumpingGeneric<T> : ISkiJumpingGeneric<T> where T : class
    {
        /// <summary>
        /// Context bazy danaych -połączenie z nią
        /// </summary>
        private readonly SkiJumpingContext _context;


        public SkiJumpingGeneric()
        {
            _context = new SkiJumpingContext();
        }


        /// <summary>
        /// Dodanie mowego rekordu
        /// </summary>
        /// <param name="enity"></param>
        public void Create(T enity)
        {
            _context.Set<T>().Add(enity);
        }



        public void DeleteById(int id)
        {
            T entities = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entities);
        }


        /// <summary>
        /// pobieranie query z bazy danych 
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Get()
        {
            return _context.Set<T>().AsQueryable();
        }


        /// <summary>
        /// pobieranie wszystkich danych z tabeli
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }


        /// <summary>
        /// pobranie obiektu z bazy po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }



        /// <summary>
        /// zapis dokonanych zmian
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// aktualizacja danych 
        /// </summary>
        /// <param name="enity"></param>
        public void Update(T enity)
        {
            _context.Entry(enity).CurrentValues.SetValues(enity);
            _context.SaveChanges();
          
        }
    }
}
