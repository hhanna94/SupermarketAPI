using SupermarketAPI.Domain.Models;

namespace SupermarketAPI.Domain.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        // Creates a successful response
        public SaveCategoryResponse(Category category) : this(true, string.Empty, category)
        { }

        // Creates an error
        public SaveCategoryResponse(string message) : this(false, message, null)
        { }
    }
}