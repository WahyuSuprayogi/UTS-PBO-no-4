using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbono4
{
    public class TextBook
    {
        protected String title;
        protected String author;
        protected String publisher;

        public  void setTitle(string title)
        {
            this.title = title;
        }
        public string getTitle()
        {
            return title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getAuthor()
        {
            return author;
        }
        public void setPublishser(string publisher)
        {
            this.publisher = publisher;
        }
        public string getPublisher()
        {
            return publisher;
        }
    }
}
