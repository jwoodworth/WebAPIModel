using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIModel.Models
{
    public class Data
    {
        private static ProductModel[] _products;
        public static ProductModel[] Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductModel[]
                    {
                        new ProductModel
                        {
                            id =1,
                            name="Gray T-Shirt",
                            price = 12.50m,
                            description = "The Alder Gator gray t-shirt is a comfortable and classic choice."
                        },
                       new ProductModel
                        {
                             id =2,
                            name="Black T-Shirt",
                            price = 12.50m,
                            description = "The Alder Gator black t-shirt is a modern choice."
                         }


                    };
                }
                return _products;
            }
        }
    }
}
