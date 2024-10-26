namespace WedApi.Helpers
{
    public class Pagination
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 5;
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public Pagination(int totalItems, int currentPage, int pageSize)
        {
            TotalItems = totalItems;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            CurrentPage = currentPage > 0 ? currentPage : 1;
        }
    }
}
