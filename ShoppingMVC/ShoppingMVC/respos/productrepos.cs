using ShoppingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingMVC.respos
{
    public class productrepos
    {
        public List<ClipcartModel> GetProduct()
        {
            return DataSourceMens();
        }
        public List<WomensModel> GetProductWomens()
        {
            return DataSourceWomens();
        }
        public ClipcartModel GetProductId(int Id)
        {
            return DataSourceMens().Where(x => x.Id == Id).FirstOrDefault();
        }
        public WomensModel GetProductWomensId(int Id)
        {
            return DataSourceWomens().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<ClipcartModel> SearchProduct(string ProductNames)
        {
            return DataSourceMens().Where(x => x.ProductName.Contains(ProductNames)).ToList();
        }
        public List<WomensModel> SearchWomensProduct(string ProductNames)
        {
            return DataSourceWomens().Where(x => x.ProductName.Contains(ProductNames)).ToList();
        }
        private List<ClipcartModel> DataSourceMens()
        {
            return new List<ClipcartModel>()
            {
                new ClipcartModel(){Id=1,ProductName="Jack & Jones",Brand="Slim Men",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=2,ProductName="Jack & Jones",Brand="Round neck",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=3,ProductName="Jack & Jones",Brand="Printed neck",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=4,ProductName="Jack & Jones",Brand="Full sleav",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=5,ProductName="Jack & Jones",Brand="Slim Men",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=6,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=7,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=8,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new ClipcartModel(){Id=9,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
               


            };
        }
        private List<WomensModel> DataSourceWomens()
        {
            return new List<WomensModel>()
            {
                new WomensModel(){Id=1,ProductName="Jack & Jones",Brand="Slim Men",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=2,ProductName="Jack & Jones",Brand="Round neck",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=3,ProductName="Jack & Jones",Brand="Printed neck",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=4,ProductName="Jack & Jones",Brand="Full sleav",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=5,ProductName="Jack & Jones",Brand="Slim Men",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=6,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=7,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=8,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},
                new WomensModel(){Id=9,ProductName="Jack & Jones",Brand="Adidas",Descriptions="This product is good quality and quandity"},



            };
        }
    }
}
