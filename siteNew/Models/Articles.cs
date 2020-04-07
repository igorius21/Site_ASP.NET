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
        private bool error;


        public Articles()
        {
            error = false;
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
                Id = "";
                Title = "";
                Article = "";
                Post_date = "";
                error = true;
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
            DataTable table = Database.Select("SELECT id, title, article, post_date FROM Article WHERE Id = '" + Database.Addslashes(id) + "'");
            ExtractRow(table);
        }

        private void ExtractRow(DataTable table)
        {
            ExtractRow(table, 0);
        }

        private void ExtractRow(DataTable table, int nr)
        {
            try
            {
                this.Id = table.Rows[nr]["id"].ToString();
                Title = table.Rows[nr]["title"].ToString();
                Article = table.Rows[nr]["article"].ToString();
                //Email = table.Rows[nr]["email"].ToString();
                //Ename = Email.Substring(0, Email.IndexOf('@'));
                Post_date = ((DateTime)table.Rows[nr]["post_date"]).ToString("yyyy-MM-dd");
            }
            catch
            {
                this.Id = "";
                Title = "";
                Article = "";
                Email = "";
                Ename = "";
                Post_date = "";
                error = true;
                return;
            }
        }

        public bool IsError()
        {
            return error;
        }
    }
}