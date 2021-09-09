using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private SaveCategoryResponse(bool sucess, string message, Category category) : base(sucess, message) 
        {
            Category = category;
        }

        public SaveCategoryResponse(Category category) : this(true, string.Empty, category) 
        { }

        public SaveCategoryResponse(string message) : this(false, message, null)
    }
}
