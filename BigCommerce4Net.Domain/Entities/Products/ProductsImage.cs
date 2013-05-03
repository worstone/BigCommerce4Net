#region License
//   Copyright 2013 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using BigCommerce4Net.Domain.ExtensionMethods;

namespace BigCommerce4Net.Domain
{
    public class ProductsImage : EntityBase
    {
        /// <summary>
        /// The unique ID of this image. The ID is auto generated and can not be changed.
        /// 
        /// int
        /// </summary>
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        /// <summary>
        /// The ID of the product this image belongs to.
        /// 
        /// int
        /// </summary>
        [JsonProperty("product_id")]
        public virtual int ProductId { get; set; }

        /// <summary>
        /// GET Request
        ///Path to the full sized image which was originally uploaded. The path will be relative to the products_images folder on the store. 
        ///For example, the path returned might be "sample_images/nano_black__99806.jpg". 
        ///The URL to the image would be "http://www.example.com/product_images/sample_images/nano_black__99806.jpg" for a store at "www.example.com". 
        ///
        ///PUT/POST Request 
        ///When updating a product image, the image_file should be specified as either: 
        ///
        ///A path to an image already uploaded via FTP in the import directory. 
        ///The path should be relative from the import directory.
        ///A URL to an image accessible on the internet.
        /// 
        /// string(255)
        /// </summary>
        [JsonProperty("image_file")]
        public virtual string ImageFile { get; set; }


        /// <summary>
        /// If true, the image is used as the product thumbnail.
        /// 
        /// boolean
        /// </summary>
        [JsonProperty("is_thumbnail")]
        public virtual bool IsThumbnail { get; set; }

        /// <summary>
        /// The order in which the image will be displayed on the product page. 
        /// When updating if the image is given a lower priority, all image with a sort_order the 
        /// same or greater than the images new sort_order value will have their sort_order reordered
        /// 
        /// int
        /// </summary>
        [JsonProperty("sort_order")]
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// The description for the image.
        /// 
        /// text
        /// </summary>
        [JsonProperty("description")]
        public virtual string Description { get; set; }


        [JsonIgnore]
        public virtual DateTime? DateCreated { get; set; }
        
        /// <summary>
        /// The date the image was added to the product.
        /// 
        /// date
        /// </summary>
        [JsonProperty("date_created")]
        public virtual string DateCreatedUT {
            get {
                return DateCreated.DateTimeToString();
            }
            set {
                DateCreated = value.StringToDateTime();
            }
        }


    }
}