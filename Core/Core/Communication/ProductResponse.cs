using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Communication
{
    public class ProductResponse : BaseResponse
    {
        public Product Product { get; private set; }

        private ProductResponse(bool sucess, string message, Product product) : base(sucess, message)
        {
            Product = product;
        }

        public ProductResponse(Product product) : this(true, string.Empty, product)
        { }

        public ProductResponse(string message) : this(false, message, null)
        { }
    }
}
