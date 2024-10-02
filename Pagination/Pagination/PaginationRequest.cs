using System.Collections;

namespace Pagination
{
    public class PaginationRequest<T> : IEnumerable<T>
    {
        public int PageSize { get;  set; }
        public int PageNumber { get; set; }
        public IEnumerable<T> Source { get; set; }
        public Func<T, bool> Filter { get; set; }

        public PaginationRequest( int pageSize, int pageNumber, IEnumerable<T> source, Func<T, bool> function)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
            Source = source;
            Filter = function;

        }

        public IEnumerable<T> GetResponse()
        {
            var result = Source.Where(Filter).ToList();

            //List<T> result = new List<T>();

            //foreach (var item in Source)
            //{
            //    if (Filter(item))
            //    {
            //        result.Add(item);
            //    }
            //}

            int totalCount = result.Count();
            int totalPages = (int)Math.Ceiling((decimal)totalCount / PageSize);
            if(PageNumber > totalPages)
            {
                PageNumber = totalPages;
            }
            var itemPerPage = result.Skip((PageNumber - 1) * PageSize).Take(PageSize);

            return itemPerPage.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {

            return GetResponse().GetEnumerator(); 
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }
    }
}