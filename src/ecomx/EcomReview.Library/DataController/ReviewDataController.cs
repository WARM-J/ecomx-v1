using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using EcomReview.Library.DataProvider;
using System.Threading.Tasks;
using EcomReview.Library.Entity.Models;

namespace EcomReview.Library.DataController
{
    /// <summary>
    /// 
    /// </summary>
    public class ReviewDataController
    {
        readonly ReviewDataProvider _dataProvider = new ReviewDataProvider();
        public async Task AddReview(ReviewModel review)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductId",review.ProductId),
                new SQLParam("@CustomerId",review.CustomerId),
                new SQLParam("@Star",review.Star),
                new SQLParam("@ReviewMsg",review.ReviewMsg)
            };
            await _dataProvider.AddReview(sQLParams);
        }

        public async Task<IEnumerable<ReviewModel>> GetReviewByProductId(int ProductId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductId",ProductId)
            };
            return await _dataProvider.GetReviewListProduct(sQLParams);
        }

        public async Task<IEnumerable<ReviewModel>> GetReviewByCustomerId(int CustomerId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@CustomerId",CustomerId)
            };
            return await _dataProvider.GetReviewListUser(sQLParams);
        }
        public async Task<IEnumerable<ReviewModel>> GetTopRevew(int top,int ProductId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@top",top),
                new SQLParam("@ProductId",ProductId)
            };
            return await _dataProvider.GetTopReview(sQLParams);
        }
        public async Task<float> GetAvgStar(int ProductId)
        {
            List<SQLParam> sQLParams = new List<SQLParam>()
            {
                new SQLParam("@ProductId",ProductId)
            };
            return await _dataProvider.GetAvgRating(sQLParams);
        }

    }
}
