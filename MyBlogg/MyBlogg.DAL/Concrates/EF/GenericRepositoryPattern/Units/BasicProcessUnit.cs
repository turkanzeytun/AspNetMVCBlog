using MyBlogg.DAL.Concrates.EF.Contexts;
using MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Repositories;
using MyBlogg.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Units
{
    public class BasicProcessUnit : IBasicProcessUnit
    {
        private MyBlogDB6608Context _context = new MyBlogDB6608Context();
        private GenericRepository<MakaleKategori> _makaleCategoryRepository;
        private GenericRepository<Makale> _makaleRepository;
        private GenericRepository<Blog_Makale> _blog_MakaleRepository;
        private GenericRepository<MakaleYorumlar> _makaleYorumlarRepository;
        private GenericRepository<YorumAtanBilgiler> _yorumAtanBilgilerRepository;
        private GenericRepository<MakaleTur> _makaleTurRepository;
        private bool _disposed = false;

        public GenericRepository<MakaleKategori> MakaleCategoryRepository
        {
            get
            {
                if (_makaleCategoryRepository == null)
                    _makaleCategoryRepository = new GenericRepository<MakaleKategori>(_context);
                return _makaleCategoryRepository;
            }
        }
        public GenericRepository<Makale> MakaleRepository
        {
            get
            {
                if (_makaleRepository == null)
                    _makaleRepository = new GenericRepository<Makale>(_context);
                return _makaleRepository;
            }
        }
        public GenericRepository<Blog_Makale> Blog_MakaleRepository
        {
            get
            {
                if (_blog_MakaleRepository == null)
                    _blog_MakaleRepository = new GenericRepository<Blog_Makale>(_context);
                return _blog_MakaleRepository;
            }
        }
        public GenericRepository<MakaleYorumlar> MakaleYorumlarRepository
        {
            get
            {
                if (_makaleYorumlarRepository == null)
                    _makaleYorumlarRepository = new GenericRepository<MakaleYorumlar>(_context);
                return _makaleYorumlarRepository;
            }
        }
        public GenericRepository<YorumAtanBilgiler> YorumAtanBilgilerRepository
        {
            get
            {
                if (_yorumAtanBilgilerRepository == null)
                    _yorumAtanBilgilerRepository = new GenericRepository<YorumAtanBilgiler>(_context);
                return _yorumAtanBilgilerRepository;
            }
        }
        public GenericRepository<MakaleTur> MakaleTurRepositoryRepository
        {
            get
            {
                if (_makaleTurRepository == null)
                    _makaleTurRepository = new GenericRepository<MakaleTur>(_context);
                return _makaleTurRepository;
            }
        }
        public void Save()
        {
            //using (TransactionScope tScope = new TransactionScope())
            //{
            _context.SaveChanges();
            //tScope.Complete();
            //}
        }
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this._disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this._disposed = true;
        //}
        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
