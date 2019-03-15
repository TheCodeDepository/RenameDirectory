using System.Collections.Generic;

namespace RenameCollection
{
    public static class ListOrdering
    {
        public static void Sort(this List<Document> objList, SortMethod sortMethod = SortMethod.Index, bool ascending = true)
        {
            switch (sortMethod)
            {                    
                case SortMethod.Name:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.FileName.CompareTo(y.FileName));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.FileName.CompareTo(x.FileName));
                    }
                    break;
                case SortMethod.DateTaken:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.EarliestDate.CompareTo(y.EarliestDate));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.EarliestDate.CompareTo(x.EarliestDate));
                    }
                    break;
                case SortMethod.DateCreated:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.DateCreated.CompareTo(y.DateCreated));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.DateCreated.CompareTo(x.DateCreated));
                    }
                    break;
                case SortMethod.DateModified:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.DateModified.CompareTo(y.DateModified));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.DateModified.CompareTo(x.DateModified));
                    }
                    break;
            }
        }  
    }

    public enum SortMethod
    {
        Index, Name, DateTaken, DateCreated, DateModified
    }


}
