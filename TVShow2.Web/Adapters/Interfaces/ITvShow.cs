using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvShow2.Data.Models;

namespace TVShow2.Web.Adapters.Interfaces
{
    public interface ITvShow
    {
        TvShow GetShow(int id);
        List<TvShow> GetShows();
        void CreateShow(TvShow show);
        void UpdateShow(TvShow show, int id);
        void DeleteShow(int id);
        
    }
}
