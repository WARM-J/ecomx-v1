using System;
using System.Collections.Generic;
using System.Text;
using SQLHelper;
using EcomReview.Library.Entity.Models;
using System.Threading.Tasks;

namespace EcomReview.Library.DataProvider
{
    public class ReviewDataProvider
    {
        public async Task AddReview(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_review_add_review", sQLParams);

        public async Task UpdateReview(List<SQLParam> sQLParams) =>
            await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("usp_review_update_review", sQLParams);
        
        public async Task<IEnumerable<ReviewModel>> GetReviewListUser(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<ReviewModel>("usp_review_get_all_review_by_user_id", sQLParams);
        }
        public async Task<IEnumerable<ReviewModel>> GetReviewListProduct(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<ReviewModel>("usp_review_get_all_review_by_product_id", sQLParams);
        }
        public async Task<IEnumerable<ReviewModel>> GetTopReview(List<SQLParam> sQLParams)
        {
            return await new SQLGetListAsync().ExecuteAsEnumerableAsync<ReviewModel>("usp_review_get_top_review_by_product_id", sQLParams);
        }
        public async Task<StarsModel> GetStarsProduct(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsObjectAsync<StarsModel>("usp_review_get_star_by_product_id", sQLParams);
        }
        public async Task<float> GetAvgRating(List<SQLParam> sQLParams)
        {
            return await new SQLGetAsync().ExecuteAsScalarAsync<float>("usp_review_get_avg_rating_of_product", sQLParams);
        }
  
    }
}
