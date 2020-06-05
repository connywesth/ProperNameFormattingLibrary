using System.Collections.Generic;

namespace ProperNameFormattingLibrary
{
    public class ProperNameFormattingClass
    {
        protected List<string> SolitaryNobelPrefixes { get; set; }
        protected List<string> MergedNobelPrefixes { get; set; }
        protected string LastName { get; set; }
        protected string FirstName { get; set; }

        public ProperNameFormattingClass()
        {
            SolitaryNobelPrefixes = new List<string> { "af", "den", "der", "van", "von", "du" };
            MergedNobelPrefixes = new List<string> { "Mc" };
        }

        public string FirstAndLastName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public string LastAndFirstName()
        {
            return $"{this.LastName}, {this.FirstName}";
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
