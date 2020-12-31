using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olamaz").ToString();//ürün ismini girmek zorunda
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category Boş Olamaz").ToString();
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat Boş Olamaz").ToString();
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Adeti Boş Olamaz").ToString();
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stok Boş Olamaz").ToString();

            RuleFor(p => p.UnitPrice).GreaterThan(0);//sıfırdan büyük olmalı
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);//ilk başta sıfır olabilir detarik
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);//kategoriid 2 olduğunda 10dan büyük olmalı

            //kendi kurallarımızı yazalım
            RuleFor(p=>p.ProductName).Must(StartWidthA).WithMessage("Ürün Adı A ile Başlamalı").ToString();
        }

        private bool StartWidthA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
