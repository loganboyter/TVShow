using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvShow2.Data;
using TvShow2.Data.Models;
using TVShow2.Web.Adapters.Interfaces;

namespace TVShow2.Web.Adapters
{
    public class TvShowAdapter : ITvShow
    {

        public TvShow GetShow(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return (Db.TvShows.Where(t => t.Id == id).FirstOrDefault());
        }

        public List<TvShow> GetShows()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return (Db.TvShows.ToList());
        }

        public void CreateShow(TvShow show)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.TvShows.Add(show);
            Db.SaveChanges();
        }

        public void UpdateShow(TvShow show, int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            TvShow Show = Db.TvShows.Where(t => t.Id == id).FirstOrDefault();
            Show.Title = show.Title;
            Show.Description = show.Description;
            Db.SaveChanges();
        }

        public void DeleteShow(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.TvShows.Remove(Db.TvShows.Where(t => t.Id == id).FirstOrDefault());
            Db.SaveChanges();
        }
    }
}