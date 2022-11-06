using ShopProgramWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopProgramWpf.FakeDatas;

public class FakeProducts
{
    public List<Product> products = new()
    {
        new Product("Iphone",12,12.5f),
        
    };
}
