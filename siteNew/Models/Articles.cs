using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace siteNew.Models
{
    public class Articles
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Article { get; private set; }
        public string Email { get; private set; }
        public string Ename { get; private set; }
        public string Post_date { get; private set; }



        public Articles()
        {
            //DataTable table = Database.Select("SELECT title, article FROM Article");
            //Title =   table.Rows[0]["title"].ToString();
            //Article = table.Rows[0]["article"].ToString();
        }

        public void Add()
        {

        }

        public void Random()
        {
            Random rand = new Random();
            int count = rand.Next(0, 3);

            DataTable table = Database.Select("SELECT title, article FROM Article");
            if (table == null)
            {
                Title = "-";
                Article = "-";
                return;
            }

            Title = table.Rows[count]["title"].ToString();
            Article = table.Rows[count]["article"].ToString();
        }

        public void About()
        {
            Title = "О проекте";
            Article = "Это мой первый проект на ASP.NET";
        }

        public void Number(string id)
        {
            DataTable table = Database.Select("SELECT id, title, article, post_date FROM Article WHERE Id = '" + id + "'");
            try
            {
                Id = table.Rows[0]["id"].ToString();
                Title = table.Rows[0]["title"].ToString();
                Article = table.Rows[0]["article"].ToString();
                //Email = table.Rows[0]["email"].ToString();
                //Ename = Email.Substring(0, Email.IndexOf('@'));
                Post_date = ((DateTime)table.Rows[0]["post_date"]).ToString("yyyy-MM-dd");
            }
            catch
            {
                Id = "";
                Title = "";
                Title = "-";
                Article = "-";
                Email = "";
                Ename = "";
                Post_date = "";
                return;
            }

            

        }
    }
}