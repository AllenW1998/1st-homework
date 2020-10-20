﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    

    
    public class Order
    {  
        public int ID { get; set; }

        public string GoodsName { get; set; }

        public string Customer { get; set; }

        public decimal Price { get; set; }

        //public Order(int iD, string goodsName, string customer, decimal price)
        //{
        //    ID = iD;
        //    GoodsName = goodsName ?? throw new ArgumentNullException(nameof(goodsName));
        //    Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        //    this.Price = price;
        //}

        //public Order()
        //{

        //}

        //public override string ToString()
        //{
        //    string str = "该订单信息如下： ID:" + this.ID.ToString() + " GoodsName:" + this.GoodsName + " Customer:" + this.Customer + " Price:" + this.Price.ToString();
        //    return str;
        //}

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Order)) return false;
        //    return this.ID == ((Order)obj).ID;
        //}
        

    }
}
