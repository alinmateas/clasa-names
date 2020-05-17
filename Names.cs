using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Names
{
    public class Names
    {
        private List<Name> namesList;

        public Names()
        {
            namesList = new List<Name>();
            namesList.Add(new Name(1,"Ciprian","Marica"));
            namesList.Add(new Name(2, "Gica", "Hagi"));
            namesList.Add(new Name(3, "Cristi", "Chivu"));
            namesList.Add(new Name(4, "Adi", "Mutu"));
        }

        public Name this[int nameId]
        {
            get
            {
                if (nameId > namesList.Count) throw new ArgumentOutOfRangeException();
                return namesList.Find(name => name.Id == nameId);
            }
        }
        
        public Name this[string nameGiven]
        {
            get
            {
                return namesList.Find(name => name.FirstName.Contains(nameGiven));
            }
        }
    }
}
