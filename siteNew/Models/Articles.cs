using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace siteNew.Models
{
    public class Articles
    {
        public string Title { get; private set; }
        public string Article { get; private set; }

        public string[] titles = new string[3];
        public string[] articles = new string[3];

        public Articles()
        {
            titles[0] = "Тыква: как вырастить хороший урожай";
            articles[0] = "Тыкву в былые времена часто высаживали на самых дальних участках подворья как раз по той причине, что ухода ей почти не нужно. Там она разрасталась вширь, занимая большие площади. Но на современных дачах участки небольшие – 6-10 соток. Отдать под тыкву все – нелепо. Поэтому многие огородники с ней просто не связываются. А между тем эти растения можно разместить компактно.";

            titles[1] = "Обрезка старой яблони";
            articles[1] = "Обрезку старой яблони нужно проводить в три этапа.";

            titles[2] = "Весенняя обработка деревьев и кустарников от вредителей и болезней";
            articles[2] = "Итак, с чего нужно начинать весеннюю обработку деревьев и кустарников? Для начала предлагаем осмотреться, как растения пережили зиму. Наверняка есть поломанные ветки. Пока еще довольно прохладно, сокодвижение внутри растений не началось. Поэтому смело обрезайте все, что надломилось за зиму.";
        }

        public void view(int a)
        {
            Title = titles[a];
            Article = articles[a];
        }

        public void add()
        {

        }

        public void random()
        {
            Random rand = new Random();
            int count = rand.Next(0, 3);

            Title = titles[count];
            Article = articles[count];
        }
    }
}