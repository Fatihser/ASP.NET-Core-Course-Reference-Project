using Microsoft.AspNetCore.Razor.TagHelpers;
using RepositoryDesignPatternProjectWeb.Data.Context;
using System.Linq;

namespace RepositoryDesignPatternProjectWeb.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount:TagHelper
    {
        public int ApplicationUserId { get; set; }
        private readonly BankContext _context;

        public GetAccountCount(BankContext context)
        {
            _context = context;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Accounts.Count(x => x.ApplicationUserId ==
              ApplicationUserId);
            var html = $"<span class='badge bg-danger'>{accountCount}</span>";

            output.Content.SetHtmlContent(html);
        }

    }
}
