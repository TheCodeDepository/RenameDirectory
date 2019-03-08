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
                        objList.Sort((x, y) => x.OrgIndex.CompareTo(y.OrgIndex));
                    }
                    else
                    {
                        objList.Sort((x, y) => y.OrgIndex.CompareTo(x.OrgIndex));
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
            for (int i = 0; i < objList.Count; i++)
            {
                objList[i].Index = i;
            }
        }  
    }

    public enum SortMethod
    {
        Index, Name, DateCreated, DateModified
    }


}
