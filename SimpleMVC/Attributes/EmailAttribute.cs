using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class CustomEmailAddressAttribute : RegularExpressionAttribute
    {
        private const string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        static CustomEmailAddressAttribute()
        {
            // necessary to enable client side validation
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(CustomEmailAddressAttribute), typeof(RegularExpressionAttributeAdapter));
        }

        public CustomEmailAddressAttribute()
            : base(pattern)
        {
        }
    }
}