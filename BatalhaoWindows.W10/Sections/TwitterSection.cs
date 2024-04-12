using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Twitter;
using AppStudio.Uwp.Actions;
using AppStudio.Uwp.Commands;
using AppStudio.Uwp;
using System.Linq;

using BatalhaoWindows.Navigation;
using BatalhaoWindows.ViewModels;

namespace BatalhaoWindows.Sections
{
    public class TwitterSection : Section<TwitterSchema>
    {
		private TwitterDataProvider _dataProvider;

		public TwitterSection()
		{
			_dataProvider = new TwitterDataProvider(new TwitterOAuthTokens
			{
				ConsumerKey = "QDv6j5SXvNmv0Akx75aXZBXCc",
                    ConsumerSecret = "057krEVK5vnPT2jR9mfO955o2XUdRK4pQZ7wTydRFDsTnMNMSX",
                    AccessToken = "501360842-KwpomgCdFT1zEaTeE4YjpAMftawvB22fuoOyo3UX",
                    AccessTokenSecret = "Jii385wqJdaC3Yy0JixdnpoQNo1iGZ9i2D2UVkMDLF4ht"
			});
		}

		public override async Task<IEnumerable<TwitterSchema>> GetDataAsync(SchemaBase connectedItem = null)
        {
            var config = new TwitterDataConfig
            {
                QueryType = TwitterQueryType.User,
                Query = @"@BatalhaoWindows"
            };
            return await _dataProvider.LoadDataAsync(config, MaxRecords);
        }

        public override async Task<IEnumerable<TwitterSchema>> GetNextPageAsync()
        {
            return await _dataProvider.LoadMoreDataAsync();
        }

        public override bool HasMorePages
        {
            get
            {
                return _dataProvider.HasMoreItems;
            }
        }

        public override ListPageConfig<TwitterSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<TwitterSchema>
                {
                    Title = "Twitter",

                    Page = typeof(Pages.TwitterListPage),

                    LayoutBindings = (viewModel, item) =>
                    {
						viewModel.Header = item.CreationDateTime.ToString(DateTimeFormat.ShortDate);
                        viewModel.Title = item.UserName.ToSafeString();
                        viewModel.SubTitle = item.Text.ToSafeString();
                        viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(item.UserProfileImageUrl.ToSafeString());

						viewModel.GroupBy = item.CreationDateTime.SafeType().Date;

						viewModel.OrderBy = item._id;
                    },
					OrderType = OrderType.Ascending,
                    DetailNavigation = (item) =>
                    {
                        return new NavInfo
                        {
                            NavigationType = NavType.DeepLink,
                            TargetUri = new Uri(item.Url)
                        };
                    }
                };
            }
        }

        public override DetailPageConfig<TwitterSchema> DetailPage
        {
            get { return null; }
        }
    }
}
