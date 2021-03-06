﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BD_Auction_inc.Models
{
    public class ProductModel
    {

        public int pID { get; set; }
        public string pName { get; set; }
        public string pDescription { get; set; }
        public string pCatagory { get; set; }
        public int pStartingPrice { get; set; }
        public int CurrentBid { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string PictureID { get; set; }
        public string ProductMainPicture { get; set; }
        public int SellerID { get; set; }
        public string ProductStatus { get; set; }
        public HttpPostedFileBase ImageFile {get; set;}

    }
}