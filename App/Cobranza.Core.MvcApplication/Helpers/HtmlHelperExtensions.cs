using Cobranza.Core.MvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Cobranza.Core.MvcApplication.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static string RadioButtonList<TModel, TProperty, TRadioButtonListValue>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            RadioButtonListViewModel<TRadioButtonListValue> radioButtonListViewModel) where TModel : class
        {
            return htmlHelper.RadioButtonListFor(expression, radioButtonListViewModel);
        }

        public static string RadioButtonListFor<TModel, TProperty, TRadioButtonListValue>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            RadioButtonListViewModel<TRadioButtonListValue> radioButtonList) where TModel : class
        {
            var inputName = HtmlHelperExtensions.GetInputName(expression);

            if (radioButtonList == null)
            {
                return string.Empty;
            }

            if (radioButtonList.ListItems == null)
            {
                return string.Empty;
            }

            var divTag = new TagBuilder("div");

            divTag.MergeAttribute("id", inputName);

            divTag.MergeAttribute("class", "radio");

            foreach (var item in radioButtonList.ListItems)
            {
                var radioButtonTag = RadioButton(
                    htmlHelper,
                    inputName,
                    new SelectListItem
                        {
                            Text = item.Text,
                            Selected = item.Selected,
                            Value = item.Value.ToString()
                        },
                    null);

                divTag.InnerHtml += radioButtonTag;
            }

            MvcHtmlString htmlHelperValidationMessage = htmlHelper.ValidationMessage(inputName, "*") ?? MvcHtmlString.Empty;

            return divTag + htmlHelperValidationMessage.ToHtmlString();
        }

        public static string GetInputName<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            if (expression.Body.NodeType == ExpressionType.Call)
            {
                var methodCallExpression = (MethodCallExpression)expression.Body;

                string name = GetInputName(methodCallExpression);

                return name.Substring(expression.Parameters[0].Name.Length + 1);
            }

            return expression.Body.ToString().Substring(expression.Parameters[0].Name.Length + 1);
        }

        public static string RadioButton(
            this HtmlHelper htmlHelper,
            string name,
            SelectListItem listItem,
            IDictionary<string, object> htmlAttributes)
        {
            if (listItem == null)
            {
                throw new ArgumentNullException("listItem");
            }

            var inputIdSb = new StringBuilder();

            inputIdSb.Append(name)
                .Append("_")
                .Append(listItem.Value);

            var sb = new StringBuilder();

            var builder = new TagBuilder("input");

            if (listItem.Selected)
            {
                builder.MergeAttribute("checked", "checked");
            }

            builder.MergeAttribute("type", "radio");

            builder.MergeAttribute("value", listItem.Value);

            builder.MergeAttribute("id", inputIdSb.ToString());

            builder.MergeAttribute("name", name);

            builder.MergeAttributes(htmlAttributes);

            sb.Append(builder.ToString(TagRenderMode.SelfClosing));

            sb.Append(RadioButtonLabel(inputIdSb.ToString(), listItem.Text, htmlAttributes));

            sb.Append("<br />");

            return sb.ToString();
        }

        public static string RadioButtonLabel(
            string inputId,
            string displayText,
            IDictionary<string, object> htmlAttributes)
        {
            var labelBuilder = new TagBuilder("label");

            labelBuilder.MergeAttribute("for", inputId);

            labelBuilder.MergeAttributes(htmlAttributes);

            labelBuilder.InnerHtml = displayText;

            return labelBuilder.ToString(TagRenderMode.Normal);
        }

        private static string GetInputName(MethodCallExpression expression)
        {
            var methodCallExpression = expression.Object as MethodCallExpression;

            if (methodCallExpression != null)
            {
                return HtmlHelperExtensions.GetInputName(methodCallExpression);
            }

            return expression.Object.ToString();
        }
    }
}