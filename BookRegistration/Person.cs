using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistration
{
    class Person
    {
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string Category { get; set; }
        public string Isbn { get; set; }
        public bool PortugueseLanguage { get; set; }
        public bool EnglishLanguage { get; set; }
        public char Format { get; set; }
    }
}
