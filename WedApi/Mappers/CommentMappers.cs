using WedApi.Dtos.Comment;
using WedApi.Models;

namespace WedApi.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId,
                StockSymbol = commentModel.Stock != null ? commentModel.Stock.Symbol : string.Empty,
            };
        }
        public static Comment ToCommentFromCreate(this CreateCommentDto createCommentDto, int stockId)
        {
            return new Comment
            {
                Title = createCommentDto.Title,
                Content = createCommentDto.Content,             
                StockId = stockId,
                
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentDto updateCommentDto)
        {
            return new Comment
            {
                Title = updateCommentDto.Title,
                Content = updateCommentDto.Content,
            };
        }
    }
}
