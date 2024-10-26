using WedApi.Dtos.Stock;

namespace WedApi.Helpers
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public Pagination Pagination { get; set; }

        public PagedResult(List<T> items, int totalItems, int currentPage, int pageSize)
        {
            Items = items;
            Pagination = new Pagination(totalItems, currentPage, pageSize);
        }

     
    }
}
