using System.Collections.Generic;

namespace RenameDirectory
{
    public static class ListOrdering
    {
        public static void Sort(this List<FileDetails> objList, SortMethod sortMethod = SortMethod.Index, bool ascending = true)
        {
            switch (sortMethod)
            {
                case SortMethod.Index:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.OrginalIndex.CompareTo(y.OrginalIndex));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.OrginalIndex.CompareTo(x.OrginalIndex));
                    }
                    break;
                case SortMethod.Name:
                    if (ascending)
                    {
                        objList.Sort((x, y) => x.Name.CompareTo(y.Name));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.Name.CompareTo(x.Name));
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
        Index, Name, DateCreated, DateModified
    }


}
