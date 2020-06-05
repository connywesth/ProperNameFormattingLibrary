namespace ProperNameFormattingLibrary
{
    public class LastFirst : ProperNameFormattingClass
    {
        public LastFirst(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                this.LastName = name.Substring(0, i).Trim();
                this.FirstName = name.Substring(i + 1).Trim();
            }
            else
            {
                this.LastName = "";
                this.FirstName = name;
            }
        }
    }
}