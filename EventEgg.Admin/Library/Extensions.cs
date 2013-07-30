using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EventEgg.Admin.Library
{
    public class EmailValidationAttribute : RegularExpressionAttribute
    {
        public EmailValidationAttribute()
            : base(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$")
        {

        }

        
    }

    public static class CommonExtensions
    {
        public static string RadioButtonList(this HtmlHelper helper, string name, IEnumerable<string> items)
        {
            var selectList = new SelectList(items);
            return helper.RadioButtonList(name, selectList);
        }

        public static string RadioButtonList(this HtmlHelper helper, string name, IEnumerable<SelectListItem> items)
        {
            TagBuilder tableTag = new TagBuilder("table");
            tableTag.AddCssClass("radio-main");

            var trTag = new TagBuilder("tr");
            foreach (var item in items)
            {
                var tdTag = new TagBuilder("td");
                var rbValue = item.Value ?? item.Text;
                var rbName = name + "_" + rbValue;
                var radioTag = helper.RadioButton(rbName, rbValue, item.Selected, new { name = name });

                var labelTag = new TagBuilder("label");
                labelTag.MergeAttribute("for", rbName);
                labelTag.MergeAttribute("id", rbName + "_label");
                labelTag.InnerHtml = rbValue;

                tdTag.InnerHtml = radioTag.ToString() + labelTag.ToString();

                trTag.InnerHtml += tdTag.ToString();
            }
            tableTag.InnerHtml = trTag.ToString();

            return tableTag.ToString();
        }
    }
}