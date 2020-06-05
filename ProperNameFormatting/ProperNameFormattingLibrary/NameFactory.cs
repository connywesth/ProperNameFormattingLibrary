namespace ProperNameFormattingLibrary
{
    public class NameFactory
    {
        public ProperNameFormattingClass GetProperName(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                return new LastFirst(name);
            }
            else
            {
                return new FirstFirst(name);
            }
        }
    }

}


