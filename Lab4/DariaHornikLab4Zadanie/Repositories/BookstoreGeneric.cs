using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Repositories
{
    class BookstoreGeneric<T> : IBookstore<T> where T : class
    {
        /// <summary>
        /// Context bazy danaych -połączenie  z bazą
        /// </summary>
        private readonly Models.BookstoreContext _context;


        public BookstoreGeneric()
        {
            _context = new Models.BookstoreContext();
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
        public void Update(T entity)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();

        }
    }
}
