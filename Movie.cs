using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_2
{
    class Movie
    {
        #region fields
        private string title;
        private string category;
        #endregion fields

        #region properties
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        #endregion properties


        #region constructor
        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        #endregion constructor

        #region methods
        public override string ToString()
        {
            return $"{title}";
        }

        #endregion methods
    }
}
